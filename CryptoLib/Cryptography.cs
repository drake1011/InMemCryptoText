using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoLib
{
    public static class Cryptography
    {
        #region Settings

        // If these setting change, previous encrypted files won't be able to decrypt using new setting if they were encrypted with old settings

        private static int _iterations = 7;
        private static int _keySize = 256;

        private static string _hash = "SHA1";
        private static string _salt = "gseRrias31490b32"; // Random
        private static string _vector = "1873az34rTl34kjq"; // Random

        #endregion

        /// <summary>
        /// Encrypt using AesManaged implementation of AES
        /// </summary>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Encrypted data as string</returns>
        public static string Encrypt(string value, string password)
        {
            return Encrypt<AesManaged>(value, password);
        }

        /// <summary>
        /// Encrypt using SymetricAlgorithm Cipher of choice
        /// </summary>
        /// <typeparam name="T">Implementation of SymetricAlgorithm (of choice)</typeparam>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Encrypted data as string</returns>
        public static string Encrypt<T>(string value, string password) where T : SymmetricAlgorithm, new()
        {
            byte[] vectorBytes = ASCIIEncoding.ASCII.GetBytes(_vector);
            byte[] saltBytes = ASCIIEncoding.ASCII.GetBytes(_salt);
            byte[] valueBytes = UTF8Encoding.UTF8.GetBytes(value);

            byte[] encrypted;
            using (T cipher = new T())
            {
                var _passwordBytes = new PasswordDeriveBytes(password, saltBytes, _hash, _iterations);
                byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                cipher.Mode = CipherMode.CBC;

                using (ICryptoTransform encryptor = cipher.CreateEncryptor(keyBytes, vectorBytes))
                {
                    using (var memStream = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(valueBytes, 0, valueBytes.Length);
                            cryptoStream.FlushFinalBlock();
                            encrypted = memStream.ToArray();
                        }
                    }
                }
                cipher.Clear();
            }
            return Convert.ToBase64String(encrypted);
        }

        /// <summary>
        /// Decrypt using AesManaged implementation of AES
        /// </summary>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Decrypted plain text as string</returns>
        public static string Decrypt(string value, string password)
        {
            return Decrypt<AesManaged>(value, password);
        }

        /// <summary>
        /// Decrypt using SymetricAlgorithm Cipher of choice
        /// </summary>
        /// <typeparam name="T">Implementation of SymetricAlgorithm (of choice)</typeparam>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Decrypted plain text as string</returns>
        public static string Decrypt<T>(string value, string password) where T : SymmetricAlgorithm, new()
        {
            byte[] vectorBytes = Encoding.ASCII.GetBytes(_vector);
            byte[] saltBytes = Encoding.ASCII.GetBytes(_salt);
            byte[] valueBytes = Convert.FromBase64String(value);

            byte[] decrypted;
            int decryptedByteCount = 0;
            string returnString = string.Empty;

            using (T cipher = new T())
            {
                var _passwordBytes = new PasswordDeriveBytes(password, saltBytes, _hash, _iterations);
                byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                cipher.Mode = CipherMode.CBC;

                try
                {
                    using (ICryptoTransform decryptor = cipher.CreateDecryptor(keyBytes, vectorBytes))
                    {
                        using (var memStream = new MemoryStream(valueBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                            {
                                decrypted = new byte[valueBytes.Length];
                                decryptedByteCount = cryptoStream.Read(decrypted, 0, decrypted.Length);
                            }
                        }
                    }
                    returnString = Encoding.UTF8.GetString(decrypted, 0, decryptedByteCount); 
                }
                catch(CryptographicException cex)
                {
                    if (cex.Message == "Padding is invalid and cannot be removed.")
                        throw new InvalidPasswordException("Cannot decrypt value, bad Password?", cex);
                }
                catch (Exception)
                {
                    throw;
                }

                cipher.Clear();
            }
            return returnString;
        }
    }
}

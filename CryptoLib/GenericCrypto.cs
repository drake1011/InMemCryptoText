using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLib
{
    public class GenericCrypto
    {
        private readonly string _hash;
        private readonly string _vector;
        private readonly string _salt;

        private readonly int _iterations;
        private readonly int _keySize;

        public GenericCrypto(CryptoOptions options)
        {
            _hash = options.Hash;
            _vector = options.Vector;
            _salt = options.Salt;
            _iterations = options.Iterations;
            _keySize = options.KeySize;
        }

        /// <summary>
        /// Encrypt using SymetricAlgorithm Cipher of choice
        /// </summary>
        /// <typeparam name="T">Implementation of SymetricAlgorithm (of choice)</typeparam>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Encrypted data as string</returns>
        public async Task<string> Encrypt<T>(string value, string password) where T : SymmetricAlgorithm, new()
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
                            await cryptoStream.WriteAsync(valueBytes, 0, valueBytes.Length);
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
        /// Decrypt using SymetricAlgorithm Cipher of choice
        /// </summary>
        /// <typeparam name="T">Implementation of SymetricAlgorithm (of choice)</typeparam>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Decrypted plain text as string</returns>
        public async Task<string> Decrypt<T>(string value, string password) where T : SymmetricAlgorithm, new()
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
                                    decryptedByteCount = await cryptoStream.ReadAsync(decrypted, 0, decrypted.Length);
                            }
                        }
                    }
                    returnString = Encoding.UTF8.GetString(decrypted, 0, decryptedByteCount);
                }
                catch (CryptographicException cex)
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

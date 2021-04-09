using System.Security.Cryptography;

namespace CryptoLib
{
    public class Cryptography : ICryptography
    {
        private readonly GenericCrypto _crypto;

        public Cryptography(GenericCrypto crypto)
        {
            _crypto = crypto;
        }

        /// <summary>
        /// Encrypt using AesManaged implementation of AES
        /// </summary>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Encrypted data as string</returns>
        public string Encrypt(string value, string password)
        {
            return _crypto.Encrypt<AesManaged>(value, password);
        }

        /// <summary>
        /// Decrypt using AesManaged implementation of AES
        /// </summary>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Decrypted plain text as string</returns>
        public string Decrypt(string value, string password)
        {
            return _crypto.Decrypt<AesManaged>(value, password);
        }
    }
}

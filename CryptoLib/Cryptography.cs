using System.Security.Cryptography;
using System.Threading.Tasks;

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
        public async Task<string> Encrypt(string value, string password)
        {
            return await _crypto.Encrypt<AesManaged>(value, password);
        }

        /// <summary>
        /// Decrypt using AesManaged implementation of AES
        /// </summary>
        /// <param name="value">value to encrypt</param>
        /// <param name="password">password to use for encryption and decription</param>
        /// <returns>Decrypted plain text as string</returns>
        public async Task<string> Decrypt(string value, string password)
        {
            return await _crypto.Decrypt<AesManaged>(value, password);
        }
    }
}

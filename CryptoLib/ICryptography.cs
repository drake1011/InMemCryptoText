using System.Threading.Tasks;

namespace CryptoLib
{
    public interface ICryptography
    {
        Task<string> Encrypt(string value, string password);

        Task<string> Decrypt(string value, string password);
    }
}

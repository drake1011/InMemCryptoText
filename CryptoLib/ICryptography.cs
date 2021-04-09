using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoLib
{
    public interface ICryptography
    {
        string Encrypt(string value, string password);

        string Decrypt(string value, string password);
    }
}

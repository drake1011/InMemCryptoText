using System;

namespace CryptoLib
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message, Exception inner) : base(message, inner) { }
    }
}

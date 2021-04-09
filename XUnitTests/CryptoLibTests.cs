﻿using CryptoLib;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using XUnitTests.Config;

namespace XUnitTests
{
    public class CryptoLibTests : BaseConfigSetup
    {
        private readonly ICryptography _crypto;

        public CryptoLibTests()
        {
            _crypto = ServiceProvider.GetService<ICryptography>();
        }

        #region Cryptography

        [Fact]
        public async Task Cryptography_aes_encrypt_and_decrypt_match_Pass()
        {
            var resultString = await _crypto.Encrypt("my secret", "myPass");
            var decriptedResultString = await _crypto.Decrypt(resultString, "myPass");
            Assert.Equal("my secret", decriptedResultString);
        }

        [Fact]
        public async Task Cryptography_aes_encrypt_and_decrypt_match_long_value_Pass()
        {
            const string value = "my secret super long value that isnt very short it is actually really really really, really really 01234566, really really long" +
                "almost too long tbg.\n This is not the end of this long value. 1234567012349412349 1234921349213 1234923942139 really 123049321940194320. " +
                "This IS LOONG! 12343214098239048092314809823140982309840 012398409 42309 01932840 918804 l 023984098109230984032981 this is a testhello";
            var resultString = await _crypto.Encrypt(value, "myPass");
            var decriptedResultString = await _crypto.Decrypt(resultString, "myPass");
            Assert.Equal(value, decriptedResultString);
        }

        [Theory]
        [InlineData("my super Secret Data", "my Dull password")]
        [InlineData("MORE super Secret Data!", "P@S$woRD!^")]
        [InlineData("awes0me DATa", "0000001230000000")]
        public async Task Cryptography_aes_encrypt_and_decrypt_match_Theory_Pass(string value, string password)
        {
            var resultString = await _crypto.Encrypt(value, password);
            var decriptedResultString = await _crypto.Decrypt(resultString, password);
            Assert.Equal(value, decriptedResultString);
        }

        [Fact]
        public async Task Cryptography_aes_encrypt_and_decrypt_bad_pass_Fail()
        {
            var resultString = await _crypto.Encrypt("my secret", "myPass");
            await Assert.ThrowsAsync<InvalidPasswordException>(async () => await _crypto.Decrypt(resultString, "myPassBogus"));
        }

        [Theory]
        [InlineData("my super Secret Data", "my Dull password")]
        [InlineData("MORE super Secret Data!", "P@S$woRD!^")]
        [InlineData("awes0me DATa", "0000001230000000")]
        public async Task Cryptography_aes_encrypt_and_decrypt_bad_pass_Theory_Fail(string value, string password)
        {
            var resultString = await _crypto.Encrypt(value, password);
            var bogusPw = password + "BOGUS";
            await Assert.ThrowsAsync<InvalidPasswordException>(async () => await _crypto.Decrypt(resultString, bogusPw));
        }

        #endregion
    }
}

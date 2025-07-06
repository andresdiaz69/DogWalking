namespace ECI.DogWalking.Test.UtilsTests
{
    using ECI.Common.Core.Utils;
    using System;

    public class EncryptTest
    {
        [Fact]
        public void EncryptToMD5_ReturnsExpectedMD5()
        {
            // Arrange
            var textToEncrypt = "admin";

            // Act
            var result = Encrypt.EncryptToMD5(textToEncrypt);

            // Assert
            Assert.Equal("21232f297a57a5a743894a0e4a801fc3", result);
        }

        [Fact]
        public void EncryptToMD5_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Encrypt.EncryptToMD5(null));
        }
    }
}

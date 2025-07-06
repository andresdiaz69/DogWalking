namespace ECI.DogWalking.Test.UtilsTests
{
    using ECI.Common.Core.Utils;

    public class ValidateFieldsTests
    {
        [Fact]
        public void isValidEmail_ReturnsFalse()
        {
            // Arrange
            var mail = "emailnotok@";

            // Act
            var result = ValidateFields.isValidEmail(mail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void isValidEmail_ReturnsTrue()
        {
            // Arrange
            var mail = "emailok@eci.com";

            // Act
            var result = ValidateFields.isValidEmail(mail);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void isNumber_ReturnsFalse()
        {
            // Arrange
            var number = "Not An Int";

            // Act
            var result = ValidateFields.isNumber(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void isNumber_ReturnsTrue()
        {
            // Arrange
            var number = "66984";

            // Act
            var result = ValidateFields.isNumber(number);

            // Assert
            Assert.True(result);
        }

    }
}

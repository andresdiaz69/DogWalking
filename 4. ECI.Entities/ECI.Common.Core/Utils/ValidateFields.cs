namespace ECI.Common.Core.Utils
{
    public static class ValidateFields
    {
        /// <summary>
        /// Determines whether [is valid email] [the specified email].
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        ///   <c>true</c> if [is valid email] [the specified email]; otherwise, <c>false</c>.
        /// </returns>
        public static bool isValidEmail(string email)
        {
            try { return new System.Net.Mail.MailAddress(email).Address == email; }
            catch { return false; }
        }

        /// <summary>
        /// Determines whether the specified text is number.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if the specified text is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool isNumber(string text) 
        {
            try { return int.TryParse(text , out int valor); }
            catch { return false; }
        }
    }
}

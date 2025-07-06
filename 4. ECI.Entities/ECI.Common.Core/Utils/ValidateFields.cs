namespace ECI.Common.Core.Utils
{
    public static class ValidateFields
    {
        public static bool isValidEmail(string email)
        {
            try { return new System.Net.Mail.MailAddress(email).Address == email; }
            catch { return false; }
        }

        public static bool isNumber(string text) 
        {
            try { return int.TryParse(text , out int valor); }
            catch { return false; }
        }
    }
}

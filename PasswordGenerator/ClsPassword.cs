using System;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator
{
    internal class ClsPassword
    {
        public static short Length { get; set; }
        public static bool IsIntegerNeeded { get; set; }
        public static bool IsLowerCaseNeeded { get; set; }
        public static bool IsUpperCaseNeeded { get; set; }
        public static bool IsSpecialCharNeeded { get; set; }
        public static bool IsMemorable { get; set; }
        public static string KeyWord { get; set; }
        public static double NumberOfBits { get; private set; }
        private static string _characterSet;
        private static readonly Random _random = new Random();
        private static readonly string _intCharacters = "0123456789";
        private static readonly string _lowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string _uppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string _specialCharacters = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~ ";

        public static void CalculatePasswordEntropy(string password)
        {
            if (!IsCharacterSetNotEmpty())
                return;
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty.");
            int characterSetSize = 0;
            if (password.Any(char.IsLower)) characterSetSize += 26;
            if (password.Any(char.IsUpper)) characterSetSize += 26;
            if (password.Any(char.IsDigit)) characterSetSize += 10;
            if (password.Any(ch => _specialCharacters.Contains(ch)))
                characterSetSize += 32;
            if (password.Any(ch => char.IsWhiteSpace(ch)))
                characterSetSize += 1;
            if (characterSetSize == 0)
                throw new ArgumentException("Password contains unsupported characters.");
            NumberOfBits = password.Length * Math.Log(characterSetSize);
        }

        private static bool IsCharacterSetNotEmpty()
        {
            return IsIntegerNeeded ||
                IsLowerCaseNeeded ||
                IsUpperCaseNeeded ||
                IsSpecialCharNeeded ||
                (IsMemorable && KeyWord != null && KeyWord.Length > 0);
        }

        private static void GeneratePasswordMaterial(bool isMemorable = false)
        {
            _characterSet = "";
            if (isMemorable)
                _characterSet += KeyWord;
            else
            {
                if (IsIntegerNeeded)
                    _characterSet += _intCharacters;
                if (IsLowerCaseNeeded)
                    _characterSet += _lowercaseCharacters;
                if (IsUpperCaseNeeded)
                    _characterSet += _uppercaseCharacters;
                if (IsSpecialCharNeeded)
                    _characterSet += _specialCharacters;
            }
            if (_characterSet == "")
                MessageBox.Show("Character set cannot be empty!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        public static string GeneratePassword()
        {
            string password = "";
            if (IsMemorable && KeyWord.Length > 0)
            {
                GeneratePasswordMaterial(true);
                if (Length % KeyWord.Length == 0)
                {
                    while(password.Length < Length)
                        password += KeyWord;
                }
                else
                {
                    do
                    {
                        password += KeyWord;
                    }
                    while (Length - password.Length > Length % KeyWord.Length);
                    if (Length % KeyWord.Length != 0)
                    {
                        for (int i = 0; i < Length % KeyWord.Length; i++)
                        {
                            password += _random.Next(0, 9).ToString();
                        }
                    }
                }
            }
            else
            {
                GeneratePasswordMaterial();
                if (_characterSet.Length > 0)
                    for (int i = 0; i < Length; i++)
                    {
                        password += _characterSet[_random.Next(0, _characterSet.Length)];
                    }
            }
            return password;
        }
    }
}

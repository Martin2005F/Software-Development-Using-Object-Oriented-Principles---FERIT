using StructualPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Classes
{
    public class RegistrationValidator : IRegistrationValidator
    {
        private IPasswordValidatorService passwordValidator;
        private IEmailValidatorService emailValidator;

        public RegistrationValidator()
        {
            this.passwordValidator = new PasswordValidator(8);
            this.emailValidator = new EmailValidator();
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            bool isPasswordValid = passwordValidator.IsValidPassword(entry.Password);
            bool isEmailValid = emailValidator.IsValidAddress(entry.Email);

            if (!isEmailValid)
            {
                Console.WriteLine("Invalid email address format.");
            }

            if (!isPasswordValid)
            {
                Console.WriteLine("Invalid password. Must be 8+ chars, contain upper, lower and digit.");
            }

            return isPasswordValid && isEmailValid;
        }
    }
}

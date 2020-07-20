using System;
using System.ComponentModel.DataAnnotations;

namespace Types.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UserPasswordAttribute : ValidationAttribute
    {
        public int Length { get; }

        public UserPasswordAttribute(int length = 4)
        {
            Length = length;
        }

        public override bool IsValid(object value)
        {
            var userPassword = (string)value;

            if (userPassword.Length >= Length)
            {
                return true;
            }

            return false;
        }
    }
}
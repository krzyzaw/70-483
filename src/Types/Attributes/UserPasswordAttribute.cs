using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Types.Classes;

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

    public class TestAttributes : Attribute
    {
        public static void Test()
        {
            var user = new User("user1@email.com", "secret123", 15);
            var passwordAttribute = (UserPasswordAttribute)user.GetType()
                .GetTypeInfo()
                .GetProperty("Password")
                .GetCustomAttribute(typeof(UserPasswordAttribute));

            var isPasswordValid = user.Password.Length >= passwordAttribute.Length;
            Console.WriteLine($"Is valid: {isPasswordValid}");
        }
    }
}
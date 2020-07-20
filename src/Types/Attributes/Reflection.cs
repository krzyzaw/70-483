using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Types.Classes;
using Types.Interfaces;

namespace Types.Attributes
{
    public class Reflection
    {
        public static void Test()
        {
            var user = new User("user1@email.com", "secret", 15);
            var type = user.GetType().GetTypeInfo();
            Console.WriteLine($"{type.Name} {type.FullName}");

            // var methods = type.GetMethods();
            // foreach (var methodInfo in methods)
            // {
            //     Console.WriteLine($"{methodInfo.Name}");
            // }
            //
            // user.Activate();
            // Console.WriteLine($"Is active: {user.IsActive}");
            //
            // var deactivateMethod = methods.First(x => x.Name == "Deactivate");
            // deactivateMethod.Invoke(user, null);
            // Console.WriteLine($"Is active: {user.IsActive}");
            //
            // Console.WriteLine($"{user.Email}");
            // var setEmailMethod = type.GetMethod("SetEmail");
            // setEmailMethod.Invoke(user, new[] { "user2@email.com" });
            // Console.WriteLine($"{user.Email}");
            //
            // var email = type.GetProperty("Email")?.GetValue(user);
            // Console.WriteLine(email);
            //
            // Assembly assembly = Assembly.GetExecutingAssembly();
            //
            //
            // List<Type> AccountTypes = new List<Type>();
            //
            // foreach (var t in assembly.GetTypes())
            // {
            //     if (t.IsInterface)
            //         continue;
            //
            //     if (typeof(IAccount).IsAssignableFrom(t))
            //     {
            //         Console.WriteLine(t.Name);
            //         AccountTypes.Add(t);
            //     }
            // }
            //
            // var repositories = assembly.GetTypes()
            //     .Where(x => x.Name.Contains("Repository"));
            //
            //
            // foreach (var repository in repositories)
            // {
            //     Console.WriteLine(repository.Name);
            // }
            //
            // var user2 = Activator.CreateInstance(typeof(User), new[] { "user3@email.com", "secret2" }) as User;
            // Console.WriteLine(user2.Email);
        }
    }
}
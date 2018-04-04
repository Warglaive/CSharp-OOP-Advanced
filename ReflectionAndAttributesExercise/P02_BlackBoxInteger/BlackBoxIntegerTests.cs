using System.Linq;
using System.Reflection;

namespace P02_BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var type = typeof(BlackBoxInteger);
            var classInstance = Activator.CreateInstance(type, true);
            var fields = type.GetFields(
                BindingFlags.NonPublic
                | BindingFlags.Instance);

            var methods = type.GetMethods(
                BindingFlags.NonPublic
                | BindingFlags.Instance);

            var input = Console.ReadLine();
            while (input != "END")
            {
                var commands = input.Split('_');
                var methodName = commands[0];
                var value = int.Parse(commands[1]);

                methods.FirstOrDefault(m => m.Name == methodName)
                       .Invoke(classInstance, new object[] { value });

                foreach (var field in fields)
                {
                    Console.WriteLine(field.GetValue(classInstance));
                }
                input = Console.ReadLine();
            }
        }
    }
}

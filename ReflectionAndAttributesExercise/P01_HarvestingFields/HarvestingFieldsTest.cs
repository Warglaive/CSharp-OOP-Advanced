using System.Linq;
using System.Reflection;

namespace P01_HarvestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var type = typeof(HarvestingFields);
            var fields = type.GetFields(
                BindingFlags.NonPublic
                | BindingFlags.Instance
                | BindingFlags.Public);

            var input = Console.ReadLine();

            while (input != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        PrintPrivateFields(fields);
                        break;
                    case "protected":
                        PrintProtectedFields(fields);
                        break;
                    case "public":
                        PrintPublicFields(fields);
                        break;
                    case "all":
                        foreach (var field in fields)
                        {
                            var attribute = field.Attributes.ToString();
                            if (attribute == "Family")
                            {
                                attribute = "protected";
                            }
                            Console.WriteLine($"{attribute.ToLower()} {field.FieldType.Name} {field.Name}");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }

        private static void PrintPrivateFields(FieldInfo[] fields)
        {
            foreach (var field in fields
                                        .Where(f => f.IsPrivate))
            {
                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
            }
        }

        private static void PrintProtectedFields(FieldInfo[] fields)
        {
            foreach (var protectedField in fields
                .Where(f => f.IsFamily))
            {
                Console.WriteLine($"protected {protectedField.FieldType.Name} {protectedField.Name}");
            }
        }

        private static void PrintPublicFields(FieldInfo[] fields)
        {
            foreach (var publicField in fields
                .Where(f => f.IsPublic))
            {
                Console.WriteLine(
                    $"{publicField.Attributes.ToString().ToLower()} {publicField.FieldType.Name} {publicField.Name}");
            }
        }
    }
}

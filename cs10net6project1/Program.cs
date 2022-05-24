using cs10net6project1;
using System;
using System.Reflection;
using System.Xml;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //Console.WriteLine("Hello Ahmed");
            //Console.WriteLine("Temperature on {0:D} is {1} °C.", DateTime.Today, 23.4);

            Assembly? assembly = Assembly.GetEntryAssembly();
            if (assembly == null) return;

            foreach (AssemblyName name in assembly.GetReferencedAssemblies())
            {
                Assembly a = Assembly.Load(name);
                int methodCount = 0;
                foreach (TypeInfo t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }

                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount, arg2: name.Name);
            }

            System.Data.DataSet ds;
            HttpClient client;

            double heightInMeters = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}.");

            char letter = 'A';
            char digit = '1';
            char symbol = '$';

            string firstName = "Bob";
            string lastName = "Smith";
            string phoneNumber = "(215)555-4256";

            string fullNameWithTabSeparator = "Bob\tSmith";
            //string filePath = "C:\televisions\sony";
            string filePath2 = @"C:\televisions\sony";

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
            Console.WriteLine($"deciaml uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

            //check what each "var" shows on hover
            var populatoin = 66_000_000;
            var weight = 1.88;
            var price = 4.99M;
            var fruits = "apple";
            var letter2 = 'L';
            var happy = true;

            var xml1 = new XmlDocument();
            //instead of XmlDocument xml2 = new XmlDocument();, less verbose
            //this is another way to instantiate objects with C# 9
            XmlDocument xml3 = new();

            Person kim = new();
            kim.BirthDate = new(1967, 12, 26);
            Console.WriteLine(kim.BirthDate);

            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            Console.Write("Type your name and press Enter :");           
            string? firstName1 = Console.ReadLine();

            Console.Write("Type your age and press Enter :");
            string? age1 = Console.ReadLine();

            Console.WriteLine($"Hello {firstName1}, you look good for {age1}.");

            Console.Write("Press any key combination:");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Key : {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers);
        }

    }
       
}
// See https://aka.ms/new-console-template for more information

            

        
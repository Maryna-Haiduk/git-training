using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_training_project
{
    public class Methods
    {
        public static void NameCreator()
        {
            Console.Write("Please, write your name here: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        public static void AgeCreator() 
        {
            Console.Write("Please, write your age here: ");
            Int32.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine($"Your age is: {age}");
        }

        public static void EmailCreator()
        {
            Console.Write("Please, write your email here: ");
            string email = Console.ReadLine();
            Console.WriteLine($"Your email is: {email}");
        }
    }
}

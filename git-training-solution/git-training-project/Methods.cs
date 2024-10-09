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
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}

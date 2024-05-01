using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInPraktik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Original value";
            Console.WriteLine(myString);
            ChangeInput(ref myString); 
            Console.WriteLine(myString);
            Console.ReadLine();
        }
        static void ChangeInput(ref string input)
        {
            input = "Changed value";
        }
    }
}

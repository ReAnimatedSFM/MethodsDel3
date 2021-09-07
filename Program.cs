using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDel3
{
    class Program
    {

        private static string ToString(char[] a)
        {
            string b = new string(a);
            return b;
        }

        private static char[] Generate(int Lenght)
        {
            if (Lenght <= 9)
            {
                Random rnd = new Random();
                char randomChar;
                char[] charArray = new char['a'];
                for (int i = 0; i < Lenght; i++)
                {
                    int intRandom = rnd.Next(0, 26);
                    randomChar = (char)('a' + intRandom);
                    charArray[i] = randomChar;
                }
                ToString(charArray);
                return charArray;
            }
                char[] error = { 'F', 'E','J','L' };
                return error;
                    
            
        }

        static void Main(string[] args)
        {

            /*
            char[] charArray = {'W','I','L','L','I','A','M' };
            string aString = ToString(charArray);
            Console.WriteLine(aString);
            */

            Console.WriteLine("Dette program udskriver en sætning med bogstaver mellem a-z");
            Console.Write("Indtast et tal mellem 1 og 9: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Generate(userInput));

            Console.ReadKey();
        }
    }
}

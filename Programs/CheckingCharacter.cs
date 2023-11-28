using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
     class CheckingCharacter
    {
        static void Main()
        {
            Console.WriteLine(  "enter character");
            char chracter=Console.ReadKey().KeyChar;
            Console.WriteLine(  );
            if (Char.IsLetter(chracter))
            {
                Console.WriteLine("the character is an alphabet");
            }
            else if(Char.IsDigit(chracter))
            {
                Console.WriteLine("The character is digit");
            }
            else
            {
                Console.WriteLine(  "the character is special character");
            }
        }
    }
}

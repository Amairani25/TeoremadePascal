using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoremadePascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Inserta el lado a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta el lado b ");
            b = int.Parse(Console.ReadLine());
            c =(a * a) + (b * b);
            
            Console.WriteLine(" La hipotenusa mide: " + Math.Sqrt(c));
            Console.ReadKey();
        }
    }
}

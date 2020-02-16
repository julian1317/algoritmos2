using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******CALCULADORA*******");
            double a, b,t;
            byte c;
            Console.WriteLine("digite numero 1");
            a=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite numero 2");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese operacion deseada" +
                " 1 para suma" +
                " 2para resta" +
                " 3 para multiplicacion" +
                " 4 para division");
            c = Convert.ToByte(Console.ReadLine());

            if (c==1)
            {
                t = a + b;
                Console.WriteLine("el resultado es {0}", t);
            }
            if (c == 2)
            {
                t = a - b;
                Console.WriteLine("el resultado es {0}", t);
            }
            if (c == 3)
            {
                t = a * b;
                Console.WriteLine("el resultado es {0}", t);
            }
            else
            {
                t = a / b;
                Console.WriteLine("el resultado es {0}",t);
            }
            
          

            Console.ReadKey();

        }
    }
}

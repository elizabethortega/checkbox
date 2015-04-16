using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTreeCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            Console.WriteLine("Digite numero:");
            numero = int.Parse(Console.ReadLine());
            try
            {
                resultado = 5 / numero;

            }

            catch (Exception error)
            {
                Console.WriteLine("el error es :" + error.Message);
            }


            Console.ReadKey();
        }
    }
}

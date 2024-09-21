using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoEnElPlano
{
    public class Program
    {
        static void Main(string[] args)
        {
            punto punto = new punto();

            try
            {
                Console.WriteLine("ingrese el valor de x:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el valor de y:");
                int y = int.Parse(Console.ReadLine());

                punto.cargarpunto(x, y);

                punto.imprimirCuadrante();

            }
            catch (Exception)
            {
                Console.WriteLine("error: debe ingresar numeros validos:");
                
            }
        }
    }
}

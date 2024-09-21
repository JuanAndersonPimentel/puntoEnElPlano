using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace puntoEnElPlano
{
    public class punto
    {
        private int x;
        private int y;

        public void cargarpunto(int valorx, int valory)
        {
            x = valorx;
            y = valory;
   
        }
        public void imprimirCuadrante() 
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("el punto esta en el primer cuadrante:");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("el puneto esta en el segundo cuadrante:");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("el punto esta en el cuatro cuadrante:");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("el punto esta en el origen:");
            }
            else if (x == 0)
            {
                Console.WriteLine("el punto esta sobre el eje y.");
            }
            else if (y == 0)
            {
                Console.WriteLine("el punto esta sobre el eje x.");
            }


            
        }
        

        

        
       
        
           



    }


}

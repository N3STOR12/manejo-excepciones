using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExcepsiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraciones de variable
            int num, numeroElevado;
            //Realizar la carga de un número entero por teclado e imprimir su cuadrado.


            //Creacion de excepsiones 
            try
            {
                Console.Write("Introduce un numero: ");
                num = int.Parse(Console.ReadLine());

                numeroElevado = (int)Math.Pow(num, 2);
                Console.WriteLine("El numero elevado es: " + numeroElevado);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

          
            
        }
    }
}

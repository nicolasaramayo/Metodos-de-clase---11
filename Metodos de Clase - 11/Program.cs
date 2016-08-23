using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Clase___11
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Consigna.
            /*  Ingrese 10 números enteros que pueden estar dentro de un rango
                de entre 100 y -100.
                Para ello realizar una clase llamada 'Validacion' que posea un
                método estátatico llamdo 'Validar', que posea la siguiente firma:
                            
                        bool Validar(int, int, int).

                Terminado el ingreso mostrar el valor mínimo, el valor máximo 
                el promedio.

            nota: Utilizar variables escalares, NO utilizar vectores.

            */
            #endregion

            bool DentroDelRango;
            int numero;

            //Le pido que ingrese un numero entero...
            Console.WriteLine("Por favor ingresa un número entero...");

            while (!Int32.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Ingresa un numero, no una letra...");
            }

            
            DentroDelRango = Validacion.Validar(-100, 100, numero);


            if (DentroDelRango)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("el numero ingresado se encuentra dentro del rango -100 y 100");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("el numero ingresado NO se encuentra dentro del rango -100 y 100");
            }
            
            Console.ReadKey();

        }
    }
}

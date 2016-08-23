using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Clase___11
{
    class Validacion
    {
        /// <summary>
        /// Retorna ''false' si el valor ingresado no se encuentra dentro del rango.
        /// </summary>
        /// <param name="valorMinimo"> Valor mínimo a comparar. </param>
        /// <param name="valorMaximo"> Valor máximo a comparar. </param>
        /// <param name="valorIngresado"> Número ingresado a comparar dentro del rango. </param>
        /// <returns></returns>
        public static bool Validar(int valorMinimo, int valorMaximo, int valorIngresado)
        {
            if (valorIngresado < valorMinimo || valorIngresado > valorMaximo)
            {
                return false;
            }

            return true;
        }
    }
}

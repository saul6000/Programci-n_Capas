using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
     public class  Operaciones
    {
        /// <summary>
        /// Calcula la suma de los elementos de un array 
        /// </summary>
        /// <param name="array"></param>
        /// <returns>double</returns>
       public double suma(double [] array)
        {
            double suma = 0;
            foreach (double x in array)
            {
                suma += x;
            }
            return suma;
        }
        /// <summary>
        /// retorna una cadena con saludo
        /// </summary>
        /// <param name="nombrePersona"></param>
        /// <returns></returns>
        public string saludo(string nombrePersona)
        {
            return  "Bienvenido " + nombrePersona;
        }
    }
}

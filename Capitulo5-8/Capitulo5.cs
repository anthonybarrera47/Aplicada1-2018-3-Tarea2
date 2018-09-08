using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5_8
{
    class Ejercicio4_5
    {
        public static int Ejercicio4(int n)// Hacer una función que calcule el factorial de un número.
        {
            return n = (n < 2) ? n : n * Ejercicio4(n - 1);
        }
        public static String Ejercicio5(int n)//Hacer una función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.

        {
            switch(n)
            {
                case 0:
                    return "Cero";
                case 1:
                    return "Uno";
                case 2:
                    return "Dos";
                case 3:
                    return "Tres";
                case 4:
                    return "Cuatro";
                case 5:
                    return "Cinco";
                case 6:
                    return "Seis";
                case 7:
                    return "Siete";
                case 8:
                    return "Ocho";
                case 9:
                    return "Nueve";
                default:
                    return "Debe ser un numero de un digito";
            }
        }
    }
}

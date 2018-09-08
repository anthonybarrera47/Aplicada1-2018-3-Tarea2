using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Capitulo5_8
{
    public class Capitulo8
    {
        public Capitulo8()
        {

        }
        public static void Ejercicio3()//Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm tt yyyy/dd/MM"));

        }
        public static void Ejercicio5()//Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.
        {
            Console.WriteLine("Digite la cadena 1");
            String cadena1 = Console.ReadLine();
            Console.WriteLine("Digite la cadena 2");
            String cadena2 = Console.ReadLine();
            ArrayList array = new ArrayList();
            array.Add(cadena1);
            array.Add(cadena2);
            array.Sort();
            Console.WriteLine("Ordenado: ");
            foreach(String cadena in array)
            {
                Console.WriteLine("{0}", cadena);
            }
        }
    }
}

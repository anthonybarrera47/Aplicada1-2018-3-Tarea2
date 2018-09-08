using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5_8
{
    public class Capitulo7
    {
        public Capitulo7()
        {

        }
        public static void Ejercicio1() //Hacer el programa que calcula el promedio, calificación máxima y mínima de un salón de clases usando el ArrayList.
        {
            //Declaracion de las variables.
            ArrayList calificaciones = new ArrayList();
            float calificacion= 0f;
            int i = 0;
            float promedio = 0f;
            float maxima = 0f;
            float minima = 100f;
            int salida = 0; ;

            Console.WriteLine("Cuando Desee terminar de agregar notas , digite -1\n");
            do
            {
                Console.WriteLine("Digite la calificacion del estudiante: {0}", i + 1);
                calificacion = Convert.ToSingle(Console.ReadLine());
                //Aqui determinamos la calificacion mas alta y la mas pequeña
                if (maxima < calificacion)
                    maxima = calificacion;
                if (minima > calificacion && calificacion != -1)
                    minima = calificacion;
                if (calificacion == -1)
                    salida = Convert.ToInt32(calificacion);
                else
                    calificaciones.Add(calificacion);
                i++;

            } while (salida != -1);
            //Creamos un ForEach para imprimir todos los elementos dentro del ArrayList.
            foreach (float n in calificaciones)
            {
                promedio += n;
            }
            //Aca Imprimimos los Resultados.
            Console.WriteLine("El promedio es: " + promedio / calificaciones.Count);
            Console.WriteLine("La nota Maxima es: " + maxima);
            Console.WriteLine("La nota Minima es: " + minima);
        }
        public static void Ejercicio2() //Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.
        {
            Hashtable diccionarioHT = new Hashtable();
            Console.WriteLine("Digite la cantidad de palabras que quiere agregar:");
            int j = Convert.ToInt32(Console.ReadLine());
            //En este ciclo agregamos los datos a la tabla Hash creada
            for(int i = 0;i<j;i++)
            {
                Console.WriteLine("Digite la palabra: ");
                String palabra = Console.ReadLine();
                Console.WriteLine("Digite la definicion;");
                String definicion = Console.ReadLine();
                diccionarioHT.Add(palabra, definicion);
            }
            //Utilizamos un ForEach para sacar los datos de la tabla hash con su respectivo Key y Value.
            foreach(DictionaryEntry d in diccionarioHT)
            {
                Console.WriteLine("{0}: {1}",d.Key,d.Value);
            }
        }
        public static void Ejercicio5() //Hacer un programa que funcione como una agenda telefónica y que guarde el nombre de la persona y su número telefónico.
        {
            Hashtable agendaHT = new Hashtable();
            Console.WriteLine("Digite la cantidad de Personas que quiere agregar en su agenda:");
            int j = Convert.ToInt32(Console.ReadLine());
            //En este ciclo agregamos los datos a la tabla Hash creada
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Nombre de la persona: ");
                String nombre = Console.ReadLine();
                Console.WriteLine("Numero de la persona");
                int numero = Convert.ToInt32(Console.ReadLine());
                agendaHT.Add(nombre, numero);
            }
            //Utilizamos un ForEach para sacar los datos de la tabla hash con su respectivo Key y Value.
            foreach (DictionaryEntry d in agendaHT)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }
    }
}

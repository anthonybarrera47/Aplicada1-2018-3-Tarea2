using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5_8
{
    public class Capitulo6
    {
        public Capitulo6()
        {

        }

        public static void Ejercicio1()// Agregar el cálculo del promedio para el programa con arreglo jagged.
        {
            int cantidadEstudiantes = 0, cantidadSalones = 0;
            float suma = 0.0f;
            float promedio = 0.0f;

            Console.Write("\nDigite la cantidad de salones: ");
            cantidadSalones = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[cantidadSalones][];

            for (int i = 0; i < cantidadSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);

                cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

                calificaciones[i] = new float[cantidadEstudiantes];
            }

            for (int i = 0; i < cantidadSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n ", i + 1);
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion del estudiante: {0} ", 1 + j);
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (int i = 0; i < cantidadSalones; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    suma += calificaciones[i][j];

                }
            }
            promedio = suma / (cantidadEstudiantes * cantidadSalones);
            Console.WriteLine("\nEl promedio es: {0}\n", promedio);
        }
        public static void Ejercicio2()// Agregar el cálculo de la menor calificación para el programa con arreglo jagged.
        {
            int cantidadEstudiantes = 0, cantidadSalones = 0, i = 0, j = 0;
            float minima = 100.0f;

            Console.Write("\nDigite la cantidad de salones: ");

            cantidadSalones = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[cantidadSalones][];

            for (i = 0; i < cantidadSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);
                cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

                calificaciones[i] = new float[cantidadEstudiantes];
            }

            for (i = 0; i < cantidadSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n", i + 1);
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion: ");
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (i = 0; i < cantidadSalones; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] < minima)
                    {
                        minima = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("\nLa nota mas baja es: {0}\n", minima);
        }
        public static void Ejercicio3()//Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.
        {
            int cantidadEstudiantes = 0, cantidadSalones = 0, i = 0, j = 0;
            float maxima = 0.0f;
            

            Console.Write("\nDigite la cantidad de salones: ");
            cantidadSalones = Convert.ToInt32(Console.ReadLine());

            float[][] calificacion = new float[cantidadSalones][];

            for (i = 0; i < cantidadSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);
                cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

                calificacion[i] = new float[cantidadEstudiantes];
            }

            for (i = 0; i < cantidadSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n", i + 1);
                for (j = 0; j < calificacion[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion: ");
                    calificacion[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (i = 0; i < cantidadSalones; i++)
            {
                for (j = 0; j < calificacion[i].GetLength(0); j++)
                {
                    if (calificacion[i][j] > maxima)
                    {
                        maxima = calificacion[i][j];
                    }
                }
            }
            Console.WriteLine("\nLa nota mas alta es: {0}\n", maxima);
        }
        public static void Ejercicio4()// Modificar el programa de la escuela para que utilice funciones.
        {
            int cantidadEstudiantes = 0, cantidadSalones = 0;
            float suma = 0.0f;
            float promedio = 0.0f;

            Console.Write("\nDigite la cantidad de salones: ");
            cantidadSalones = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[cantidadSalones][];

            for (int i = 0; i < cantidadSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);

                cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

                calificaciones[i] = new float[cantidadEstudiantes];
            }

            for (int i = 0; i < cantidadSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n ", i + 1);
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion del estudiante: {0} ", 1 + j);
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (int i = 0; i < cantidadSalones; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    suma += calificaciones[i][j];

                }
            }
            promedio = suma / (cantidadEstudiantes * cantidadSalones);
            Console.WriteLine("\nEl promedio es: {0}\n", promedio);
        }
        public static void Ejercicio5(int[][] a)//Crear un programa que pase un arreglo jagged como parámetro a una función.
        {
            
           

            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a.GetLength(0);j++)
                {
                    Console.WriteLine("{0}", a[i][j]);
                }
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5_8
{
    class Menu
    {
        public Menu()
        {
            menu();
        }
        private static void menu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Capitulo 5");
                Console.WriteLine("\t1.Ejercicio 4");
                Console.WriteLine("\t2.Ejercicio 5");
                Console.WriteLine("Capitulo 6");
                Console.WriteLine("\t3.Ejercicio 1");
                Console.WriteLine("\t4.Ejercicio 2");
                Console.WriteLine("\t5.Ejercicio 3");
                Console.WriteLine("\t6.Ejercicio 4");
                Console.WriteLine("\t7.Ejercicio 5");
                Console.WriteLine("Capitulo 7");
                Console.WriteLine("\t8.Ejercicio 1");
                Console.WriteLine("\t9.Ejercicio 2");
                Console.WriteLine("\t10.Ejercicio 5");
                Console.WriteLine("Capitulo 8");
                Console.WriteLine("\t11.Ejercicio 3");
                Console.WriteLine("\t12.Ejercicio 5");
                Console.WriteLine("\t13.Salir");
                int opc = Convert.ToInt32(Console.ReadLine());
                
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(Ejercicio4_5.Ejercicio4(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(Ejercicio4_5.Ejercicio5(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 3:
                        Console.Clear();
                        Capitulo6.Ejercicio1();
                        break;
                    case 4:
                        Console.Clear();
                        Capitulo6.Ejercicio2();
                        break;
                    case 5:
                        Console.Clear();
                        Capitulo6.Ejercicio3();
                        break;
                    case 6:
                        Console.Clear();
                        Capitulo6.Ejercicio4();
                        break;
                    case 7:
                        Console.Clear();
                        int[][] a = new int[2][];
                        a[0] = new int[] { 1, 2 };
                        a[1] = new int[] { 3, 4 };
                        Capitulo6.Ejercicio5(a);
                        break;
                    case 8:
                        Console.Clear();
                        Capitulo7.Ejercicio1();
                        break;
                    case 9:
                        Console.Clear();
                        Capitulo7.Ejercicio2();
                        break;
                    case 10:
                        Console.Clear();
                        Capitulo7.Ejercicio5();
                        break;
                    case 11:
                        Console.Clear();
                        Capitulo8.Ejercicio3();
                        break;
                    case 12:
                        Console.Clear();
                        Capitulo8.Ejercicio5();
                        break;
                    case 13:
                        Console.WriteLine("Gracias Por Utilizar Este Programa :)");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
                menu();
            } 
        }
    }
}

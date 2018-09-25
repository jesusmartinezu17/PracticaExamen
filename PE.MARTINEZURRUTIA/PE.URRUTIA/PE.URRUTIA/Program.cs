using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.URRUTIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int salida;
            do
            {
                Console.Clear();
                Console.WriteLine("Examen práctico: 1ra Unidad.");
                Console.WriteLine("Alumno: Jesús Martínez Urrutia.");
                Console.WriteLine("No. de control: 17211536");
                Console.WriteLine();
                Console.WriteLine("No. de actividades: ");
                for (int n = 1; n < 9; n++)
                {
                    Console.WriteLine("Actividad " + n + ".");
                }
                Console.WriteLine("No. de actividad que desea visualizar?: ");
                int actividad = int.Parse(Console.ReadLine());
                switch (actividad)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1.- Escriba un algoritmo cuya salida sea el valor menor y mayor en la sucesión S1, . . . , Sn.");
                        int valor1;
                        Console.WriteLine("Cuántos valores desea ingresar?");
                        valor1 = int.Parse(Console.ReadLine());
                        int[] valores = new int[valor1];
                        for (int n1 = 0; n1 < valor1; n1++)
                        {
                            Console.WriteLine("Favor de ingresar el valor número " + n1 + 1);
                            valores[n1] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("El menor valor es: " + valores.Min());
                        Console.WriteLine("El mayor valor es: " + valores.Max());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2.- Escriba un algoritmo que invierta la sucesión s1, . . . , sn.");
                        int valor2, n2;
                        Console.WriteLine("Cuántos valores desea ingresar?");
                        valor2 = int.Parse(Console.ReadLine());
                        string[] valores2 = new string[valor2];
                        for (n2 = 0; n2 < valor2; n2++)
                        {
                            Console.WriteLine("Favor de ingresar nombre en el número " + (n2 + 1) + ".- ");
                            valores2[n2] = Console.ReadLine();
                        }
                        Console.WriteLine("El orden inverso es: ");
                        for (int i = valor2 - 1; i > -1; i--)
                        {
                            Console.WriteLine(valores2[i]);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3.- Escriba un algoritmo que regrese el índice de la última ocurrencia del elemento más grande en la sucesión s1, . . . , sn.");
                        int valor3, max3 = 0, pos3 = 0;
                        Console.WriteLine("Cuántos valores desea ingresar?");
                        valor3 = int.Parse(Console.ReadLine());
                        int[] valores3 = new int[valor3];
                        for (int n3 = 0; n3 < valor3; n3++)
                        {
                            Console.WriteLine("Favor de ingresar valor en el número " + (n3 + 1) + ".- ");
                            valores3[n3] = int.Parse(Console.ReadLine());
                            if (valores3[n3] >= max3)
                            {
                                max3 = valores3[n3];
                                pos3 = (n3 + 1);
                            }
                        }
                        Console.WriteLine("El mayor valor es: " + max3);
                        Console.WriteLine("Se encuentra en la posición " + pos3);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4.- Escriba un algoritmo que encuentre el elemento menor entre a, b y c.");
                        int a, b, c;
                        Console.WriteLine("Escriba un valor para la letra a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba un valor para la letra b");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba un valor para la letra c");
                        c = int.Parse(Console.ReadLine());
                        if (a < b && b > c)
                        {
                            Console.WriteLine("El menor valor es " + a);
                        }
                        else if (b < a && b < c)
                        {
                            Console.WriteLine("El menor valor es " + b);
                        }
                        else if (c < a && c < b)
                        {
                            Console.WriteLine("El menor valor es " + c);
                        }
                        else if (a == b && b == c && c == a)
                        {
                            Console.WriteLine("Hay dos o más valores iguales");
                        }
                        else
                        {
                            Console.WriteLine("No hay elementos");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5.- Escriba un algoritmo que regrese el índice de la primera ocurrencia del elemento más grande en la sucesión s, . . . , sn.");
                        int valor5, Min5 = 1000000000, pos5 = 0;
                        Console.WriteLine("Cuántos valores desea ingresar?");
                        valor5 = int.Parse(Console.ReadLine());
                        int[] valores5 = new int[valor5];
                        for (int n5 = 0; n5 < valor5; n5++)
                        {
                            Console.WriteLine("Favor de ingresar nombre en el número " + (n5 + 1) + ".- ");
                            valores5[n5] = int.Parse(Console.ReadLine());
                            if (valores5[n5] < Min5)
                            {
                                Min5 = valores5[n5];
                                pos5 = (n5 + 1);
                            }
                        }
                        Console.WriteLine("El menor valor es: " + Min5);
                        Console.WriteLine("Se encuentra en la posición: " + pos5);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6.- Escriba un algoritmo que regrese el índice del primer elemento que es mayor que su predecesor en la sucesión s1, . . . , sn.");
                        Console.WriteLine("Cuántos nombres desea ingresar?");
                        int  valor6 = int.Parse(Console.ReadLine());
                        string[] valores6 = new string[valor6];
                        for (int n6 = 0; n6 < valor6; n6++)
                        {
                            Console.WriteLine("Favor de ingresar nombre en el número " + (n6+1) + ".- ");
                            valores6[n6] = Console.ReadLine();
                        }
                        for (int ind = 0; ind < valor6; ind++)
                        {
                            if (ind >= 1)
                            {
                                if (valores6[ind].Length > valores6[ind - 1].Length)
                                {
                                    Console.WriteLine("El primer valor mayor es: " + (ind+1));
                                    ind = valores6.Length;
                                }
                            }
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("7.- De una lista de números random del 1 al 100 ordénelos en orden no decreciente. Mostrando los números random y los números ya ordenados.");
                        Random rnd = new Random();
                        int n77 = 1;
                        Console.WriteLine("Cuántos valores desea que aparezcan?");
                        int valor7 = int.Parse(Console.ReadLine());
                        int[] valores7 = new int[valor7];
                        for (int n7 = 0; n7 < valor7; n7++)
                        {
                            valores7[n7] = rnd.Next(1, 100);
                            Console.WriteLine((n7 + 1) + ".- " + valores7[n7]);
                        }
                        Array.Sort(valores7);
                        Console.WriteLine("Organizando valores en orden no decreciente: ");
                        foreach (int k in valores7)
                        {
                            Console.WriteLine(n77 + ".- " + k);
                            n77++;
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("8.- Un palíndromo es una secuencia de caracteres que se lee igual de derecho y al reves.");
                        int[] palindromo = new int[5];
                        Random RND8 = new Random();
                        for (int n8 = 0; n8 <palindromo.Length; n8++)
                        {
                            palindromo[n8] = RND8.Next(0, 9);
                            Console.Write(palindromo[n8]);
                        }

                        if (palindromo[0]== palindromo[4] && palindromo[1] == palindromo[3] )
                        {
                            Console.WriteLine("\n Es un palindromo");
                        }
                        else
                        {
                            Console.WriteLine("\n No es un palindromo");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("Desea ingresar a otra actividad? Presione 1");
                Console.WriteLine("Desea salir del programa? Ingrese un valor diferente de 1");
                salida = int.Parse(Console.ReadLine());
            } while (salida == 1);
            Console.WriteLine("Gracias por utilizar el programa.");
            Console.ReadKey();
        }
    }
}

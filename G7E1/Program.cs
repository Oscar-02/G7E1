using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G7E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(120, 30);
            Console.Title = "Multioperador";

            char key = '\0';
            bool keyValid = false;
            while(keyValid == false)
            {
                Menu();
                Console.WriteLine("Presiona la tecla con la opcion que necesitas...");
                key = Console.ReadKey().KeyChar;
                if (key == '\0')
                {
                    Console.WriteLine("No has seleccionado ninguna opcion. Vuelvelo a intentar...");
                    keyValid = false;
                }
                if (key != '\0')
                {
                    keyValid = true;
                    switch (key)
                    {
                        case '1':
                            case1();
                            break;
                        case '2':
                            case2();
                            break;
                        case '3':
                            case3();
                            break;
                        case '4':
                            case4();
                            break;
                        case '5':
                            case5();
                            break;
                        case '6':
                            case6();
                            break;
                        case '0':
                            Console.WriteLine("\nLamentamos mucho que te vayas...");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Has presionado una tecla invalida...");
                            Console.WriteLine("Vuelvelo a intentar...");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            keyValid = false;
                            key = '\0';
                            break;
                    }
                }
            }


            void Menu()
            {
                int width = Console.WindowWidth;
                int i = 0;
                Console.Clear();
                do
                {
                    Console.Write('*');
                    i++;
                }
                while (i < width);
                i = 0;

                Console.Write('*');
                Console.SetCursorPosition((width - "MULTIOPERADOR".Length - 2) / 2 , 1);
                Console.WriteLine("MULTIOPERADOR");
                Console.SetCursorPosition(119, 1);
                Console.Write('*');

                do
                {
                    Console.Write('*');
                    i++;
                }
                while (i < width);
                i = 0;

                string str1 = "[1]Seno de x           [2]Coseno de x       [3]Tangente de x";
                string str2 = "[4]Raiz cuadrada de x  [5]X elevado a Y     [6]Par o Impar  ";
                string str3 = "[0]SALIR DEL PROGRAMA";
                int o = 3;
                Console.Write("**");
                Console.SetCursorPosition((width - str1.Length - 4) / 2, o);
                Console.WriteLine(str1);
                Console.SetCursorPosition(118, o);
                Console.Write("**");
                o++;
                Console.Write("**");
                Console.SetCursorPosition((width - str2.Length - 4) / 2, o);
                Console.WriteLine(str2);
                Console.SetCursorPosition(118, o);
                Console.Write("**");
                o++;
                Console.Write("**");
                Console.SetCursorPosition((width - str3.Length - 4) / 2, o);
                Console.WriteLine(str3);
                Console.SetCursorPosition(118, o);
                Console.Write("**");
                o++;

                do
                {
                    Console.Write('*');
                    i++;
                }
                while (i < width);
                Console.WriteLine();
            }

            void case1()
            {
                double x = 0;
                double res1;
                bool error = true;

                while(error == true)
                {
                    Console.Clear();
                    Menu();
                    try
                    {
                        Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                        x = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                        Console.WriteLine("Presione una tecla para volverlo a intentar...");
                        Console.ReadKey();
                        error = true;
                    }
                }
                //DENTRO DEL OPERADOR SE CONVIERTE DE GRADOS A RADIANES
                res1 = Math.Sin(Math.PI * x / 180.0);
                Console.WriteLine("El seno de " + x + " es " + Math.Round(res1, 5));
                Console.WriteLine("Presione una tecla para volver al inicio...");
                Console.ReadKey();
                key = '\0';
                keyValid = false;
            }

            void case2()
            {
                double x = 0;
                double res1;
                bool error = true;

                while (error == true)
                {
                    Console.Clear();
                    Menu();
                    try
                    {
                        Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                        x = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                        Console.WriteLine("Presione una tecla para volverlo a intentar...");
                        Console.ReadKey();
                        error = true;
                    }
                }
                //DENTRO DEL OPERADOR SE CONVIERTE DE GRADOS A RADIANES
                res1 = Math.Cos(Math.PI * x / 180.0);
                Console.WriteLine("El coseno de " + x + " es " + Math.Round(res1, 5));
                Console.WriteLine("Presione una tecla para volver al inicio...");
                Console.ReadKey();
                key = '\0';
                keyValid = false;
            }

            void case3()
            {
                double x = 0;
                double res1;
                bool error = true;

                while (error == true)
                {
                    Console.Clear();
                    Menu();
                    try
                    {
                        Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                        x = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                        Console.WriteLine("Presione una tecla para volverlo a intentar...");
                        Console.ReadKey();
                        error = true;
                    }
                }
                //DENTRO DEL OPERADOR SE CONVIERTE DE GRADOS A RADIANES
                res1 = Math.Tan(Math.PI * x / 180.0);
                Console.WriteLine("La tangente de " + x + " es " + Math.Round(res1, 5));
                Console.WriteLine("Presione una tecla para volver al inicio...");
                Console.ReadKey();
                key = '\0';
                keyValid = false;
            }

            void case4()
            {
                double x = 0;
                double res1;
                bool error = true;

                while (error == true)
                {
                    Console.Clear();
                    Menu();
                    try
                    {
                        Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                        x = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                        Console.WriteLine("Presione una tecla para volverlo a intentar...");
                        Console.ReadKey();
                        error = true;
                    }
                }
                res1 = Math.Sqrt(x);
                Console.WriteLine("La raiz cuadrada de " + x + " es " + Math.Round(res1, 5));
                Console.WriteLine("Presione una tecla para volver al inicio...");
                Console.ReadKey();
                key = '\0';
                keyValid = false;
            }

            void case5()
            {
                double x = 0, y = 0;
                double res1;
                bool error = true;

                while (error == true)
                {
                    Console.Clear();
                    Menu();
                    try
                    {
                        Console.WriteLine("Ingrese un numero para darle valor a 'x' (base)...");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero para darle valor a 'y' (potencia)...");
                        y = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                        Console.WriteLine("Presione una tecla para volverlo a intentar...");
                        Console.ReadKey();
                        error = true;
                    }
                }
                res1 = Math.Pow(x, y);
                Console.WriteLine(x + " elevado a " + y + " es " + Math.Round(res1, 5));
                Console.WriteLine("Presione una tecla para volver al inicio...");
                Console.ReadKey();
                key = '\0';
                keyValid = false;
            }

            void case6()
            {
                double x = 0;
                double res1;
                bool error = true;

                while (error == true)
                {
                    Console.Clear();
                    Menu();
                    try
                    {
                        Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                        x = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                        Console.WriteLine("Presione una tecla para volverlo a intentar...");
                        Console.ReadKey();
                        error = true;
                    }
                    res1 = x % 2;
                    if (res1 == 0)
                    {
                        Console.WriteLine(x + " es un numero par");
                    }
                    else if (res1 != 0)
                    {
                        Console.WriteLine(x + " es un numero impar");
                    }
                    Console.WriteLine("Presione una tecla para volver al inicio...");
                    Console.ReadKey();
                    key = '\0';
                    keyValid = false;
                }
            }
        }
    }
}

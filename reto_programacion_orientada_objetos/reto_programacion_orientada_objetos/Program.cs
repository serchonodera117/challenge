using System;

namespace reto_programacion_orientada_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            string inputNumber;
            int inputHeight, inputWidth;
            do
            {
                Console.Clear();
                Console.Write("Prueba de programación orientada a objetos\n " +
                   "opciones: " +
                   "\n1.-Escribir numero tamaño default (3 ancho y 3 de alto)." +
                   "\n2.-Escribir número de dimensiones personalizadas." +
                   "\nS.-Salir" +
                   "\n\n Escriba el número de la opción elegida : ");
                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Ha seleccionado escribir un numero de tamaño default (3x2). \n\nEscriba el número: ");
                        inputNumber = Console.ReadLine();
                          Console.WriteLine($"Numero [{inputNumber}] ingresado");

                        Number myNumero = new Number(inputNumber);
                        myNumero.SetNumber(inputNumber);
                        myNumero.Imprimir();
                        break;
                    case '2':
                        Console.Clear();
                        try
                        {
                            Console.Write("Ha seleccionado Escribir numero de dimensiones personalizadas. \n\nEscriba el tamaño del ancho: ");
                            inputWidth = int.Parse(Console.ReadLine());
                            Console.Write("Escriba el tamaño de la altura: ");
                            inputHeight = int.Parse(Console.ReadLine());
                            Console.Write("Escriba el número:");
                            inputNumber = Console.ReadLine();

                            if (inputHeight > 2 && inputWidth > 2)
                            {
                                Number numero2 = new Number(inputWidth, inputHeight, inputNumber);
                                numero2.SetNumber(inputNumber);
                                numero2.Imprimir();
                            }
                            else { Console.Write("No se aceptan dimensiones menores a 3"); }
                        }catch(Exception e) 
                        { 
                            Console.WriteLine($"Error {e.Message}");
                        }
                        break;
                   
                    case 'S':
                        opcion = 's';
                        int efe = 3 / 2;
                        Console.Write("\nHa seleccionado salir, buen día "+efe);
                        break;
                    case 's':
                        Console.Write("\nHa seleccionado salir, buen día");
                        break;
                    default:
                        Console.WriteLine($"\n\nOpción {opcion} no valida");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 's');
        }
    }
}

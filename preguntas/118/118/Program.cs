using System;

namespace _118
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double maximum;

            // finding the maximum between 3 values
            //maximum = Max(8.5, 9.3, 2.9); // maximum = 9.3

            // finding the maximum between 5 values
            //maximum = Max(0.3, 2.33, 12.91, 8.93, 7.55); // maximum = 12.91

            // finding the maximum between 3 values
            double[] arguments = { 2.8, 3.6, 1.7, 0.9, 4.45, 7.32, 2.83 };
            maximum = Max(arguments); // maximum = 7.32
            Console.WriteLine("Max number is: " + maximum);
        }

    // method that finds the maximum value between the parameter list
        public static double Max(double[] arguments)
        {
            if (arguments.Length == 0)
            {
                Console.WriteLine("Error: no arguments in method call");
                return 0;
            }

            double max = 0;
            for (int i = 0; i < arguments.Length; i++)
                if (max < arguments[i])
                    max = arguments[i];

            return max;
        }
    }
}

/*
La sobrecarga de métodos significa crear dos o más métodos en el mismo tipo que difieren solo en el número o
tipo de parámetros pero tienen el mismo nombre.
La sobrecarga es una de las técnicas más importantes para mejorar la usabilidad, la productividad y la legibilidad de
bibliotecas reutilizables. La sobrecarga en el número de parámetros hace posible proporcionar versiones más simples de
constructores y métodos. La sobrecarga en el tipo de parámetro permite utilizar el mismo miembro
nombre para miembros que realizan operaciones idénticas en un conjunto seleccionado de diferentes tipos.
*/
using System;
using System.IO;
using System.Reflection;

namespace Ejer_CSharp_No_109
{

    // Este programa usa el metodo File.ReadAllBytes para luego cargar un assembly    class Program
    public class Ejer_109
    {
        
        static void Main()
        {
            string filePath = @"C:\20483C\Tareas\EjerExamCSharp\mios\carlos\Ejer-CSharp-No-109\Dll-folder\Ejer-CSharp-No-41.dll";
            ViewMetaData(filePath);
        }
        public static void ViewMetaData(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);

            Console.WriteLine("\n\n      *****************************************");
            Console.WriteLine("      LISTA DE TODAS LAS OPCIONES DEL EJERCICIO");
            Console.WriteLine("      *****************************************\n");

            try
            {
                Console.WriteLine("      Opción A. Assembly.ReflectionOnlyLoadFrom(bytes);\n");
                Assembly assem = null; //Assembly.ReflectionOnlyLoadFrom(bytes);
                if (assem == null)
                {
                    Console.WriteLine("      El assembly es nulo...");
                    Console.WriteLine("      Este método toma com parametro una string y no byte[]");
                    Console.WriteLine("      El error mostrado es: ");
                    Console.WriteLine("      Argumento 1: no se puede convertir de 'byte[]' a 'string' [Ejer-CSharp-No-109]csharp(CS1503)");
                }
                else
                {
                    Console.WriteLine("      El Assembly no es nulo, mostrando sus metadatos:");
                    Console.WriteLine("      Los datos del Assambly son: " + assem.FullName);
                }   
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }

            try
            {
                Console.WriteLine("\n\n      Opción B. Assembly.ReflectionOnlyLoad(bytes);\n");
                Assembly assem = Assembly.ReflectionOnlyLoad(bytes);
                if (assem == null)
                    Console.WriteLine("      El assembly es nulo...");
                else
                {
                    Console.WriteLine("      El Assembly no es nulo, mostrando sus metadatos:");
                    Console.WriteLine("      Los datos del Assambly son: " + assem.FullName);
                }
            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine("      El Assembly no es nulo, pero no muestra nada porque no usado correctamente");
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }

            try
            {
                Console.WriteLine("\n\n      Opción C. Assembly.Load(bytes);\n");
                Assembly assem = Assembly.Load(bytes);
                if (assem == null)
                    Console.WriteLine("      El assembly es nulo...");
                else
                {
                    Console.WriteLine("      El Assembly no es nulo, mostrando sus metadatos:");
                    Console.WriteLine("      Los datos del Assambly son: " + assem.FullName);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }

            try
            {
                Console.WriteLine("\n\n      Opción D. Assembly.LoadFrom(bytes);\n");
                Assembly assem = null; //Assembly.LoadFrom(bytes);
                if (assem == null)
                {
                    Console.WriteLine("      El assembly es nulo...");
                    Console.WriteLine("      Este método toma com parametro una string y no byte[]");
                    Console.WriteLine("      El error mostrado es: ");
                    Console.WriteLine("      Argumento 1: no se puede convertir de 'byte[]' a 'string' [Ejer-CSharp-No-109]csharp(CS1503)");
                }
                else
                {
                    Console.WriteLine("      El Assembly no es nulo, mostrando sus metadatos:");
                    Console.WriteLine("      Los datos del Assambly son: " + assem.FullName);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }
        }
    }
}

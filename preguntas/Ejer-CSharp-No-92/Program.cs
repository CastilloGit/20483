using System;
using System.Reflection;

namespace Ejer_CSharp_No_92
{
    class Program
    {   // Marcar la propiedad PropiedadVieja como obsoleta.
        [ObsoleteAttribute("Esta propiedad esta obsoleta. Usa mejor la nueva propiedad.", false)]
        public static string PropiedadVieja
        { get { return "El valor de la propiedad vieja."; } }

        public static string PropiedadNueva
        { get { return "El valor de la propiedad nueva."; } }

        // Marcar que el el metodo LlamarMetodoViejo está Obsoleto.
        [ObsoleteAttribute("Este método está obsoleto. Ejecutar mejor el  LlamarMetodoNuevo instead.", true)]
        public static string LlamarMetodoViejo()
        {
            return "Usted ha llamado al método LlamarMetodoViejo.";
        }

        public static string LlamarMetodoNuevo()
        {
            return "You have called LlamarMetodoNuevo.";
        }

        public static void Main()
        {
            Console.WriteLine(PropiedadVieja);
            Console.WriteLine();
            Console.WriteLine(LlamarMetodoViejo());
        }
    }
}
//  Al querer compilar este ejemplo se produce lo siguiente:
//  Example.cs(31,25): error CS0619: 'Example.LlamarMetodoViejo()' is obsolete:
//  'This method is obsolete. Call LlamarMetodoNuevo instead.'
//  Example.cs(29,25): warning CS0618: 'Example.PropiedadVieja' is obsolete:
//   

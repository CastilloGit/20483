using System;
using System.Collections.Generic;
using System.Linq;


namespace Ejer_CSharp_No_75
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] custArray = new Customer[7];
            int[] customerIds = new int[7];
            // Primer Customer
            custArray[0] = new Customer() {customerId = 1, FirstName = "Joe", LastName = "Smith" };

            // Segundo Customer
            custArray[1] = new Customer() {customerId = 2, FirstName = "Jose", LastName = "Hurtado"};

            // Otros Customers
            custArray[2] = new Customer() {customerId = 2, FirstName = "Juan", LastName = "García"};
            custArray[3] = new Customer() {customerId = 4, FirstName = "Pedro", LastName = "Martinez"};
            custArray[4] = new Customer() {customerId = 5, FirstName = "Ana", LastName = "Gomez"};
            custArray[5] = new Customer() {customerId = 5, FirstName = "Eva", LastName = "Peralta"};
            custArray[6] = new Customer() {customerId = 4, FirstName = "Lucia", LastName = "Oses"};

            for(int i = 0; i < custArray.Length; i++)
            {
                Customer curCust = custArray[i];
                int id = curCust.customerId;
                customerIds[i] = id;

            }
            Console.WriteLine("\n\n      *****************************************");
            Console.WriteLine("      LISTA DE TODOS LOS CUSTOMER EN EL ARRAY !");
            Console.WriteLine("      *****************************************\n\n");
            foreach (Customer c in custArray){
                Console.WriteLine($"      El Customer {c.FirstName} {c.LastName} tiene un ID: {c.customerId}");
            }

            // Customer Id a eliminar = custormerIdToRemove
            int custormerIdToRemove = 5;
            int[] filteredCustomerIds;
            
            Console.WriteLine("\n\n      *****************************************");
            Console.WriteLine("      LISTA DE TODAS LAS OPCIONES DEL EJERCICIO");
            Console.WriteLine("      *****************************************\n");


            try
            {
                Console.WriteLine("      Opción A. int[] filteredCustomerIds = customerIds.Distinct().OrderByDescending(x => x).ToArray();\n");
                filteredCustomerIds = customerIds.Distinct().OrderByDescending(x => x).ToArray();
                foreach (int num in filteredCustomerIds){
                Console.WriteLine($"      El Customer con ID: {num} se llama {custArray[num].FirstName} {custArray[num].LastName}.");
                }
                Console.WriteLine("      Esta Opcion cumple todas las condiciones exigidas !!");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }

            try
            {
                Console.WriteLine("\n\n      ");
                Console.WriteLine("      Opción B. int[] filteredCustomerIds = customerIds.Where(value => value != customerIdToRemove).OrderByDescending(x => x).ToArray();\n");
                filteredCustomerIds = customerIds.Where(value => value != custormerIdToRemove).OrderByDescending(x => x).ToArray();
                foreach (int num in filteredCustomerIds){
                Console.WriteLine($"      El Customer con ID: {num} se llama {custArray[num].FirstName} {custArray[num].LastName}.");
                }
                Console.WriteLine("      Esta Opcion no cumple la condición de valores distintos en el ID !!");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }

            try
            {
                Console.WriteLine("\n\n      ");
                Console.WriteLine("      Opción C. int[] filteredCustomerIds = customerIds.Distinct().Where(value => value != customerIdToRemove).OrderByDescending(x => x).ToArray();\n");
                filteredCustomerIds = customerIds.Distinct().Where(value => value != custormerIdToRemove).OrderByDescending(x => x).ToArray();
                foreach (int num in filteredCustomerIds){
                Console.WriteLine($"      El Customer con ID: {num} se llama {custArray[num].FirstName} {custArray[num].LastName}.");
                }
                Console.WriteLine("      Esta Opcion es la opción correcta dada en la respuesta, pero no muestra el último ID !!");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }

            try
            {
                Console.WriteLine("\n\n      ");
                Console.WriteLine("      Opción D. int[] filteredCustomerIds = customerIds.Where(value => value != customerIdToRemove).OrderBy(x => x).ToArray();\n");
                filteredCustomerIds = customerIds.Where(value => value != custormerIdToRemove).OrderBy(x => x).ToArray();
                foreach (int num in filteredCustomerIds){
                Console.WriteLine($"      El Customer con ID: {num} se llama {custArray[num].FirstName} {custArray[num].LastName}.");
                }
                Console.WriteLine("      Esta Opcion no cumple la condición de valores distintos en el ID !!");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("      El error mostrado en esta opción es: ", ex.Message);
            }

        }
        public class Customer
        {
            public Customer(){}
            public int customerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public List<Customer> _customers
            {
                get{return _customers;}
                set{_customers = value;}
            }
        }

    }
}

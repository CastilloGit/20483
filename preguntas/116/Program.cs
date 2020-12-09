using System;

namespace _116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class Customer
        {
            private int CustomerId { get; set; }
            public string CompanyName { get; set; }

            protected string State { get; set; }
            public string City { get; set; }

            public Customer(int customerId, string companyName, string state, string city)
            {

                CustomerId = customerId;

                CompanyName = companyName;

                State = state;

                City = city;

            }

            public Customer() { }
        }
        public interface ICustomer
        {
            string GetCustomerById(int customeria);

            string GetCustomerByDate(DateTime dateFrom, DateTime dateTo);
        }

        public class MyCustomerClass : Customer, ICustomer
        {
            public string Zip { get; set; }
            public string Phone { get; set; }
            public string GetCustomerById(int customerId)
            {
                //...
            }

            public string GetCustomerByDate(DateTime dateFrom, DateTime dateTo)
            {
                //...
            }

        }
    }
}

/*For each of the following statements, select Yes if the statement is true. Otherwise, select No

All of the objects derived from MyCustomerClass have CustomerID as a property. Answer: No
All of the objects derived from MyCustomerClass have CompanyName as a property. Answer: Yes
All of the objects derived from MyCustomerClass have State as a property. Answer: Yes

Explanation: CustomerID is declared private.
CompanyName is declted protected.
State is declared protected.

The protected keyword is a member access modifier. A protected member is accessible from within the class in
which it is declared, and from within any class derived from the class that declared this member.

*/



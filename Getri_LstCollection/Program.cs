using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getri_LstCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> lstCustomers = new List<Customer>();
            lstCustomers.Add(new Customer { CustID = 1, CustName = "John", CustCountry = "USA", CustAge = 30 });    
            lstCustomers.Add(new Customer { CustID = 2, CustName = "Smith", CustCountry = "UK", CustAge = 40 });
            lstCustomers.Add(new Customer { CustID = 3, CustName = "Williams", CustCountry = "Germany", CustAge = 25 });

            foreach (Customer c in lstCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Country = {2}, Age = {3}", c.CustID, c.CustName, c.CustCountry, c.CustAge);
            }

            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int CustID { get; set; }

        public string CustName { get; set; }

        public string CustCountry { get; set; }

        public int CustAge { get; set; }
    }
}

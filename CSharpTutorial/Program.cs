using System;
using System.Collections.Generic; // to list of items
using System.Runtime.Serialization;
using System.Reflection;
using System.Data;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO; // to read or write files

namespace CSharpTutorial
{


    public class Program

    {


        public static void Main()

        {
            
            Customer c1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer c2 = new Customer()
            {
                Id = 110,
                Name = "Pam",
                Salary = 7000
            };
            Customer c3 = new Customer()
            {
                Id = 119,
                Name = "John",
                Salary = 5500
            };
            // I added the new customer reference obj

            Customer c4 = new Customer()
            {
                Id = 119,
                Name = "John",
                Salary = 5500
            };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

         int index =  customers.FindIndex( cust => cust.Salary > 5000);
            Console.WriteLine("index = " + index);
            Console.ReadLine();




















        }




        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }

       



    }


    }




    


   


   
    


   


    














        
    





    



    




        
    
    
    


   


        
    


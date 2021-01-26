using System;

namespace HomeworkClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Name = "Arife";
            customer1.Surname = "Altunyurt";
            customer1.Id = 21021972;
            customer1.TelNumber = 0589456124;

            Customer customer2 = new Customer();
            customer2.Name = "Emine";
            customer2.Surname = "Dönmezer";
            customer2.Id = 15091932;
            customer2.TelNumber = 0500456123;

            Customer customer3 = new Customer();
            customer3.Name = "Anıl";
            customer3.Surname = "Altunyurt";
            customer3.Id = 09091997;
            customer3.TelNumber = 0501794521;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.TelNumber);

            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Info(customer3);
            customerManager.List(customers);


            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi :" + customer.Name + " " + customer.Surname);
        
        }


        public void Info(Customer customer)
        {


        

            Console.WriteLine("Müşteri Bilgileri : " +"Müşteri Adı:" +customer.Name + " " + "Müşteri Soyadı:" + customer.Surname + " " + "Id:" +customer.Id + " " + "Telefon:" + customer.TelNumber);
        }
        
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.Name + " " + customer.Surname);
        }
        
    }
}

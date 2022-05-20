using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucsCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1998, 12, 12), FirstName = "Mahmut Can", LastName = "Alp", NationalityId = "39763298928" });
            Console.ReadLine();
        }
    }
}
 
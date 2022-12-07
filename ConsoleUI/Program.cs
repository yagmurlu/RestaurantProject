using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
            foreach (var item in restaurantManager.GetAll())
            {
                Console.WriteLine(item.RestaurantName);
            }
           
        }
    }
}

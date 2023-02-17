using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            RestaurantTest();


            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void RestaurantTest()
        {
            RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
            foreach (var item in restaurantManager.GetAll())
            {
                Console.WriteLine(item.RestaurantName);
            }
        }
    }
}

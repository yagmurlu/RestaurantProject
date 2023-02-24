using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RestaurantCRUDtest();
            //ProductTest();
            //RestaurantTest();
            //CategoryTest();
        }

        private static void RestaurantCRUDtest()
        {
            RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
            restaurantManager.Add(new Restaurant { RestaurantName = "Lokmacı", Address = "Kağıthane", Description = "7/24", PhoneNumber = 025565 });
            restaurantManager.Update(new Restaurant
            {
                RestaurantId = 3,
                RestaurantName = "LOKUMCUM",
                Address = "Kağıthane",
                Description = "7/24",
                PhoneNumber = 025565
            });
            restaurantManager.Delete(new Restaurant { RestaurantId = 4 });
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + " / " + item.CategoryName);
            }
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

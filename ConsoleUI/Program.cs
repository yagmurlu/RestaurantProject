using Business.Concrete;
using Business.Constants;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RestaurantCRUDtest();   // => OK
            //ProductTest();          // => OK
            
            //RestaurantTest();       // => OK
            //CategoryTest();         // => OK
            //UserTest();             //=>OK
           
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new Users
            //{
            //    FirstName = "Aleyna",
            //    LastName = "TÜRK",
            //    Email = "aleyna@gmail.com",
            //    Password = "123"
            //});

            //var result = userManager.GetAll();
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        private static void RestaurantCRUDtest()
        {
            RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
            //restaurantManager.Add(new Restaurant { RestaurantName = "Lokmacı", Address = "Kağıthane", Description = "7/24", PhoneNumber = 025565 });
            //restaurantManager.Update(new Restaurant
            //{
            //    RestaurantId = 3,
            //    RestaurantName = "LOKUMCUM",
            //    Address = "Kağıthane",
            //    Description = "7/24",
            //    PhoneNumber = 025565
            //});
            //restaurantManager.Delete(new Restaurant { RestaurantId = 4 });
            foreach (var item in restaurantManager.GetAll().Data)
            {
                Console.WriteLine(item.RestaurantName);
            }
            var result = restaurantManager.GetById(3);
            Console.WriteLine(result.Data.RestaurantName);
           
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.IsSuccess == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //foreach (var item in productManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            //var result= productManager.GetById(1);
            //Console.WriteLine(result.Data.ProductName);
        }
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var result = categoryManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void RestaurantTest()
        {
            RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
            //foreach (var item in restaurantManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.RestaurantName);
            //}
            var result = restaurantManager.GetRestaurantDetails();
            if (result.IsSuccess == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("Rest Ad:"+item.RestaurantName+"Kategori Adı:"+item.CategoryName+"Ürün Adı: "+ item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}

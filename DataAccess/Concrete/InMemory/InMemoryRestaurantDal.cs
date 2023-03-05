using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryRestaurantDal : IRestaurantDal
    {
        List<Restaurant> _restaurants;
        public InMemoryRestaurantDal()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    RestaurantId=1,
                    RestaurantName="HacıBaba",
                    Description="Ankara' da bulunan bir restaurant zinciri",
                    Address="ANKARA",
                    PhoneNumber=111111
                },
                new Restaurant
                {
                    RestaurantId=2,
                    RestaurantName="Köfteci Yusuf",
                    Description="Türkiye' da bulunan bir restaurant zinciri",
                    Address="ANKARA,BURSA,İSTANBUL",
                    PhoneNumber=222222
                },
                new Restaurant
                {
                    RestaurantId=3,
                    RestaurantName="ASPAVA",
                    Description="ANKARA' da bulunan bir restaurant zinciri",
                    Address="ANKARA",
                    PhoneNumber=333333
                }
            };
        }
        public void Add(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Delete(Restaurant restaurant)
        {
            Restaurant restaurantToDelete = _restaurants.SingleOrDefault(x => x.RestaurantId == restaurant.RestaurantId);
            _restaurants.Remove(restaurantToDelete);
        }

        public Restaurant Get(Expression<Func<Restaurant, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public List<Restaurant> GetAll(Expression<Func<Restaurant, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant>GetAllByCategory(int id)
        {
            return _restaurants.Where(x => x.RestaurantId == id).ToList();
        }

        public List<RestaurantDetailDto> GetRestaurantDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant restaurant)
        {
            Restaurant restaurantToUpdate = _restaurants.SingleOrDefault(x => x.RestaurantId == restaurant.RestaurantId);
            restaurantToUpdate.RestaurantName = restaurant.RestaurantName;
            restaurantToUpdate.PhoneNumber = restaurant.PhoneNumber;
            restaurantToUpdate.Description = restaurant.Description;
            restaurantToUpdate.Address = restaurant.Address;
            
        }
    }
}

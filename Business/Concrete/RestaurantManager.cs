using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RestaurantManager : IRestaurantService
    {
        IRestaurantDal _restaurantDal;

        public RestaurantManager(IRestaurantDal restaurantDal)
        {
            _restaurantDal = restaurantDal;
        }

        public void Add(Restaurant restaurant)
        {
            _restaurantDal.Add(restaurant);
        }

        public void Delete(Restaurant restaurant)
        {
            _restaurantDal.Delete(restaurant);  
        }

        public List<Restaurant> GetAll()
        {
            return _restaurantDal.GetAll();
        }

        public void Update(Restaurant restaurant)
        {
            _restaurantDal.Update(restaurant);
        }
    }
}

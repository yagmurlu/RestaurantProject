using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public IResult Add(Restaurant restaurant)
        {
            _restaurantDal.Add(restaurant);
            return new SuccessResult();
        }

        public IResult Delete(Restaurant restaurant)
        {
            _restaurantDal.Delete(restaurant);
            return new SuccessResult();
        }

        public IDataResult<List<Restaurant>> GetAll()
        {
            _restaurantDal.GetAll();
            return new SuccessDataResult<List<Restaurant>>();
        }

        public IDataResult<Restaurant> GetById(int id)
        {
            _restaurantDal.Get(x => x.RestaurantId == id);
            return new SuccessDataResult<Restaurant>();
        }

        public IDataResult<List<RestaurantDetailDto>> GetRestaurantDetails()
        {
            _restaurantDal.GetRestaurantDetails();
            return new SuccessDataResult<List<RestaurantDetailDto>>();
        }

        public IResult Update(Restaurant restaurant)
        {
            _restaurantDal.Update(restaurant);
            return new SuccessResult();
        }
    }
}

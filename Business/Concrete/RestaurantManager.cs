using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
            
            return new SuccessDataResult<List<Restaurant>>(_restaurantDal.GetAll());
        }

        public IDataResult<Restaurant> GetById(int id)
        {
            
            return new SuccessDataResult<Restaurant>(_restaurantDal.Get(x => x.RestaurantId == id));
        }

        public IDataResult<List<RestaurantDetailDto>> GetRestaurantDetails()
        {
            //_restaurantDal.GetRestaurantDetails();
            //return new SuccessDataResult<List<RestaurantDetailDto>>();
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<RestaurantDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RestaurantDetailDto>>(_restaurantDal.GetRestaurantDetails());
        }

        public IResult Update(Restaurant restaurant)
        {
            _restaurantDal.Update(restaurant);
            return new SuccessResult();
        }
    }                                                                                                
}

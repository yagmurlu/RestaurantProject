using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRestaurantService
    {
        IResult Add(Restaurant restaurant);
        IResult Delete(Restaurant restaurant);
        IResult Update(Restaurant restaurant);
        IDataResult<List<Restaurant>> GetAll();
        IDataResult<Restaurant> GetById(int id);
        IDataResult<List<RestaurantDetailDto>> GetRestaurantDetails();
    }
}

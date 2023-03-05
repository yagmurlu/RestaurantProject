using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRestaurantDal : EfEntityRepositoryBase<Restaurant, RestaurantContext>, IRestaurantDal
    {
        public List<RestaurantDetailDto> GetRestaurantDetails()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var result = from r in context.Restaurants
                             join c in context.Categories       
                             
                             on r.RestaurantId equals c.RestaurantId
                             join p in context.Products
                             on c.CategoryId equals p.CategoryId
                             select new RestaurantDetailDto
                             {
                                 RestaurantId = r.RestaurantId,
                                 RestaurantName = r.RestaurantName,
                                 CategoryName=c.CategoryName,
                                 ProductName=p.ProductName,
                             };
                return result.ToList();
            }
        }
    }
}

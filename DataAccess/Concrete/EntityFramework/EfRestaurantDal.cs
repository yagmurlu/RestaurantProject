using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRestaurantDal : IRestaurantDal
    {
        public void Add(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public Restaurant Get(Expression<Func<Restaurant, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAll(Expression<Func<Restaurant, bool>> filter = null)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return filter == null ? context.Set<Restaurant>().ToList() : context.Set<Restaurant>().Where(filter).ToList();
            }
        }

        public void Update(Restaurant entity)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRestaurantService
    {
        List<Restaurant> GetAll();
        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(Restaurant restaurant);

    }
}
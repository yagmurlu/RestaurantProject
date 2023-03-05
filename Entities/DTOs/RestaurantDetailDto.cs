using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RestaurantDetailDto:IDto
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
    }
}

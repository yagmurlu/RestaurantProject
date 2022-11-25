using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Menu:IEntity
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
    }
}

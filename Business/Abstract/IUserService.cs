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
    public interface IUserService
    {
        IResult Add(Users user);
        IResult Delete(Users user);
        IResult Update(Users user);
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int id);
       
        
    }
}

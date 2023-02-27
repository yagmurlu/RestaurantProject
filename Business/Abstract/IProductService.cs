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
    public interface IProductService
    {
        IResult Add(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);    
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}

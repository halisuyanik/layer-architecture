﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IResult Update(Product product);
        IDataResult<Product> GetById(int productId);
        IResult TransactionalOperation(Product product);
    }
}

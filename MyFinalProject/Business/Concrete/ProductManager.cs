﻿using System;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ProductManager:IProductService
	{
        IProductDal _productDal;
        

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}


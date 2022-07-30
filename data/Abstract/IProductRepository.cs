using System;
using System.Collections.Generic;
using System.Text;
using entity;

namespace data.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int ProductId);
        List<Product> GetAll();

        void Create(Product entity);
        void Update(Product entity);
        void Delete(int id);
    }
}

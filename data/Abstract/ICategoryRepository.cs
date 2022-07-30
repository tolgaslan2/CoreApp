using System;
using System.Collections.Generic;
using System.Text;
using entity;

namespace data.Abstract
{
    interface ICategoryRepository
    {
        Category GetById(int ProductId);
        List<Category> GetAll();

        void Create(Category entity);
        void Update(Category entity);
        void Delete(int id);
    }
}

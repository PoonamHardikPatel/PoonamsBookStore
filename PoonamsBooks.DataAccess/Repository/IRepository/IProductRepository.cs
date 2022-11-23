using PoonamsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoonamsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}

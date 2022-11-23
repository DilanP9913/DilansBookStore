using System;
using DilansBooks.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilansBooks.DataAccess.Repository.IRepository
{

    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}



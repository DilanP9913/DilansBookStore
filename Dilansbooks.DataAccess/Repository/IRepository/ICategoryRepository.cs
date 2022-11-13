using DilansBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dilansbooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        void Update(Category category);
    }
}

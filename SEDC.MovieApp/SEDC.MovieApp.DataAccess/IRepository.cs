using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Create(T entity);
    }
}

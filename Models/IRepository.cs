using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public interface IRepository<T>
    {
        void Add(T entity);

        List<T> GetAll();
        T GetItemById(Guid id);

        void Delete(T entity);
        void Delete(Guid id);

        void SaveChanges();
    }
}
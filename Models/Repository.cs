using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Catalog.DataAccessLayer;

namespace Catalog.Models
{
    public class Repository<T>:IRepository<T> where T : class, IEntity
    {
        private RepositoryContext context;

        //private IDbSet<T> DbSet

        Repository()
        {
            context = new RepositoryContext();
        }    

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            SaveChanges();
        }

        public List<T> GetAll()
        {
           return context.Set<T>().ToList();
        }

        public T GetItemById(Guid id)
        {
            return context.Set<T>().Where(arg => arg.Id == id).SingleOrDefault();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            SaveChanges();
        }

        public void Delete(Guid id)
        {
            T entity = context.Set<T>().Where(arg => arg.Id == id).SingleOrDefault();
            context.Set<T>().Remove(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
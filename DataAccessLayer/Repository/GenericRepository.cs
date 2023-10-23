using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var context = new DentalDbContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new DentalDbContext();
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            using var context = new DentalDbContext();
            return context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var context = new DentalDbContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new DentalDbContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}

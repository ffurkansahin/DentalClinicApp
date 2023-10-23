using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class,new()
    {
        void Delete(T t);
        void Update(T t);
        void Insert(T t);
        T GetByID(int id);
        List<T> GetAll();

    }
}

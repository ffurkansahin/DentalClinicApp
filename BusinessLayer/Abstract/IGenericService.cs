using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        void Delete(T t);
        void Update(T t);
        void Insert(T t);
        T GetById(int id);
        List<T> GetListAll();
    }
}

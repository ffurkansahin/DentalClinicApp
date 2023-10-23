using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDAL userDAL;

        public UserManager(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public void Delete(User t)
        {
            userDAL.Delete(t);
        }

        public User GetById(int id)
        {
            return userDAL.GetByID(id);
        }

        public List<User> GetListAll()
        {
            return userDAL.GetAll();
        }

        public void Insert(User t)
        {
            userDAL.Insert(t);
        }

        public void Update(User t)
        {
            userDAL.Update(t);
        }
    }
}

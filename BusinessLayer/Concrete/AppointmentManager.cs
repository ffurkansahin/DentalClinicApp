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
    public class AppointmentManager : IAppointmentService
    {
        private readonly IAppointmentDAL iAppointmentDAL;

        public AppointmentManager(IAppointmentDAL? iAppointmentDAL)
        {
            this.iAppointmentDAL = iAppointmentDAL;
        }

        public void Delete(Appointment t)
        {
            iAppointmentDAL.Delete(t);
        }

        public Appointment GetById(int id)
        {
            return iAppointmentDAL.GetByID(id);
        }

        public List<Appointment> GetListAll()
        {
            return iAppointmentDAL.GetAll();
        }

        public void Insert(Appointment t)
        {
            iAppointmentDAL.Insert(t);
        }

        public void Update(Appointment t)
        {
            iAppointmentDAL.Update(t);
        }
    }
}

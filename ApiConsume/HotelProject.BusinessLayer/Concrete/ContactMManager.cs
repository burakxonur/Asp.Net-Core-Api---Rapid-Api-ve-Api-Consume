using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactMManager : IContacMService
    {
        private readonly IContactMDal _contactDal;
        public ContactMManager(IContactMDal contactMDal)
        {
            _contactDal = contactMDal;
        }

        public void TDelete(ContactM t)
        {
            throw new NotImplementedException();
        }

        public ContactM TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public int TGetContactCount()
        {
            return _contactDal.GetContactCount();
        }

        public List<ContactM> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(ContactM t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(ContactM t)
        {
            throw new NotImplementedException();
        }
    }
}

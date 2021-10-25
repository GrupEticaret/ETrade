using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BillManager : IBillService
    {
        IBillDal _billDal;

        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        public Bill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bill> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Bill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Bill t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Bill t)
        {
            throw new NotImplementedException();
        }
    }
}

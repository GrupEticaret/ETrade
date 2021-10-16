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

        public void AddBill(Bill bill)
        {
            throw new NotImplementedException();
        }

        public void DeleteBill(Bill bill)
        {
            throw new NotImplementedException();
        }

        public Bill GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bill> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateBill(Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}

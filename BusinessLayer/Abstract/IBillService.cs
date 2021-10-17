using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBillService
    {
        void AddBill(Bill bill);
        void DeleteBill(Bill bill);
        void UpdateBill(Bill bill);
        List<Bill> GetList();
        Bill GetByID(int id);
    }
}

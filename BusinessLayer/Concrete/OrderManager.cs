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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Order t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Order t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Order t)
        {
            throw new NotImplementedException();
        }
    }
}

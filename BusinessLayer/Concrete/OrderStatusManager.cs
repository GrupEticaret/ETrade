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
    public class OrderStatusManager : IOrderStatusService
    {
        IOrderStatusDal _orderStatusDal;

        public OrderStatusManager(IOrderStatusDal orderStatusDal)
        {
            _orderStatusDal = orderStatusDal;
        }

        public void AddOrderStatus(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderStatus(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }

        public OrderStatus GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderStatus> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderStatus(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}

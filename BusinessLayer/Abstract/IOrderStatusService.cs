using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderStatusService
    {
        void AddOrderStatus(OrderStatus orderStatus);
        void DeleteOrderStatus(OrderStatus orderStatus);
        void UpdateOrderStatus(OrderStatus orderStatus);
        List<OrderStatus> GetList();
        OrderStatus GetByID(int id);
    }
}

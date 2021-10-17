using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        void DeleteOrder(Order order);
        void UpdateOrder(Order order);
        List<Order> GetList();
        Order GetByID(int id);
    }
}

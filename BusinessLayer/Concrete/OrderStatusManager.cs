﻿using BusinessLayer.Abstract;
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

        public OrderStatus GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderStatus> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(OrderStatus t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(OrderStatus t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OrderStatus t)
        {
            throw new NotImplementedException();
        }
    }
}

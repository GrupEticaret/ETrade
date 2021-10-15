using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPaymentOptionsService
    {
        void AddPaymentOptions(PaymentOptions paymentOptions);
        void DeletePaymentOptions(PaymentOptions paymentOptions);
        void UpdatePaymentOptions(PaymentOptions paymentOptions);
        List<PaymentOptions> GetList();
        PaymentOptions GetByID(int id);
    }
}

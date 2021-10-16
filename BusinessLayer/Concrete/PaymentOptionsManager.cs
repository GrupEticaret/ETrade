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
    public class PaymentOptionsManager : IPaymentOptionsService
    {
        IPaymentOptionsDal _paymentOptionsDal;

        public PaymentOptionsManager(IPaymentOptionsDal paymentOptionsDal)
        {
            _paymentOptionsDal = paymentOptionsDal;
        }

        public void AddPaymentOptions(PaymentOptions paymentOptions)
        {
            throw new NotImplementedException();
        }

        public void DeletePaymentOptions(PaymentOptions paymentOptions)
        {
            throw new NotImplementedException();
        }

        public PaymentOptions GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentOptions> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdatePaymentOptions(PaymentOptions paymentOptions)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public PaymentOptions GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentOptions> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(PaymentOptions t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(PaymentOptions t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(PaymentOptions t)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public Country GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Country t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Country t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Country t)
        {
            throw new NotImplementedException();
        }
    }
}

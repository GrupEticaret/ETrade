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
    public class AddressDefinitionManager : IAddressDefinitionService
    {
        IAddressDefinitionDal _addressDefinitionDal;

        public AddressDefinitionManager(IAddressDefinitionDal addressDefinitionDal)
        {
            _addressDefinitionDal = addressDefinitionDal;
        }

        public AddressDefinition GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AddressDefinition> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(AddressDefinition t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AddressDefinition t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AddressDefinition t)
        {
            throw new NotImplementedException();
        }
    }
}

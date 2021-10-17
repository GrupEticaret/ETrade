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

        public void AddAddressDefinition(AddressDefinition addressDefinition)
        {
            throw new NotImplementedException();
        }

        public void DeleteAddressDefinition(AddressDefinition addressDefinition)
        {
            throw new NotImplementedException();
        }

        public AddressDefinition GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AddressDefinition> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateAddressDefinition(AddressDefinition addressDefinition)
        {
            throw new NotImplementedException();
        }
    }
}

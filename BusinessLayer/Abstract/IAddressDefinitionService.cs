using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAddressDefinitionService
    {
        void AddAddressDefinition(AddressDefinition addressDefinition);
        void DeleteAddressDefinition(AddressDefinition addressDefinition);
        void UpdateAddressDefinition(AddressDefinition addressDefinition);
        List<AddressDefinition> GetList();
        AddressDefinition GetByID(int id);
    }
}

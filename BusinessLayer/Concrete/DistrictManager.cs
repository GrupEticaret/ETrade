using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public EntityLayer.Concrete.District GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.District> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(EntityLayer.Concrete.District t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(EntityLayer.Concrete.District t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EntityLayer.Concrete.District t)
        {
            throw new NotImplementedException();
        }
    }
}

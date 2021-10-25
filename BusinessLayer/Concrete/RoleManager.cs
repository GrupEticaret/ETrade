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
    public class RoleManager : IRoleService
    {
        //deneme
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public Role GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Role t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Role t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Role t)
        {
            throw new NotImplementedException();
        }
    }
}

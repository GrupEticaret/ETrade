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
    public class CargoManager : ICargoService
    {
        ICargoDal _cargoDal;

        public CargoManager(ICargoDal cargoDal)
        {
            _cargoDal = cargoDal;
        }

        public void AddCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void DeleteCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Cargo GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cargo> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }
    }
}

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICargoService
    {
        void AddCargo(Cargo cargo);
        void DeleteCargo(Cargo cargo);
        void UpdateCargo(Cargo cargo);
        List<Cargo> GetList();
        Cargo GetByID(int id);
    }
}

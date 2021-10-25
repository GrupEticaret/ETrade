using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();

        DbSet<T> _object;


        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T p)
        {
            var deletedEntity = context.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

       

        public void Insert(T p)
        {
            var addedEntity = context.Entry(p);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T p)
        {
            var updatedEntity = context.Entry(p);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

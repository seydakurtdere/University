using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DATA.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private UniversityDBEntities _db;
        public Repository(UniversityDBEntities db)
        {
            _db = db;
        }

        public T Add(T obj)
        {
            _db.Set<T>().Add(obj);
            return obj;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> List()
        {
            return _db.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            _db.Entry<T>(obj).State = System.Data.Entity.EntityState.Modified;
        }
    }
}

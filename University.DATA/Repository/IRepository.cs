using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DATA.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        List<T> List();
        T Add(T obj);
        void Update(T obj);
        T Get(int id);
    }
}

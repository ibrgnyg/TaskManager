using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Interface
{
    public interface Imission<T>
    {
        void Save(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Finds(int id);
        IEnumerable<T> GetList();
            
    }
}

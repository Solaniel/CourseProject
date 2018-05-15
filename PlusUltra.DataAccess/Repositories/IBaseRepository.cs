using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltra.DataAccess.Repositories
{
    interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();

        T GetById(int id);

        void Create(T item);

        void Update(T item, Func<T, bool> findByID);
    }
}

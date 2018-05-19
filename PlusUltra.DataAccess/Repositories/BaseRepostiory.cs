using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace PlusUltra.DataAccess.Repositories
{
    public class BaseRepostiory<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Interface
{
    public interface IRepository<T>
    {
        public IEnumerable<T> getAll();
    }
}

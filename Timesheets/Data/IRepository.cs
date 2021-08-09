using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Data
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetItem(Guid id);
        Task<IEnumerable<T>> GetItems();
        Task Add(T item);
        Task Delite(T item);
    }
}

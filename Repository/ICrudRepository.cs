using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ExceptionLibrary.Repository
{
    public interface ICrudRepository<T, ID> where T : class
    {

        T Save(T entity);
        long Count(ID count);
        void Delete(T entity);
        void DeleteAll();
        void DeleteAll(IEnumerable<T> entities);
        void DeleteAllById(IEnumerable<ID> ids);
        void DeleteById(ID id);
        T FindById(ID id);

        bool ExitsById(ID id);
        IEnumerable<T> SaveAll(IEnumerable<T> entities);
        IEnumerable<T> FindAll();
        //////
      Task < T> SaveAsync(T entity);
     Task<   long> CountAsync();
       Task  DeleteAsync(T entity);
      Task  DeleteAllAsync();
       Task DeleteAllAsync(IEnumerable<T> entities);
        Task DeleteAllByIdAsync(IEnumerable<ID> ids);
        Task DeleteByIdAsync(ID id);
        Task<T> FindByIdAsync(ID id);
       Task< bool> ExitsByIdAsync(ID id);
        Task<IEnumerable<T>> SaveAllAsync(IEnumerable<T> entities);
       Task< IEnumerable<T>> FindAllAsync();
    }

}

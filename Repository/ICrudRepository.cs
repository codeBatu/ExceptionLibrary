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
    }

}

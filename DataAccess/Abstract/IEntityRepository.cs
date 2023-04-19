using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity
    {

    }
    {
        T Get();
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T product);
        void Update(T product);
        void Delete(T product);
        List<T> GetAllByCategory(int categoryId);

    }
}

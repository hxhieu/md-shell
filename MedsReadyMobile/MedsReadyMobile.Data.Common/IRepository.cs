using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MedsReadyMobile.Data.Common
{
    public interface IRepository<T>
    {
        ICollection<T> GetMany(Expression<Func<T, bool>> predicate);
        T GetSingle(Expression<Func<T, bool>> predicate);
        DataResult Insert(T obj);
        DataResult Delete(T obj);
        DataResult Delete(Expression<Func<T, bool>> predicate);
    }
}

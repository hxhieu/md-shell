using MedsReadyMobile.Data.Common;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RealmDb = Realms.Realm;

namespace MedsReadyMobile.Data.Realm
{
    public abstract class RealmRepositoryBase<T> : IRepository<T> where T : RealmObject
    {
        protected readonly RealmDb Db = RealmDb.GetInstance();

        public DataResult Delete(Expression<Func<T, bool>> predicate)
        {
            try
            {
                Db.Write(() =>
                {
                    var obj = GetSingle(predicate);
                    Db.Remove(obj);
                });

                return Success();
            }
            catch (Exception ex)
            {
                //TODO: Logging
                return Error(ex);
            }
        }

        public DataResult Delete(T obj)
        {
            try
            {
                Db.Write(() =>
                {
                    Db.Remove(obj);
                });

                return Success();
            }
            catch (Exception ex)
            {
                //TODO: Logging
                return Error(ex);
            }
        }

        public ICollection<T> GetMany(Expression<Func<T, bool>> predicate)
        {
            return Db.All<T>().Where(predicate).ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return Db.All<T>().Where(predicate).SingleOrDefault();
        }

        public DataResult Insert(T obj)
        {
            try
            {
                Db.Write(() =>
                {
                    Db.Add(obj);
                });

                return Success();
            }
            catch (Exception ex)
            {
                //TODO: Logging
                return Error(ex);
            }
        }

        protected DataResult Success()
        {
            return new DataResult
            {
                Success = true
            };
        }

        protected DataResult Error(Exception ex)
        {
            return new DataResult
            {
                Success = false,
                Error = ex.Message
            };
        }
    }
}

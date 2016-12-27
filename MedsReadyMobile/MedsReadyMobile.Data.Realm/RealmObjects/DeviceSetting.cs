using Realms;
using System;

namespace MedsReadyMobile.Data.Realm.RealmObjects
{
    public class DeviceSetting : RealmObject
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public T GetTypedValue<T>()
        {
            try
            {
                return (T)Convert.ChangeType(Value, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
    }
}

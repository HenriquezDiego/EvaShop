using Newtonsoft.Json;

namespace Microsoft.AspNetCore.Mvc
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T? GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }

        public static void SetObject(this ISession session, string key, IEnumerable<object> value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static IEnumerable<T>? GetIEnumerable<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<IEnumerable<T>>(value);
        }
    }
}

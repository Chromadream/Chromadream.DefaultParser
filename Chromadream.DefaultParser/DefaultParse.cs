using System;
using System.Reflection;

namespace Chromadream.DefaultParser
{
    public class DefaultParser
    {
        public static T Parse<T>(string source)
        {
            Type type = typeof(T);
            try
            {
                var methodInfo = type.GetMethod("Parse", new Type[]{typeof(string)});
                return (T)methodInfo.Invoke(null, new []{source});
            } catch (Exception e){
                Console.WriteLine(e);
                return default(T);
            }
        }
    }
}
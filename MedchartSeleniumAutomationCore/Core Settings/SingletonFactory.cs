using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MedchartSeleniumAutomationCore.Core_Framework
{
    /// <summary>
    /// This singleton factory is designed for if page object files get too large and need to be moved to partial classes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ThreadSafeNestedContructorsBaseSingleton<T>
    {
        public static T Instance
        {
            get
            {
                return SingletonFactory.Instance;
            }
        }

        internal static class SingletonFactory
        {
            internal static T Instance;

            static SingletonFactory()
            {
                CreateInstance(typeof(T));
            }

            public static T CreateInstance(Type type)
            {
                var constructorsPublic = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

                if (constructorsPublic.Length > 0)
                {
                    throw new Exception(string.Concat(type.FullName, " has one or more public constructors so the property cannot be enforced."));
                }

                var nonPublicConstructor =
                    type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], new ParameterModifier[0]);

                if (nonPublicConstructor == null)
                {
                    throw new Exception(string.Concat(type.FullName, " does not have a private/protected constructor so the property cannot be enforced."));
                }

                try
                {
                    return Instance = (T)nonPublicConstructor.Invoke(new object[0]);
                }
                catch (Exception e)
                {
                    throw new Exception(
                        string.Concat("The Singleton could not be constructed. Check if ", type.FullName, " has a default constructor."), e);
                }
            }
        }
    }
}

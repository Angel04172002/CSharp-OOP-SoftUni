using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Type type = Type.GetType(className);

            var instance = Activator.CreateInstance(type);

            stringBuilder.AppendLine($"Class under investigation: {className}");

            foreach (var field in fields)
            {
                FieldInfo fieldInfo = type.GetField(field, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

                string value = (string)fieldInfo.GetValue(instance);

                stringBuilder.AppendLine($"{fieldInfo.Name} = {value}");
            }

            return stringBuilder.ToString().TrimEnd();

        }


        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Type type = Type.GetType(className);

            var instance = Activator.CreateInstance(type);

            FieldInfo[] fields = type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            foreach (var field in fields) 
            {
                if(!field.IsPrivate)
                {
                    stringBuilder.AppendLine($"{field.Name} must be private!");
                }
            }


            PropertyInfo[] properties = type
                .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);


            foreach (var property in properties)
            {
                var getMethod = property.GetGetMethod(true);
                var setMethod = property.GetSetMethod(true);

                if(!getMethod.IsPublic)
                {
                    stringBuilder.AppendLine($"{getMethod.Name} have to be public!");
                }


                if(!setMethod.IsPrivate)
                {
                    stringBuilder.AppendLine($"{setMethod.Name} have to be private!");
                }
                
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}

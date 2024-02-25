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
    }
}

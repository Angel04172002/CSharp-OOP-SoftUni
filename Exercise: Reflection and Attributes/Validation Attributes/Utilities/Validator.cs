using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Utilities
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();

            PropertyInfo[] properties = type
                .GetProperties()
                .Where(p => p.CustomAttributes.Any(x => typeof(MyValidationAttribute).IsAssignableFrom(x.AttributeType)))
                .ToArray();


            foreach (var property in properties)
            {
                var attributes = property
                    .GetCustomAttributes()
                    .Where(x => typeof(MyValidationAttribute).IsAssignableFrom(x.GetType()))
                    .ToArray();

                object propValue = property.GetValue(obj);


                foreach (var currentAttribute in attributes)
                {
                    Type attrType = currentAttribute.GetType();

                    MethodInfo validMethod = attrType
                        .GetMethods()
                        .FirstOrDefault(m => m.Name == "IsValid");

                    if (validMethod == null)
                    {
                        throw new InvalidOperationException("Invalid method");
                    }

                    bool result =  (bool)validMethod.Invoke(currentAttribute, new object[] { propValue });
                    
                    if(result == false)
                    {
                        return false;
                    }
                }
            }


            return true;

        }
    }
}

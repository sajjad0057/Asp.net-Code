using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class JsonFormatter
    {

        public StringBuilder Json { get; set; }

        public int ObjectPropertyLenghtFlag { get; set; }
        public int ListPropertyLenghtFlag { get; set; }

        public JsonFormatter()
        {
            Json = new StringBuilder(string.Empty);
            ObjectPropertyLenghtFlag = 0;
            ListPropertyLenghtFlag = 0;
        }
        public string Convert(Object obj)
        {
            Type type = obj.GetType();
            if (!type.IsGenericType && !type.IsPrimitive)
            {
                Json.Append("{ \n");
            }
            PropertyInfo[] properties = type.GetProperties();
            ObjectPropertyLenghtFlag = properties.Length;
            foreach (PropertyInfo property in properties)
            {
                Type valueType = property.GetValue(obj).GetType();

                if (!valueType.IsGenericType)
                {
                    if (valueType == typeof(string) || valueType.IsPrimitive)
                    {
                        Json.Append($"\"{property.Name}\" : \"{property.GetValue(obj)}\"");
                        if (ObjectPropertyLenghtFlag > 1)
                        {
                            Json.Append(",\n");
                        }
                        
                    }
                }
                else if(valueType.IsGenericType && valueType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    //Convert((IEnumerable<object>)property.GetValue(obj));
                    var list = (IEnumerable<object>)property.GetValue(obj);
                    Json.Append($"{property.Name} : \n[");
                    foreach(var item in (IEnumerable<object>)property.GetValue(obj))
                    {
                        Convert(item);
                    }
                    Json.Append("\n],\n");
                }
                else if(valueType.IsClass && valueType != typeof(string))
                {
                    Convert(property.GetValue(obj));
                }

                ObjectPropertyLenghtFlag--;
               //Json.Append($"\"{ property.Name }\" : \"{property.GetValue(obj).GetType().IsGenericType}\",")
            }


            Json.Append("\n}\n");
                        
            return Json.ToString();
        }


    }
}

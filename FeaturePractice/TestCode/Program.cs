using System;
using System.Reflection;
using TestCode;

Course course = new Course
{
    Title = "c#",
    Topics = new List<Topic>
    {
        new Topic { Title = "Basic C#" , Description = "dataType"},
        new Topic { Title = "Advanced C#" , Description = "Reflection"}
    },
    Fees = 5000,
};



//Console.WriteLine(course.Topics);
//Console.WriteLine();
//foreach (var topic in course.Topics)
//{
//    Console.WriteLine(topic);
//}


Convert(course);


void Convert(Object obj)
{
    Type type = obj.GetType();
    //Console.WriteLine(type);
    PropertyInfo[] properties = type.GetProperties();
    foreach (PropertyInfo property in properties)
    {
        Type t = property.PropertyType;

        if (t == typeof(string) || t.IsPrimitive)
        {
            Console.WriteLine($"{property.Name} : {property.GetValue(obj)}");
        }
        else if (t.GetGenericTypeDefinition() == typeof(List<>))
        {   
            //var typeOfList  = t.GetGenericArguments()[0];

            //Console.WriteLine($"+++{typeOfList.GetType()}");

            var list = property.GetValue(obj);

            foreach (var item in (IEnumerable<object>)list)
            {
                Convert(item);
            }



        }
    }

}
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



JsonFormatter formatter = new JsonFormatter();

string json = formatter.Convert(course);

Console.WriteLine(json);


//void Convert(Object obj)
//{
//    Type type = obj.GetType();
//    //Console.WriteLine(type);
//    PropertyInfo[] properties = type.GetProperties();
//    foreach (PropertyInfo property in properties)
//    {
//        Type t = property.PropertyType;


//        Console.WriteLine($"{property.Name} : {property.GetValue(obj)}");


//    }

//}
// See https://aka.ms/new-console-template for more information
using Reflection;
using System.Reflection;

Console.Write("Enter Class Name : ");
string className = Console.ReadLine();

Console.Write("Enter Property Name : ");
string propertyName = Console.ReadLine();

Console.Write("Enter Property Value : ");
string propertyValue = Console.ReadLine();

/*
Returns
Assembly
The assembly that contains the code that is currently executing. 
*/
Assembly assembly = Assembly.GetExecutingAssembly();

Type type = assembly.GetType(className);

Console.WriteLine($"type : {type}");

PropertyInfo property  = type.GetProperty(propertyName);


/*
set hare empty constructor , so parameter list is empty array . if Class contains 
parameterized constructor , when add parameter type in Type array
 */

ConstructorInfo constructor = type.GetConstructor(new Type[] { });

object instance = constructor.Invoke(new object[] { });

property.SetValue(instance, propertyValue);


//Person person = instance as Person;

//Console.WriteLine(person.Name);


PropertyInfo[] properties = type.GetProperties();

foreach (PropertyInfo p in properties)
{
    Console.WriteLine($"{p.Name} : {p.GetValue(instance)}");
}

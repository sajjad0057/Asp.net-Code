// See https://aka.ms/new-console-template for more information
using Reflection;
using System.Reflection;
using System.Text.Json;

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

ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(int) });

object instance = constructor.Invoke(new object[] { 20 });

property.SetValue(instance, propertyValue);


Person person = instance as Person;

Console.WriteLine(person.Name);

string jsonString = JsonSerializer.Serialize(person);

Console.WriteLine(jsonString);


//PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

//foreach (PropertyInfo p in properties)
//{
//    Console.WriteLine($"{p.Name} : {p.GetValue(instance)}");
//}

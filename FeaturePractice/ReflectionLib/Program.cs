
using System.Reflection;

string directory = Directory.GetCurrentDirectory();

//Console.WriteLine(directory);


string path = directory + @"\ReflectionLib.dll";

Console.WriteLine(path);



Assembly assembly = Assembly.LoadFile(path);


Type[] types = assembly.GetTypes();

foreach(Type type in types)
{
    Type t = type.GetInterface("IModule");
    if (t != null)
        Console.WriteLine(type.Name);
}


Console.Write("Write Class Name : ");
string input = Console.ReadLine();  

foreach(Type type in types)
{
    if (type.Name == input)
    {
        MethodInfo methodInfo = type.GetMethod("Start");
        ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { });
        object obj = constructorInfo.Invoke( new object[] { });
        methodInfo.Invoke(obj, new object[] { });
    }
}

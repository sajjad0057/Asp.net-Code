
using System.Reflection;

string directory = Directory.GetCurrentDirectory();

Console.WriteLine(directory);


string path = directory + @"\ReflectionLib.dll";

Console.WriteLine(path);



Assembly assembly = Assembly.LoadFile(path);


foreach(Type type in assembly.GetTypes())
{
    Type t = type.GetInterface("IModule");
    Console.WriteLine(t);
}



using CSharp_New_Feature;

//// Feature of C# - 11 :



int age = 25;
string name = "sajjad";


Console.WriteLine($"Hello," +
    $"{name} -" +
    $"You are {age} years old .");


string longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    """;


Console.WriteLine(longMessage);


var location = $$"""
   You are at {{{age}}, {{name}}}   
   """;


Console.WriteLine(location);

//// OutPut :
//// You are at {25, sajjad}
///


///// declaring System.Console namespace globally and use WriteLine() only to print something instead of Console.WriteLine() . 

WriteLine($"Use only WriteLine to print something , " +
    $"for this using \"static System.Console\" namespace locally or glabally");



WriteLine("---------------------------------------------------------------------");


Person person = new Person();

//{ person.Location : new Address { City = "a", Street = "b" }; };


WriteLine("--------------------------------------------------");
////Improve tuple syntax : 


(int a, int b) point1 = (5, 8);

(int x, int y) point;

int x = 0;
int y = 0;
(x,  y) = point1;


point = point1;


WriteLine($"{point.Item1} ; {point.Item2} ");


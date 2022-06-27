


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
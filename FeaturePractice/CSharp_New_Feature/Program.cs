using CSharp_New_Feature;

//// Feature of C# - 11 :
///

public class Program
{
    public static async Task Main(string[] args)
    {


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


        //(int a, int b) point1 = (5, 8);

        //(int x, int y) point;

        //int x = 0;
        //int y = 0;
        //(x,  y) = point1;


        //point = point1;


        //WriteLine($"{point.Item1} ; {point.Item2} ");


        int M(int v)
        {
            int y = 5;
            int x = 7;
            return Add(x, y, v);

            static int Add(int left, int right, int v) => left + right * v;
        }


        int r = M(4);

        Console.WriteLine(r);


        Class1 class1 = new Class1 { Name = "sajjad" };


        Point point = new Point();


        point.X = 1;
        point.Y = 2;

        WriteLine($"point Type : {point.GetType()}");
        WriteLine($"{point.ToString()}");


        WriteLine("<---------------- -------------------- -------------------- ------------------>");

        WriteLine(Class2.FromRainbow(Class2.Rainbow.Red));



        await foreach (var number in Class2.GenerateSequence())
        {
            Console.WriteLine(number);
        }




    var words = new string[]
        {
                        // index from start    index from end
            "The",      // 0                   ^9
            "quick",    // 1                   ^8
            "brown",    // 2                   ^7
            "fox",      // 3                   ^6
            "jumped",   // 4                   ^5
            "over",     // 5                   ^4
            "the",      // 6                   ^3
            "lazy",     // 7                   ^2
            "dog"       // 8                   ^1
        };              // 9 (or words.Length) ^0


        Console.WriteLine("---------------------++++++----------------------");
        Console.WriteLine($"The last word is {words[^1]}");
        // writes "dog"
        foreach (var word in words[6..])
        {
            Console.WriteLine(word);
        }

    }
}









namespace Delegate
{
    public class Program
    {
        public delegate void PrintDelegate(object message);

        public static void Calculate(int x, int y, PrintDelegate printer)
        {
            int result = x + y;
            printer(result);
        }
    }


    public class Test
    {
        public static void Print1(object message)
        {
            Console.WriteLine(message);
        }

        public static void Print2(object message)
        {
            Console.WriteLine($"-----{message}------");
        }

        public static void Main(string[] args)
        {
            Program.Calculate(1, 3, Print1);
            Program.Calculate(2, 3, Print2);
        }
    }
}


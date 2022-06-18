using DelegatesAndEvent_Practice;

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

            Console.WriteLine("Another Delegate Examples : ");

            int CompareValues(int a, int b)
            {
                if(a>b)
                    return -1;
                else if(a<b)
                    return 1;
                return 0;

            }

            int[] a =new int[] {1,6,3,21,7,4,2,8,33};

            BubbleSort<int>.Sort(a, CompareValues);

            foreach (int i in a)
            {
                Console.Write($"{i} , ");
            }
        }
    }
}


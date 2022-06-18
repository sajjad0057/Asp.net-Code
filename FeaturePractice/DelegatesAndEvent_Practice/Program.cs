using DelegatesAndEvent_Practice;


void Print1(object message)
{
Console.WriteLine(message);
}

void Print2(object message)
{
Console.WriteLine($"-----{message}------");
}


PrintUsingDelegate.Calculate(1, 3, Print1);
PrintUsingDelegate.Calculate(2, 3, Print2);

Console.WriteLine("Another Delegate Examples - Perform Bubble Sort : ");


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


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

Console.WriteLine("------------------------------------------------------------------");
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


Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("Another Delegate Examples -  ");
Console.WriteLine("------------------------------------------------------------------");

Person[] persons = new Person[4];

persons[0] = new Person { Name = "sajjad" , Age = 25};
persons[1] = new Person { Name = "zahan" , Age = 24};
persons[2] = new Person { Name = "zahan", Age = 23 };
persons[3] = new Person { Name = "Mahdi", Age = 27 };


int SortPerson(Person p1, Person p2)
{
    if (p1.Name == p2.Name)
    {

        if (p1.Age < p2.Age)
            return 1;
        else if (p1.Age > p2.Age)
            return -1;
        return 0;

    }
    else
        return p1.Name.CompareTo(p2.Name);

}


BubbleSort<Person>.Sort(persons, SortPerson);


foreach (Person p in persons)
{
    Console.WriteLine($"Name : {p.Name} ; Age : {p.Age}");
}




Console.WriteLine("===========================================================");
Console.WriteLine("Prime Generator : ");


PrimeGenerator primeGenerator = new PrimeGenerator();

primeGenerator.PrimeGenerationComplete += PrintPrimes;

//Thread t = new Thread(()=> primeGenerator.Generate(10));
//t.Start();
//Console.ReadKey();

primeGenerator.Generate(4);

void PrintPrimes(List<int> primes)
{
    foreach (int p in primes)
    {
        Console.WriteLine($"{p} is prime number ");
    }
}








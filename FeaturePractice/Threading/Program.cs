﻿using Threading;

//Thread thread1 = new Thread(() => Print1(100));   //// using this syntax , can pass a function with thread, otherwise need delegate features
//thread1.Start();

//Thread thread2 = new Thread(() => Print2(100));

//thread2.Start();


//void Print1(int value)
//{
//    for(int i = 0; i <= value; i++)
//    {   
//        if(i%2 != 0)
//            Console.WriteLine($"Odd : {i}");
//    } 
//}




//void Print2(int value)
//{
//    for(var i = 0; i <= value; i++)
//    {
//        if(i%2 == 0)
//            Console.WriteLine($"Even : {i}");
//    }
//}


//Console.WriteLine("+--------------->finish<---------------+");


Console.WriteLine($"Practice async / await : \n" +
    $"-------------------------------------------------------------");

var folderPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
var filePath = Path.Combine(folderPath.FullName, "Text.txt");

////Console.WriteLine(filePath);

AsyncExample asyncExample = new AsyncExample();

await asyncExample.Copy(filePath);






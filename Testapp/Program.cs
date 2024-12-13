using System;
using System.Text;
using System.Net.NetworkInformation;


Ping p1 = new Ping();
PingReply PR =  p1.Send("8.8.8.8");

// while(PR.Status.ToString() == "Success")
// {
//    Console.WriteLine(PR.Status.ToString());
//    PR =  p1.Send("8.8.8.8");
//    Console.WriteLine("Wait ten seconds for new request");
//    Thread.Sleep(1000);

// }

Phome phome = new Phome();
phome.Brand = "Iphone";


// See https://aka.ms/new-console-template for more information


// string bill = "This is a test";
// int num = 1;
// var a = "This is var test";
// //var b = 'a';
// //a[2] = 'd';

// Console.WriteLine($"This is template litral {bill} ");
// Console.WriteLine(num);
// Console.WriteLine(a);

// StringBuilder stringBuilder = new StringBuilder();

// stringBuilder.Append("Crab is good");
// stringBuilder.Remove(0,3);


// Console.WriteLine(stringBuilder);

// string[] arr = ["apple", "Banana", "Carrot"];
// foreach(var item in arr)
// {
//     Console.WriteLine(item);
// }

// for(var i=0; i<arr.Length; i++)
// {
//     Console.WriteLine(arr[i]);
// }

// arr.ToList().ForEach((x)=> 
// {Console.WriteLine(x);
// });

// Array.ForEach(arr, x=> Console.WriteLine(x));

// var FishTank = 100;
// if(FishTank <= 100)
// {
//     Console.WriteLine("I'll buy fish");
// }
// else
// {
//     Console.WriteLine("I'll skip");
// }

// var isString = "Fish is a string";
// if(isString is string)
// {
//     Console.WriteLine("Its a string for sure");
// }


// // Console.WriteLine((int)Warning.CodeBlue);
// // enum Warning
// // {
// //     CodeRed,
// //     CodeBlue,
// //     CodeYellow
// // }



// var name = "Ming";

// var result = name switch 
// {
//     "Zihan" => "Zihan",
//     "Ming" => "Ming",
//     _ => "nothing match"
// };

// Console.WriteLine( "This is from switch" + result);


﻿using System;
using System.Text;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!!");

string bill = "This is a test";
int num = 1;
var a = "This is var test";
//var b = 'a';
//a[2] = 'd';

Console.WriteLine($"This is template litral {bill} ");
Console.WriteLine(num);
Console.WriteLine(a);

StringBuilder stringBuilder = new StringBuilder();

stringBuilder.Append("Crab is good");
stringBuilder.Remove(0,3);


Console.WriteLine(stringBuilder);

string[] arr = ["apple", "Banana", "Carrot"];
foreach(var item in arr)
{
    Console.WriteLine(item);
}

for(var i=0; i<arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

arr.ToList().ForEach((x)=> 
{Console.WriteLine(x);
});

Array.ForEach(arr, x=> Console.WriteLine(x));

var FishTank = 100;
if(FishTank <= 100)
{
    Console.WriteLine("I'll buy fish");
}
else
{
    Console.WriteLine("I'll skip");
}

var isString = "Fish is a string";
if(isString is string)
{
    Console.WriteLine("Its a string for sure");
}


Console.WriteLine((int)Warning.CodeBlue);
enum Warning
{
    CodeRed,
    CodeBlue,
    CodeYellow
}

var name = "Ming";

var result = name switch 
{
    "Zihan" => "Zihan",
    "Ming" => "Ming",
    _ => "nothing match",
};

Console.WriteLine( "This is from switch" + result);

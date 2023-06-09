﻿// See https://aka.ms/new-console-template for more information
using OOPsReview;

Console.WriteLine("Hello, World!");

Residence myHome = new Residence(123, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());

// You cannot change a value in the record instance
// myHome.Number = 321;

// To alter a value in the record instance you must create a new instance
myHome = new Residence(321, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());

// Example of refactoring
// Refactoring is the process of restructuring code while not changing its original functionality. The goal of refactoring is to improve internal code by making small changes without altering the code's external behaviour

// Original code
bool flag = false;
if (myHome.Province.ToLower()==("ab"))
{
    flag = true;
}

if (myHome.Province.ToLower()==("bc"))
{
    flag = true;
}

if (myHome.Province.ToLower()==("sk"))
{
    flag = true;
}

if (myHome.Province.ToLower()==("mn"))
{
    flag = true;
}

if (myHome.Province.ToLower() == "ab" || myHome.Province.ToLower() == "bc" || myHome.Province.ToLower() == "sk" ||myHome.Province.ToLower() == "mn")
{
    flag = true;
}

// Refactor using a switch statement
switch (myHome.Province.ToLower())
{
    case "ab":
    case "bc":
    case "sk":
    case "mn":
        {
            flag = true;
            break;
        }
    default:
        {
            flag = false;
            break;
        }
}
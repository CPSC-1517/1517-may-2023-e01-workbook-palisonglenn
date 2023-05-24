// See https://aka.ms/new-console-template for more information
using OOPsReview;

Console.WriteLine("Hello, World!");

Residence myHome = new Residence(123, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());

// You cannot change a value in the record instance
// To alter a value in the record instance you must create a new instance

myHome = new Residence(321, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());


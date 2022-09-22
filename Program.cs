// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();

Console.WriteLine("Введите цифру, обозначающую день недели: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number > 0)
if (number <= 5)
Console.WriteLine ("Нет, это не выходной");

if (number > 5) 
if (number <= 7)
Console.WriteLine ("Да, это выходной");

if (number > 7)
Console.WriteLine ("Указана не корректная цифра");

if (number < 1)
Console.WriteLine ("Указана не корректная цифра");

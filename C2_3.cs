﻿//Задача 3: Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if ( numberInt <100) System.Console.WriteLine("Третьей цифры нет");

else
{
    while (numberInt > 999)
    {
        numberInt = numberInt/10;
    }
    numberInt = numberInt % 100;
    numberInt = numberInt % 10;
    System.Console.WriteLine("Третья цифра  " + numberInt);
}
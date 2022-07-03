//Задача 1: Напишите программу, которая принимает на вход 
//пятизначное число и проверяет,
//является ли оно палиндромом.
int prompt(string message)
{
Console.Write(message);
string num = Console.ReadLine();
int numInt = int.Parse(num);
return numInt;
}
int numInt = prompt("Введите пятизначное число ");
if ( numInt/10000 == numInt%10 && numInt/1000%10 == numInt%100/10 ) 
{ System.Console.WriteLine("Это палиндром"); }
else
{
System.Console.WriteLine("Это НЕ палиндром");
}


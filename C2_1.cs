//Задача 1: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает
//вторую цифру этого числа.
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if (numberInt < 99)
{
    System.Console.WriteLine("В числе меньше 3х символов");
   if (numberInt > 999)
    {
        System.Console.WriteLine("В числе больше 3х символов");
    }
    }
    else 
    {
       numberInt = numberInt/10%10; 
    System.Console.WriteLine(numberInt);
    }
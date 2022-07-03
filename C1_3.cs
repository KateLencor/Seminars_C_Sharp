//Задача 3: Напишите программу, которая на
//вход принимает число и выдаёт, является ли
//число чётным (делится ли оно на два без остатка).
Console.Write("Введите число:  ");
string Chislo1 = Console.ReadLine();
int a = int.Parse(Chislo1);
if ( (a%2) == 0 )
{
    Console.WriteLine("Четное");
}
 else
    {
        Console.WriteLine("Нечетное");
    }



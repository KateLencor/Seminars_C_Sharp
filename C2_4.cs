//Задача 4: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру для недели (1-пн,2-вт,3-ср,4-чт,5-пт,6-сб,7-вс) : ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if ( numberInt == 6 || numberInt == 7) 
{ 
     System.Console.WriteLine("Выходной день");
}
    else
    {
        if (numberInt > 7)
           {
    System.Console.WriteLine("Вы ввели цифру не обозначающую выходной");
}
else
{
    System.Console.WriteLine("Будний день");
}

}


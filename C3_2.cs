//Задача 2: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между 
//ними в 3D пространстве.
int prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
    }
int x1 = prompt("введите х1 :  ");
int y1 = prompt("введите y1 :  ");
int z1 = prompt("введите z1 :  ");
int x2 = prompt("введите х1 :  ");
int y2 = prompt("введите y1 :  ");
int z2 = prompt("введите z1 :  ");
int a = x1-x2;
int b = y1-y2;
int c = z1-z2;
double result = Math.Sqrt(a*a+b*b+c*c);
System.Console.WriteLine("Расстояние между двумя точками в трехмерном пространстве  " + result);

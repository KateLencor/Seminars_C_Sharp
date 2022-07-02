Console.Write("Введите первое число  ");
string Chislo1 = Console.ReadLine();
double a = double.Parse(Chislo1);
Console.Write("Введите второе число  ");
string Chislo2 = Console.ReadLine();
double b = double.Parse(Chislo2);
if (a > b)
{
    Console.WriteLine("max = "  + a  );
    Console.Write("min = " + b   );
}
else
{
    Console.WriteLine("max = " + b   );
    Console.Write("min = " + a   );
}

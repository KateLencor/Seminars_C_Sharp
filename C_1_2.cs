Console.Write("Введите первое число  ");
string Chislo1 = Console.ReadLine();
double a = double.Parse(Chislo1);
Console.Write("Введите второе число  ");
string Chislo2 = Console.ReadLine();
double b = double.Parse(Chislo2);
Console.Write("Введите третье число  ");
string Chislo3 = Console.ReadLine();
double c = double.Parse(Chislo3);
if (a > b && a > c )
{
    Console.WriteLine("max = "  + a  );
}
else if (b > a && b > c)
{
    Console.WriteLine("max = "  + b  );
}
else
{
    Console.WriteLine("max = "  + c  );
}


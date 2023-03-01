int chislo1, chislo2;
while(true)
{
    Console.WriteLine("Введите первое число=");
        if (int.TryParse(Console.ReadLine(), out chislo1))
            break;
        Console.WriteLine("Ошибка ввода");
}

while(true)
{
    Console.WriteLine("Введите второе число=");
        if (int.TryParse(Console.ReadLine(), out chislo2))
            break;
        Console.WriteLine("Ошибка ввода");
}
int max=chislo1;
if (chislo2>max) 
Console.WriteLine($"max={chislo2}");
else
Console.WriteLine($"max={chislo1}");

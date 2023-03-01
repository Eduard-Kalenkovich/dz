int chislo1, chislo2, chislo3;
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
while(true)
{
    Console.WriteLine("Введите третье число=");
        if (int.TryParse(Console.ReadLine(), out chislo3))
            break;
        Console.WriteLine("Ошибка ввода");
}

int max=chislo1;
if (chislo2>max) 
max=chislo2;
else
    if (chislo3>max)
    max=chislo3;
Console.WriteLine($"среди чисел {chislo1}, {chislo2}, {chislo3}, максимальное ->{max}");

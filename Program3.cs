int chislo1;
while(true)
{
    Console.WriteLine("Введите число=");
        if (int.TryParse(Console.ReadLine(), out chislo1))
            break;
        Console.WriteLine("Ошибка ввода");
}




if (chislo1%2==0) 
Console.WriteLine($"Число {chislo1} четное");
else 
Console.WriteLine($"Число {chislo1} НЕ четное"); 
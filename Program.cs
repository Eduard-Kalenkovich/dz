int chislo1;
while(true)
{
    Console.WriteLine("Введите число=");
        if (int.TryParse(Console.ReadLine(), out chislo1))
            break;
        Console.WriteLine("Ошибка ввода");
}

int i=0;
while (i<chislo1)
{Console.Write(i+" ");
i=i+2;}
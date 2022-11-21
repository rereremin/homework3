Console.Clear();
System.Console.WriteLine("Таблица кубов чисел до N.");

int N = InputN();
NumberCubes(N);

static int InputN()
{
    try
    {
        System.Console.Write("Введите N: ");
        return int.Parse(Console.ReadLine()??"");
    }
    catch (Exception exc)
    {
        System.Console.WriteLine($"Ошибка ввода! {exc.Message}");
        System.Console.Write("Введите N (целое число): ");
        return int.Parse(Console.ReadLine() ??"");
    }
    
}

static void NumberCubes(int N)
{
    int index = 1;
    System.Console.Write($"{N} -> ");
    while (index <= N)
    {
        if(index < N) System.Console.Write($"{Math.Pow(index, 3)}, ");
        else if(index == N) System.Console.Write($"{Math.Pow(index, 3)}. ");
        index++;
    }
}
 
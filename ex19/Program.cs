Console.Clear();
System.Console.WriteLine("Палиндром???");

int number = InitNumber();
Result(number);

static int InitNumber()
{
    try
    {
        System.Console.WriteLine("Введите пятизначное число: ");
        return int.Parse(Console.ReadLine() ??"");
        
    }
    catch (Exception exc)
    {
        System.Console.WriteLine($"Ошибка ввода! {exc.Message}");
        return 0;
    }
}

static void Result(int number)
{
    if(number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        System.Console.WriteLine("correct");
    }
    else
    {
        System.Console.WriteLine("!!!!");
    }
}
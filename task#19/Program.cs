Console.Write("Введите 5-ти значное число");
string? Numbers = Console.ReadLine();

void checkDay(string Numbers)
{

    if (Numbers[0] == Numbers[4] || Numbers[1] == Numbers[3])
    {

        Console.WriteLine($"{Numbers} -> да");

    }
    else
    {

        Console.WriteLine($"{Numbers} -> нет");
    }
}
checkDay(Numbers!);


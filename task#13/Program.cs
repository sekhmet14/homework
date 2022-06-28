int numbers;

Console.Write("imput numbers:");
numbers = Convert.ToInt32(Console.ReadLine());
string numbersline = Convert.ToString(numbers);

if (numbersline.Length > 2)
{

    Console.WriteLine($"третья цифра : {numbersline[2]}");

}
else {

    Console.WriteLine("третьей цифры нет!");

}
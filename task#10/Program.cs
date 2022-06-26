int SnowDigit()
{
Console.Write("Введите трехзначное число:");
int numbers = Convert.ToInt32(Console.ReadLine());
int n1 = numbers % 100;
int result = n1 / 10;
return result;

}

int res = SnowDigit();
Console.WriteLine(res);
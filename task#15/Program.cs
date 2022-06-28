Console.Write("введите цифру дня недели:");

int daynum = Convert.ToInt32(Console.ReadLine());

void CheckDays(int daynum){

    if (daynum == 6 || daynum == 7) {

        Console.WriteLine($"{daynum} -> да ");

    }
    else if (daynum < 1 || daynum > 7) {


        Console.WriteLine("данного дня не существует в недели!");

    }

    else {

        Console.WriteLine($" {daynum} -> нет");

    }

}

CheckDays(daynum);
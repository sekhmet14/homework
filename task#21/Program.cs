int x1 = Coordinate("x", "1");
int x2 = Coordinate("x", "2");
int y1 = Coordinate("y", "1");
int y2 = Coordinate("y", "2");
int z1 = Coordinate("z", "1");
int z2 = Coordinate("z", "2");

int Coordinate(string line, string point){

    Console.WriteLine($"Введите координату {line} и точки {point}:");

    return Convert.ToInt16(Console.ReadLine());
}

double ruling(double x1, double x2, double y1, double y2, double z1, double z2) {


    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));

 }

double elementLength = Math.Round(ruling(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Длина отрезка  {elementLength}");

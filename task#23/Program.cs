Console.Write("Введите число: ");
int cubes = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cubes){
 int counter = 0;
 int length = cubes.Length;
 while (counter < length){
 cubes[counter] = Convert.ToInt32(Math.Pow(counter, 3));
 counter++;
  }
}

void PrintArr(int[] collecting){
 int count = collecting.Length;
  int index = 0;
  while(index < count){
    Console.Write(collecting[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cubes+1];
Cube(arry);
PrintArr(arry);
/*void GetDiapozone(int quadrant)
{
  if(quadrant == 1)  Console.WriteLine("x > 0 and y > 0");
  else if(quadrant == 2)  Console.WriteLine("x < 0 and y > 0");
  else if(quadrant == 3)  Console.WriteLine("x < 0 and y < 0");
  else if(quadrant == 4)  Console.WriteLine("x > 0 and y < 0");
  else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapozone(quadNum);
*/

// Задача 1. Написать прогу которая на вход принимает координаты точки(ненул)  и выдает в какой четверти
/*int GetFunct(int xPos, int yPos)
{
  if(xPos > 0 && yPos > 0) return 1;
  else if(xPos < 0 && yPos > 0) return 2;
  else if(xPos < 0 && yPos < 0)  return 3;
  else if(xPos > 0 && yPos < 0)  return 4;
  else return 0;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetFunct(x,y));

void Funct()
{
if(GetFunct(x,y) ==1) Console.WriteLine("1 четверть");
else if(GetFunct(x,y) ==2) Console.WriteLine("2 четверть");
else if(GetFunct(x,y) ==3) Console.WriteLine("3 четверть");
else if(GetFunct(x,y) ==4) Console.WriteLine("4 четверть");
else if(GetFunct(x,y) ==0) Console.WriteLine("Error output");
}
*/

// Задача 2. Написать прогу которая на вход принимает некоторое число, и выдает таблицу чисел квадратов числа

/*void Funct(int N)
{
 int count = 1;
 while(count <= N)
 {
   int z = count * count;
   Console.WriteLine($"{count} > {z}");
   count++;
 }
}

Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Funct(numN);
*/

// Задача 3. Написать прогу которая на принимает координаты 2 точек и находит расстояние между ними в 2мерном
/*double Funct(double xPos, double yPos, double xPos1, double yPos1)
{
  return Math.Sqrt(Math.Pow(xPos - xPos1, 2) + Math.Pow(yPos - yPos1, 2));
}

Console.Write("Input x: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y: ");
double y = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Funct(x,y,x1,y1));
*/

//MyrepozCSDz003
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/* int x1 = ReadInt("Input coordinat x first point: ");
int y1 = ReadInt("Input coordinat y first point: ");
int z1 = ReadInt("Input coordinat z first point: ");
int x2 = ReadInt("Input coordinat x second point: ");
int y2 = ReadInt("Input coordinat y second point: ");
int z2 = ReadInt("Input coordinat z second point: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double len = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Segment length {len}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 1 sposob:
/*void Funct(int N)
{
 int count = 1;
 while(count <= N)
 {
   int z = count * count * count;
   Console.WriteLine($"{count} > {z}");
   count++;
 }
}

Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Funct(numN);
*/
// 2 sposob;
/*int number = ReadInt("Input number N: ");
for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//ne smog Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* bool Polindrome(int num)
{
  int rez = 0;
  int newnum = num;
  while (num > 0)
  {
    rez = rez * 10 + num % 10;
    num = num / 10; 
  }
  return rez == newnum;
}
Console.Write("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (Polindrome(n))
    Console.WriteLine($"Number {n} this polindrom");
else Console.WriteLine($"Number {n} no polindrom");
*/
// Gotovo!
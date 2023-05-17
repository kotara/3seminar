
Console.WriteLine("Hello, World!");



//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double LongLine (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
    return lengthAB;
}

Console.WriteLine ("Input X coordinate of A : ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Y coordinate of A : ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Z coordinate of A : ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input X coordinate of B : ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Y coordinate of B : ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Z coordinate of B : ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);


Console.WriteLine($"Distance AB in 3D coordinates is {dist:f3}");
*/


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeFinder ()
{
    Console.WriteLine("Input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)
        {
            int res = current_i*current_i*current_i;
            Console.Write($"{res}, ");
            current_i ++;
        }
        Console.WriteLine("\b\b.");
    }
    else {
        int current_i = 1;
        while (current_i >= numberN)
        {
            int res = current_i*current_i*current_i;
            Console.Write($"{res}, ");
            current_i --;
        }
        Console.WriteLine("\b\b.");
    }
}
CubeFinder();
*/


//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

void palindrom (int num)
{
    int num1 = num / 10000 % 10;
    int num2 = num / 1000 % 10;
    int num4 = num /10 % 10;
    int num5 = num % 10;
    int count = num / 10000;
  //  Console.WriteLine($"{num1}, {num2}, {num4}, {num5}, {count}");


    if (count < 1 || count > 9)
    {
        Console.WriteLine("You entered not a 5-digit number!");
    }
    else {
     if (num1 == num5 && num2 == num4)
        {
         Console.WriteLine("Yes, it is palindrome!");
      }
     else
     {
        Console.WriteLine("No, it is not a palindrome");
      }
    }

}

palindrom(num);
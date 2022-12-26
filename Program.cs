//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom(int n)
{
int x=0,y=n;
int a =10;
while(n > 0)

    {
        x=x * a + n % a;
        n=n / a;
    }
return x == y;
}
int n;

Console.Write("Введите число:");
n = Convert.ToInt32(Console.ReadLine());
if (Palindrom(n))
Console.WriteLine("Палиндром");
else
Console.WriteLine("Не палиндром");
/*


/*Задача 21

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

double Distanse (double x1,double y1,double z1,
                   double x2,double y2,double z2)
{
double res1 = Math.Pow(x2 - x1, 2);
double res2 = Math.Pow(y2 - y1, 2);
double res3 = Math.Pow(z2 - z1, 2);
double result = Math.Sqrt(res1+res2+res3);
return result;
}
Console.WriteLine("Введите кординаты первой точек:");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите кординаты второй точек:");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками:" + Distanse(x1, y1,z1,x2,y2,z2));Console.Write("Введите кординаты первой точек:");
*/

                 
/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

/*
void Cube (int n)
{
    int count =1;
    Console.WriteLine("Кубы чисел");
    while(count < n+1)
    {
        Console.Write(count*count*count +" ");
        count++;
    }

}
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Cube (n);
*/

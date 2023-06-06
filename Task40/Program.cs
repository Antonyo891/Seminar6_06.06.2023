// See https://aka.ms/new-console-template for more information
/*// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.
*/
bool Treangle (int a, int b, int c)
{
 return a+b>c&&b+c>a&&a+c>b;
 }
Console.Clear();
Console.WriteLine("Введите длины сторон");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int с = int.Parse(Console.ReadLine());
if (Treangle (a,b,с)) System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет"); 

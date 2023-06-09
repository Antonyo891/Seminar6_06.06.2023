// See https://aka.ms/new-console-template for more information
// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

string DecToBin(int n)
{     string backword = "";
    //if (n==1) return result;
    // else {
        while (n > 0) {
                   backword = n % 2 + backword;
        n = n/2;}
        return backword;
}
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
System.Console.WriteLine($"{String.Join("",DecToBin(Number))}");

// See https://aka.ms/new-console-template for more information
// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

int[] DecToBin(int n)
{ int [] result = {1};
    string backword = "";
    if (n==1) return result;
     else {while (n >= 1)
    {
        //System.Console.WriteLine($"n%2 = {n%2}");
       //System.Console.WriteLine($"backword = {backword}");
        //System.Console.WriteLine($"n=  {n}");
        if (n==1) backword = backword + n % 2;
        else backword = backword + n % 2 + " ";
        n = n / 2;
            }}
    string[] resultString = backword.Split(" ");
    result = new int[resultString.Length];
    int temporary = 0;
    for (int i = 0; i < result.Length / 2; i++)
    {
        temporary = int.Parse(resultString[i]);
        result[i] = int.Parse(resultString[resultString.Length - 1 - i]);
        result[resultString.Length - 1 - i] = temporary;
    }
    System.Console.WriteLine(backword);
    return result;
}
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
System.Console.WriteLine($"{String.Join("",DecToBin(Number))}");

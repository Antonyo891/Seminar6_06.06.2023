  /*Задача 45: Напишите программу,
которая будет создавать копию заданного массива с помощью поэлементного копирования.*/
int Enter(string n)
{
    System.Console.WriteLine(n);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int[] GetRanArr(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(min, max + 1);
    return result;
}
int [] CopyArray (int [] array)
{
    int [] result = new int [array.Length];
    for (int i = 0; i<array.Length; i++) result[i] = array[i];
    return result;
}
Console.Clear();
int size = Enter("Введите размер массива");
int min = Enter("Введите минимальное значение элемента");
int max = Enter("Введите максимальное значение элемента");
int [] array1 = GetRanArr(size,min,max);
int [] array2 = CopyArray(array1);
System.Console.WriteLine($"array1 = {String.Join(" ",array1)}");
System.Console.WriteLine($"array2 = {String.Join(" ",array2)}");
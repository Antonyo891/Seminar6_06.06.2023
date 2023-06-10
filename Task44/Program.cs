// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// <aside>
// ❗ Числа Фибоначчи — числовая ****последовательность,
// каждый элемент которой равен сумме двух предыдущих.
int Enter(string n)
{
    System.Console.WriteLine(n);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int [] Fibanachi(int numbers)
{
    int [] result = new int [numbers];
    result [0] = 0; result[1] = 1;
    for (int i = 2; i<numbers; i++) result[i] = result[i-2]+result[i-1]; 
    return result;
}
Console.Clear();
int numbers = Enter("Введите количество выводимых элементов ряда Фибоначчи");
System.Console.WriteLine($"Первые {numbers} чисел ряда Фибоначчи = {String.Join(" ",Fibanachi(numbers))}");
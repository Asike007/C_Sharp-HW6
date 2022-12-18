// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введита размер массива: ");
int[] arr = NewArray(int.Parse(Console.ReadLine()!));
NumberAboveZero(arr);

int[] NewArray(int size)
{
    Console.WriteLine("Введита числа: ");
    int[] b = new int[size];
    int i = 0;
    for (int n = 0; n < size; n++)
    {
        string a = Console.ReadLine()!;
        b[i++] = Convert.ToInt32(a);
    }
    for (int k = 0; k < i; k++)
    {
        Console.Write($" {b[k]}, ");
    }
    return b;
    Console.Write(" -> ");
}

void NumberAboveZero(int[] arr)
{
    int res = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > 0) res = res + 1;
    }
    Console.Write($"Чисел больше нуля: {res}");
}

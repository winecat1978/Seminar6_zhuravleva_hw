// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int [] FillArray(string msg)
{
    Console.WriteLine(msg);
    int [] massiv = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
    return massiv;
}

int PositiveCount(int [] Array)
{
    int positive_count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            positive_count+=1;
        }
    }
    return positive_count;
}
string message = "Введите массив через пробел: ";
int [] Array = FillArray(message);
int result = PositiveCount(Array);
Console.WriteLine(string.Join(" ", Array) + $" -> {result}");

/*
Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */


Console.Write("Введите количество чисел: ");
int amount = Int32.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < amount; i++)
{
    Console.Write("Введите число: ");
    int number = Int32.Parse(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine($"Чисел > 0: {count}");

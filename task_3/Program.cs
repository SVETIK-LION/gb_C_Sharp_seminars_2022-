/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
кубов чисел от 1 до N. */


string CubesTableNum(int number)
{
    string result_table = "";
    for (int i = 1; i <= number; i++)
    {
        if (i == number)
        {
            result_table += $"{Math.Pow(i, 3)}";
        }
        else
        {
            result_table += $"{Math.Pow(i, 3)}, ";
        }
    }
    return ($"{number} -> {result_table}");
}


Console.WriteLine(CubesTableNum(3));

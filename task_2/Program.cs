/* Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11

82 -> 10

9012 -> 12 */


int SumNumbersDigits(int number)
{
    string str_number = number.ToString();
    int result = 0;
    for (int i = 0; i < str_number.Length; i++)
    {
        result += number % 10;
        number /= 10;

    }
    return result;
}


Console.WriteLine(SumNumbersDigits(452));

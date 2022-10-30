/* Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет. */


string ThirdDigit(int number)
{
    if (number.ToString().Length < 3)
    {
        return ("У числа нет третьей цифры");
    }
    else
    {
        int third_digit = number % 10;
        return third_digit.ToString();
    }
}


Console.WriteLine(ThirdDigit(123));

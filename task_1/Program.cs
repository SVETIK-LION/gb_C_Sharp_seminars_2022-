/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. */


int SecondDigit(int number)
{

    int second_digit = ((number / 10) % 10);
    return second_digit;
}


Console.WriteLine(SecondDigit(123));

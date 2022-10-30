/* Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом. */


string isPalindrome(int number)
{

    string str_number = number.ToString();

    if (str_number.Length == 5)
    {
        if (str_number[0] == str_number[4] && str_number[1] == str_number[3])
        {
            return ($"{number} - Это палиндром");
        }
        else
        {
            return ($"{number} - Это не палиндром");
        }
    }
    else
    {
        return ($"ERROR! {number} - не является пятизначным числом.");
    }
}


Console.WriteLine(isPalindrome(12345));
Console.WriteLine(isPalindrome(12321));

/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным. */


string isWeekend(int number_of_day)
{
    string result = "";
    if (number_of_day >= 1 && number_of_day <= 5)
    {
        result = "нет, это будний день";
    }
    else if (number_of_day == 6 || number_of_day == 7)
    {
        result = "да, это выходной";
    }
    return result;
}


Console.WriteLine(isWeekend(5));

/* Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


void RandArr(int count_elems)
{
    int[] randomArray = new int[count_elems];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0, 100);
        Console.Write(randomArray[i] + " ");
    }


}

RandArr(8);

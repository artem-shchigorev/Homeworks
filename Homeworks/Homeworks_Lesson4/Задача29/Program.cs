﻿//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] printArray ()
{
    int[] array = new int[8];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
        System.Console.Write(array[i] + " ");
    }
    return array;
}
printArray();
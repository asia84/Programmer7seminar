﻿/*Задача 67: Напишите программу, 
которая будет принимать на вход число
 и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.WriteLine("Введите число N: ");    //   это пишем, тогда когда пользователь задает значение
int n = Convert.ToInt32(Console.ReadLine());//
int f (int n)
{
    if(n == 0)
        return 0;
    return f(n/10) + n % 10;
}
//если число должно быть жестко задано, то тут пишем int n = 456
Console.WriteLine ($"Сумма цифр числа {n} = "  + f(n));


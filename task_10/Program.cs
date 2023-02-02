/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();

Console.Write("Введи трёхзначное число: ");

/* Convert.ToInt32 преобразует в int значение любого типа (boolean, double, float и т.д.) */

int a = Convert.ToInt32(Console.ReadLine());
/*  Convert.ToString функция, которая для числа даёт его строковое представление. */

string b = Convert.ToString(a);



if (a < 100 || a > 999) {
    Console.WriteLine("Введено не трёхзначное число");
    
}



else {
Console.WriteLine("вторая цифра этого числа -> "+b[1]);

 }
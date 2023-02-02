/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse (Console.ReadLine());




if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine ("Введён неправильный номер");
    return;
}



if (numberDayOfWeek == 1)
{
    Console.WriteLine("Будний день");
    
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("Будний день");
    
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("Будний день");
    
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("Будний день");
    
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("Будний день");
    
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("Выходной день");
    
}
if (numberDayOfWeek == 7)
{
    Console.WriteLine("Выходной день");
    
}



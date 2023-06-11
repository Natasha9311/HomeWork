/* 

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 


Random rnd = new Random();
int rndNum = rnd.Next(100, 1000);
Console.WriteLine(rndNum);

int a = rndNum;
int res = ((a/10) % 10);


Console.Write(res);


 Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Random rnd = new Random();
int rndNum = rnd.Next(1, 1000);
Console.WriteLine(rndNum);
int a = rndNum % 10;

if(rndNum < 100)
{  
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write(a);
}


Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = {1, 2, 3, 4, 5, 6, 7};




if(N == 7 || N == 6)
{
    Console.Write(" Выходной ");
}
else
{
    Console.Write("Рабочий ");
}







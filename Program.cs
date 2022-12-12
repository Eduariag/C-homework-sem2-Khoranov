//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Input tree-digit num: ");
int num=Convert.ToInt32(Console.ReadLine());

num=num /10 %10;

Console.Write($"Second num: {num}");
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Input number 1 to 7  ");
int num=Convert.ToInt32(Console.ReadLine());

if (num==6 || num==7)
{
    Console.Write("Weekend Yes");
}   
    else
{
    Console.Write("Weekend No");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.*/

/*
int number= int.Parse(Console.ReadLine());
if(number<100)
{
    Console.Write("Third number no");
    return;
}
while(number>999)
{
    number=number/10;
}
Console.WriteLine(number%10);
/*

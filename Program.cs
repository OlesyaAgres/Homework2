// Практическое задание 2 от 11.04.23

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");
double digit = Math.Log10(num);
digit = (int)digit;

if(digit == 2)
{
    int result = num / 10;
    result = result % 10;
    Console.WriteLine("Вторая цифра цифра числа: " + num + " равна: " + result);
}
else
Console.WriteLine ("Введенное число не треёхзначное!!!");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите положительное число");
// char[] digits = Console.ReadLine().ToCharArray();
//  if ( digits.Length > 2)
//  {
//     Console.Write("Третья цифра в числе: ");
//     Console.Write(digits);
//     Console.Write(", равняется: ");
//     Console.WriteLine(digits[2]);
//  }
// else
// {
//        Console.Write("Третья цифра в числе: ");
//     Console.Write(digits);
//     Console.WriteLine(", отсутствует!");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите положительное число");
// int day = int.Parse(Console.ReadLine() ?? "0");
// if (day > 7 || day < 1)
//     Console.WriteLine("Число " + day + " не является днем недели, введите число от 1 до 7! ");
// else
// {   
//     Dictionary<int, string> dayOfWeek = new Dictionary<int, string>
// {
//     { 1, "Понедельник - Рабочий день" },
//     { 2, "Вторник - Рабочий день" },
//     { 3, "Среда - Рабочий день" },
//     { 4, "Четверг - Рабочий день" },
//     { 5, "Пятница - Рабочий день" },
//     { 6, "Суббота - Выходной день" },
//     { 7, "Воскресенье - Выходной день" },
// };
//     Console.WriteLine(dayOfWeek[day]);
// }



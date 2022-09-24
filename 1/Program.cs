// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int namber = Convert.ToInt32(Console.ReadLine()); //конвертируем в численное значение
string namberStr = Convert.ToString(namber);         //преобразуем в строку


if (namberStr.Reverse().SequenceEqual(namberStr)) //.Reverse-перевернули строку; 
                                                  //.SequenceEqual-сравнили(значение перед точкой со значением в скобках)
{
    Console.Write($"{namberStr} ->да");
}
else
{
    Console.Write($"{namberStr} -> нет");
}
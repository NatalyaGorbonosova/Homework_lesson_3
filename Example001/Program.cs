// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Palindrom(int num)
{
    string pal = "";
    int x1 = num / 10000;
    int x2 = (num / 1000) % 10;
    int x4 = (num / 10) % 10;
    int x5 = num % 10;
    if (x1 == x5)
    {
        if(x2 == x4) pal = "Да";
        else pal = "Нет";
    }
    else pal = "Нет";
    return pal;
}
try
{
    Console.Write("Введите пятизначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x >= 10000 && x < 100000) Console.WriteLine(Palindrom(x));
    else Console.WriteLine("Введите число больше 10 000 и меньше 100 000");
}
catch
{
    Console.WriteLine("Введите число");
}


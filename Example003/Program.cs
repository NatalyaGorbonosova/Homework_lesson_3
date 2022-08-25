// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int [] CubeArray(int num)
{
        int [] array = new int[num];
    for (int i = 1; i < num + 1; i++)
    {
        array[i-1] = i*i*i;
    }
    return array;
}
try
{
    Console.WriteLine("Введите целое положительное число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N >= 1) 
    {
        var str = string.Join(" ", CubeArray(N));
        Console.WriteLine(str);
    }
    else Console.WriteLine("Введите целое число больше 0");
}
catch
{
    Console.WriteLine("Введите целое число!");
}
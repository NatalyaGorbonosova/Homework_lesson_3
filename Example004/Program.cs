// Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, пока сумма
//введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.
//Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.
int[] FillArray(int[] array) 
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int SumNull(int [] array)
{
    int sum = array[0];
    int index = 1;
    int result = sum*sum;
    while (sum != 0)
    {
        sum = sum + array[index];
        result = result + array[index]*array[index];
        index++;
    }
    return result;
}
try
{
    Console.Write("Введите количество чисел: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сами числа ");
    int[] Numbers = new int[N];
    Numbers = FillArray(Numbers);
    Console.WriteLine("Сумма: " + SumNull(Numbers));
}
catch
{
    Console.WriteLine("Вводите целые числа");
}


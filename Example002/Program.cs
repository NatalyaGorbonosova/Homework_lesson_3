// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distant3D(double [] arrayA, double [] arrayB) //Находит расстояние между точками
{
    int i = 0;
    int n = arrayA.Length;
    double sum = 0;
    for (i = 0; i < n; i++)
    {
        sum = sum + Math.Pow(arrayB[i] - arrayA[i], 2);
    }
    double dist = Math.Sqrt(sum);
    return Math.Round(dist, 2);
}
double [] FillArray(double [] array) // Задает координаты точек
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = Convert.ToDouble(Console.ReadLine());
        index++;
    }
    return array;
}
try
{ 
double [] ArrayPointA = new double [3];
Console.WriteLine("Введите координаты точки А: ");
ArrayPointA = FillArray(ArrayPointA);

double [] ArrayPointB = new double [3];
Console.WriteLine("Введите координаты точки B: ");
ArrayPointB = FillArray(ArrayPointB);

Console.WriteLine("Расстояние между точками равно: " + Distant3D(ArrayPointA, ArrayPointB));
}
catch
{
    Console.WriteLine("При введении координат используйте числа!!!");
}


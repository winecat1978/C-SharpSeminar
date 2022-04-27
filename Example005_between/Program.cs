// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите любое натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int opposite_num = -num;

Console.WriteLine("между числом " + opposite_num + " и" + num + " находятся следующие целые числа: ");
do
{
    Console.Write(opposite_num + ", ");
    opposite_num = opposite_num + 1;
} while (opposite_num < num);

if (opposite_num == num) Console.WriteLine(" " + opposite_num + ".");
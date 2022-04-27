// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2) 
{ Console.WriteLine(num1 + " является квадратом числа " + num2);
}
else 
Console.WriteLine("Вы ввели какой-то бред");
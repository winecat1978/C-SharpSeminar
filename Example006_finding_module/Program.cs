// Напишите программу вычисления модуля числа.
Console.WriteLine("Введите число, модуль которого хотите найти: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 0) {
    Console.WriteLine("Модуль числа положительного равен самому себе, т.е. модуль числа " + num + " равен " + num);
}
else 
{Console.WriteLine("Модуль числа отрицательного равен числу ему противоположному");
Console.WriteLine("т.е. модуль числа " + num + " равен " + -num);
}
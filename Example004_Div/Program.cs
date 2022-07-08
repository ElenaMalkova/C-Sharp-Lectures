// Написать программу, в которую вводятся два числа и находится частное этих чисел
Console.WriteLine ("Введите положительное число");
double numberA = int.Parse(Console.ReadLine ());
Console.WriteLine ("Введите положительное число");
double numberB = int.Parse(Console.ReadLine ());
double result = numberA / numberB;
Console.WriteLine ("Частное =" + result);
// Написать программу, в которую вводятся два рандомных числа и получается сумма
int numberA = new Random().Next(1,10); //1 2 3 4 ...9
Console.WriteLine( numberA );
int numberB = new Random().Next(1,10);
Console.WriteLine( numberB );
int result = numberA + numberB;
Console.WriteLine ("Cумма=" + result);

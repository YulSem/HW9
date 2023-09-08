// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int lastNumt =1;

// string PrintNumber(int start, int end)
// {
//   if(start==end)
//   {
//     return start.ToString();
//   }
//   return (start + " "+PrintNumber(start-1, end));
// }

// Console.WriteLine(PrintNumber(num,lastNumt));

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// System.Console.WriteLine("Введите число M");
// int num = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Введите число N");
// int num2 = Convert.ToInt32(System.Console.ReadLine());
// if (num < num2)
// {
//     Console.WriteLine(PrintNum(num,num2));
// }
// else
// {
//     System.Console.WriteLine(" Введите число N больше M");
// }

// string PrintNum(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return(start + " " + PrintNum(start+1, end));
// }
// int sum = SumNaturalNumbers(num, num2);
// int SumNaturalNumbers(int num, int num2)
//     {
//         if (num > num2)
//             return 0;
//         else
//             return num + SumNaturalNumbers(num + 1, num2);
//     }
// Console.WriteLine("Сумма чисел "+sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите значение m>0:");
int m = Convert.ToInt32(System.Console.ReadLine());
  
Console.WriteLine("Введите значение n>0:");
int n = Convert.ToInt32(System.Console.ReadLine());
 
int result = Ackermann(m, n);
Console.WriteLine($"Результат функции Аккермана: {result}");
    
int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

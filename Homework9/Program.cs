
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Выведение всех натуральных чисел от  N до 1");
Console.WriteLine();
 Console.WriteLine("Введите натуральное число N > 1");
 int num = Convert.ToInt32(Console.ReadLine());
NumberRec (num);

void NumberRec (int num)
{
    if (num <0)
    {
        Console.Write($"{num} не натуральное");

    }
    if (num == 0) return;
    Console. Write($"{num}, ");
    NumberRec(num -1);
}
Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Нахождение суммы натуральных элементов в промежутке от M до N");
Console.WriteLine();
int numM = SetNumber("ВВедите число M");
int numN = SetNumber("Введите число N");

int SetNumber(string comment)
{
    Console.Write($" {comment}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
 Console.WriteLine($"Сумма элементов равна {SumNumbers(numM,numN)}");
int SumNumbers(int numM, int numN)
{
    if (numM == 0) return (numN* (numN+1))/2;
    else if  (numN == 0) return (numM * (numM+1))/ 2;
    else if (numN == numM) return numN;
    else if (numN > numM) return numN + SumNumbers(numM, numN -1 );
    else return numN + SumNumbers(numM, numN +1 );
}

System.Console.WriteLine();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Функция Аккермана");
Console.WriteLine();
int m = SetNumbers("ВВедите число m > 0 ");
int n = SetNumbers("Введите число n > 0");
AkkermanFunction( m, n);
int SetNumbers(string comment)
{
    Console.Write($" {comment}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


 void AkkermanFunction(int m, int n)
 {
    Console.WriteLine($"Функция Аккермана для чисел {m} и {n} равна {Akkerman(m,n)}");
 }

 int Akkerman(int m, int n)
 {
    if (m==0)
    {
        return n +1;
    }
    else if (n==0 && m>0)
    {
        return Akkerman(m - 1,1);
    }
    else 
    {
        return (Akkerman(m-1, Akkerman(m, n-1)));
    }
 }
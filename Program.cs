// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Привет 281 группа");
// Напишите программу вычисления 
// среднеарифметического 
// из 3 чисел, введенных с клавиатуры
// System.Console.WriteLine("введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("введите третье число");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int avg = (number1+number2+number3)/3;
// System.Console.WriteLine("Среднее значение " +avg);


// Напишите программу, которая на вход принимает два 
// целых числа и проверяет, является ли первое число
// квадратом второго
// 25, 5    да
// 2, 10   нет
// System.Console.Write("введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int sqr = number2*number2;
// if (sqr == number1)
// {
//     System.Console.WriteLine("Да " +sqr);
// }
// else
// {
//     System.Console.WriteLine("Нет " +sqr);
// }

//Задание 2
// Напишите программу, которая будет выдавать 
// // название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

// System.Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if (number==2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else if (number==3)
// {
//     System.Console.WriteLine("Среда");
// }
// else if (number==4)
// {
//     System.Console.WriteLine("Четверг");
// }
// else
// {
//     System.Console.WriteLine("Такого дня не существует");
// }



//Задача 3 
//Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// System.Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int negativNumber = number*-1;
// while (negativNumber<=number)
// {
//     System.Console.Write(negativNumber);
//     if (negativNumber<number)
//     {
//         System.Console.Write(", ");
//     }
//     negativNumber=negativNumber+1;
// }

// Задача 4
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает 
// первую и последнюю цифры этого числа.
// 456 => 4 и 6
// 782 => 7 и 2
// 987 => 9 и 7

// System.Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number>99 && number<1000)
// {
//     int digit1 = number/100;
//     int digit3 = number%10;
//     System.Console.WriteLine("Первая цифра " +digit1);
//     System.Console.WriteLine("Третья цифра" +digit3);
// }
// else
// {
//     System.Console.WriteLine("Неправильно введено число");
// }

//Задача 1
///Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
//Примеры
//a = 256 => 26
//a = 891 => 81

// System.Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number>99 && number<1000)
// {
//     // int digit1 = number/100;
//     // int digit3 = number%10;
//     int result = number/100*10+number%10;
//     System.Console.WriteLine(result);
//     // System.Console.WriteLine("Третья цифра" +digit3);
// }
// else
// {
//     System.Console.WriteLine("Неправильно введено число");
// }



// Задание 1
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

//  System.Console.Write("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int [5];
// bool isfind = false;
// for (int i = 0; i < Array.Length; i++) //i = i+1   i++
// {
//     Array[i] = new Random().Next(0,10); //
//     System.Console.Write(Array[i]+" ");
//     if (Array[i] == number)
//     {
//         isfind = true;
//     }
// }
// System.Console.WriteLine();
// if (isfind == true)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

// int [] array1 = new int [3] {5,8,40};
//int [] array1 = [5,8,40];
// int [] array1 = new int [3];
// array1[0] = 6;
// array1[1]=7;
// array1[2]=38;

// int [] array1 = {5,8,40};
// for (int i = 0; i < array1.Length; i++) //i = i+1   i++
// {
//     System.Console.Write(array1[i]+" ");
// }






// int[] Array = [5, 6, 7];
//int[] Array = new int [3] {5,6,7};
// int[]Array = new int [3];
// Array[0]=5;
// Array[1]=8;
// Array[2]=10;
// for (int i = 0; i < Array.Length; i++) 
// {
  
//     System.Console.Write(Array[i]+" ");
// }




//Задание 2
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// System.Console.Write("Введите количество элементов массива ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int [sizeArray];
// for (int i = 0; i < Array.Length; i++) //i = i+1   i++
// {
//     Array[i] = new Random().Next(-10,11); //
//     System.Console.Write(Array[i]+" ");
// }
// System.Console.WriteLine();
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i]=Array[i]*-1;
//     System.Console.Write(Array[i]+" ");
// }

//Задание 3

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

// System.Console.Write("Введите количество элементов массива ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [sizeArray];
// int[] array2 = new int [sizeArray/2];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,10); //
//     System.Console.Write(array[i]+" ");
// }
// System.Console.WriteLine();
// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = array[i]*array[array.Length-1-i];
//     System.Console.Write(array2[i]+" ");
// }


// Задание 4
// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// System.Console.WriteLine("Введите трехзначное натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [3];
// if (number>99 && number<1000)
// {
//     for (int i = 0; i < array.Length; i++)
// {
//     array[i] = number%10;
//     number = number/10;
//     System.Console.Write(array[i]+" ");
// }
// }
// else
// {
//     System.Console.WriteLine("число введено некорректно");
// }


// // Задайте массив из N случайных целых чисел (N вводится с
// // клавиатуры).
// // Найдите количество чисел, которые оканчиваются на 1 и
// // делятся нацело на 7.
// // Пример
// // [1 5 11 21 81 4 0 91 2 3]
// // => 2

// // тип возвращающего значения + Название + ()+ {}

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10,100);
        System.Console.Write(array[i] + " ");
    }
}

int FindNumber()
{
    int countNumber=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%10 ==1 && array[i]%7 ==0)
        {
            countNumber++;
        }
    }
    return countNumber;
}

PrintArray();
int countNumbers = FindNumber();
System.Console.WriteLine();
System.Console.WriteLine(countNumbers);
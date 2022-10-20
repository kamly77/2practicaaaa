
//Задача 1
//Random rand = new Random();
//int MyNum;
//int secret = rand.Next(1, 101);
//int count = 1;
//Console.WriteLine("Компьютер загадал число от 0 до 100.Попробуйте отгадать");
//while (true)
//{
//    MyNum = int.Parse(Console.ReadLine());
//    if (MyNum == secret)
//    {
//        Console.WriteLine("Угадал,бро");
//        break;
//    }
//    else
//    {
//        if (MyNum > secret)
//        {
//            Console.WriteLine("Меньше,бро");
//        }
//        else
//        {
//            Console.WriteLine("Больше,бро");
//        }
//    }
//}

//Console.ReadKey();


//Задача2
//using System;

//namespace fifteenthMay
//{ 
//    class Program
//    {
//        public static void Main(string[] args)
//        {


//            int[,] arr = new int[10, 10];
//            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//            Console.Write("x/y |\t");
//            for (int i = 0; i < arr1.Length; ++i)
//            {
//                Console.Write(arr1[i] + "\t");
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.Write("---------------------------------------------------------------------");
//            Console.WriteLine();

//            for (int i = 1; i < arr.GetLength(0); ++i)
//            {
//                for (int j = 1; j < arr.GetLength(1); ++j)
//                {

//                    int sum = i * j;
//                    if (i == j)
//                    {
//                        arr[i, j] = sum;
//                        Console.Write(arr[i, j] + "\t");
//                    }
//                    else if (i > j)
//                    {
//                        arr[i, j] = sum;
//                        Console.Write(arr[i, j] + "\t");
//                    }
//                    else if (i < j)
//                    {
//                        arr[i, j] = sum;
//                        Console.Write(arr[i, j] + "\t");
//                    }

//                }
//                Console.WriteLine("\n\n");
//            }


//            Console.Write("Press any key to continue . . . ");
//            Console.ReadKey(true);
//        }
//    }

//}


//using System;

//Задача 3
//public class Test
//{
//    public static void Main()
//    {
//        Console.Write("Введите число ");
//        int num = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= num; i++)
//            if (num % i == 0)
//                Console.WriteLine("Число {0} делится без остатка на {1}", num, i);

//        Console.ReadKey();
//    }
//}

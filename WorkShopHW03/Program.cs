using System;

namespace WorkShopHW03ex1
{
    internal class Program
    {
        static int DivideByTwo(int num)
        {
            return num / 2;
        }

        static void ShowArgumentException(ArgumentException e)
        {
            try
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Исключение ArgumentException");

                if ((7 & 1) == 1)
                    throw e;
                int Number = DivideByTwo(7);

                Console.WriteLine(Number.ToString());
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("----------------------------");
            }
        }

        static void ShowDivideByZeroException(DivideByZeroException e)
        {
            try
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Исключение DivideByZeroException");

                int d = 0;
                int Number = 7 / d;

                Console.WriteLine(Number.ToString());
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("----------------------------");
            }
        }

        static void ShowIndexOutOfRangeException(IndexOutOfRangeException e)
        {
            try
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Исключение IndexOutOfRangeException");

                int[] intArray = new int[3] { 9, 8, 4 };
                Console.WriteLine(intArray[intArray.Length + 2].ToString());
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("----------------------------");
            }
        }

        static void ShowNullReferenceException(NullReferenceException e)
        {
            try
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Исключение NullReferenceException");
                Exception ex = new Exception("Error");

                ex = null;
                if (ex == null)
                    throw e;
                else
                    Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("----------------------------");
            }
        }

        static void ShowNullReferenceException(InputDataUserException e)
        {
            try
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Исключение InputDataUserException");

                Console.WriteLine("Нажмите цифру 1 или 2");
                int UserNumber = Convert.ToInt32(Console.ReadLine());

                if (UserNumber == 1 || UserNumber == 2)
                    Console.WriteLine($"Спасибо, что нажали цифру: {UserNumber}");
                else
                    throw e;
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("----------------------------");
            }
        }

        static void Main(string[] args)
        {
            ArgumentException ae = new ArgumentException("Ошибка ArgumentException");
            DivideByZeroException db = new DivideByZeroException("Ошибка деления на 0");
            IndexOutOfRangeException ior = new IndexOutOfRangeException("Ошибка определения границ массива/списка");
            NullReferenceException nr = new NullReferenceException("Ошибка создания объекта");
            InputDataUserException idu = new InputDataUserException("Введите/выберите корректное значение");

            Exception[] arrayException = new Exception[5] { ae, db, ior, nr, idu };

            ShowArgumentException(arrayException[0] as ArgumentException);
            ShowDivideByZeroException(arrayException[1] as DivideByZeroException);
            ShowIndexOutOfRangeException(arrayException[2] as IndexOutOfRangeException);
            ShowNullReferenceException(arrayException[3] as NullReferenceException);
            ShowNullReferenceException(arrayException[4] as InputDataUserException);

            Console.ReadKey();


        }
    }
}

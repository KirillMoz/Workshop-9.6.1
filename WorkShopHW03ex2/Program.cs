using System;
using WorkShopHW03ex1;

namespace WorkShopHW03ex2
{
    class Program
    {
        static void ShowData(int Data)
        {
            string DescriptionSort = "по - убыванию";
            if (Data == 2)
                DescriptionSort = "по - возрастанию";

            Console.WriteLine($"Введено значение {Data}. Массив будет от сортирован {DescriptionSort} ");
        }

        static void ShowSort()
        {
            Console.WriteLine("Массив отсортирован");
        }
        static void Main(string[] args)
        {
            int Number = 0;
            string[] ArrSurnames = new string[5] { "Баринов", "Алексеев", "Давыдов", "Ваенга", "Есенин" };
            ArrayController<string> control = new ArrayController<string>(ArrSurnames);
            control.SortComleted += ShowSort;
            Console.WriteLine("Исходный массив:");
            control.Print();
            ReadController Rc = new ReadController();
            Rc.DataEnterEvent += ShowData;
            do
            {
                try
                {
                    Number = Rc.Read();
                    switch (Number)
                    {
                        case 1:
                            control.TypeSort = SortType.stUp; break;
                        case 2:
                            control.TypeSort = SortType.stDown; break;
                    }
                    control.Print();
                }
                catch (InputDataUserException)
                {
                    Console.WriteLine($"Введено некорректное значение");
                }
            }
            while (true);

            Console.ReadKey();
        }
    }
}

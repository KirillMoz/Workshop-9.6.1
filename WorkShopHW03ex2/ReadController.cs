using System;
using WorkShopHW03ex1;

namespace WorkShopHW03ex2
{
    public class ReadController
    {
        public delegate void EnterData(int Data);
        public event EnterData DataEnterEvent;
        public int Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2)
                throw new InputDataUserException("Введено неверное значение!");
            DataEntered(number);
            return number;
        }

        protected virtual void DataEntered(int Data)
        {
            DataEnterEvent?.Invoke(Data);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopHW03ex2
{
    public class ArrayController<T>
    {
        private T[] FArray;
        private SortType FSortType = SortType.stNone;

        public delegate void SortNotify();
        public event SortNotify SortComleted;

        public ArrayController(T[] arr)
        {
            FArray = new T[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                FArray[i] = arr[i];
        }

        public SortType TypeSort
        {
            get
            {
                return FSortType;
            }
            set
            {
                FSortType = value;
                Sort(value);
            }

        }

        protected virtual void OnSorted()
        {
            SortComleted?.Invoke();
        }

        private void Sort(SortType Type)
        {
            switch (Type)
            {
                case SortType.stDown:
                    {
                        Array.Sort<T>(FArray);
                        break;
                    }
                case SortType.stUp:
                    {
                        Array.Sort<T>(FArray);
                        Array.Reverse(FArray);
                        break;
                    }
                case SortType.stNone:
                    {
                        break;
                    }
            }
            OnSorted();
        }

        public void Print()
        {
            for (int i = 0; i < FArray.Length; i++)
                Console.WriteLine(FArray[i].ToString());
        }



    }
}

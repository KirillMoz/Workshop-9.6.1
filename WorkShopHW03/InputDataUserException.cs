using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopHW03ex1
{
    public class InputDataUserException : Exception
    {
        public InputDataUserException(string DesciptionError) : base(DesciptionError) { }
        public InputDataUserException() : base() { }
    }
}

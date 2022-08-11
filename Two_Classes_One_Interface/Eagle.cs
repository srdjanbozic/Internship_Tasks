using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Classes_One_Interface
{
    class Eagle : IWings
    {
        public string WingsFlapBySecond()
        {
            return "5-10";
        }
    }
}

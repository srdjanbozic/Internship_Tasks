using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Classes_One_Interface
{
    class Butterfly : IWings
    {
        public string WingsFlapBySecond()
        {
            return "20-30";
        }
    }
}

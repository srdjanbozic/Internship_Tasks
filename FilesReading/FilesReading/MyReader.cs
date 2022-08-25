using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReading
{
    internal class MyReader
    {
        private readonly StreamReader _streamReader;
        public MyReader(StreamReader sr)
        {
            _streamReader = sr;
        }
    }
}

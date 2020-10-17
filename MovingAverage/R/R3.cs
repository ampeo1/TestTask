using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.R
{
    class R3: IR
    {
        private byte data;
        public R3(List<byte> inputList)
        {
            data = inputList.Max();
        }

        public byte GetData()
        {
            return data;
        }
    }
}

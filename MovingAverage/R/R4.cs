using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.R
{
    class R4: IR
    {
        private byte data;
        public R4(List<byte> inputList)
        {
            data = inputList.Min();
        }

        public byte GetData()
        {
            return data;
        }
    }
}

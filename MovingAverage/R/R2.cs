using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Statistics.R
{
    class R2: IR
    {
        private byte data;
        public R2(List<byte> inputList)
        {
            int result = 1;
            foreach(byte input in inputList)
            {
                result *= input;
            }
            data = (byte)(result % 255);
        }

        public byte GetData()
        {
            return data;
        }

    }
}


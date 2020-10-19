using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Statistics.R
{
    public class R2: IR
    {
        private byte value;
        public byte Value
        {
            get
            {
                return value;
            }
        }
        public R2(List<byte> inputList)
        {
            int result = 1;
            foreach(byte input in inputList)
            {
                result *= input;
            }
            value = (byte)(result % 255);
        }

    }
}


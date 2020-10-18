using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.R
{
    class R3: IR
    {
        private byte value;
        public byte Value
        {
            get
            {
                return value;
            }
        }
        public R3(List<byte> inputList)
        {
            value = inputList.Max();
        }
    }
}

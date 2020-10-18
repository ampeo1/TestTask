using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Statistics.R
{
    internal class R1: IR
    {
        private byte value;
        public byte Value
        {
            get
            {
                return value;
            }
        }
        public R1(List<byte> input)
        {
            value = (byte)(input.Sum(x => x) % 255);
        }
      
    }
}

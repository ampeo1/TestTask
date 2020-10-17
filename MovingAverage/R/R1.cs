using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Statistics.R
{
    internal class R1: IR
    {
        private byte data;
        public R1(List<byte> input)
        {
            data = (byte)(input.Sum(x => x) % 255);
        }

        public byte GetData()
        {
            return data;
        }
      
    }
}

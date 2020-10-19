﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.R
{
    public class R4: IR
    {
        private byte value;
        public byte Value
        {
            get
            {
                return value;
            }
        }
        public R4(List<byte> inputList)
        {
            value = inputList.Min();
        }
    }
}

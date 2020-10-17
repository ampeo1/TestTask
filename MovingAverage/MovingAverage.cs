using Statistics.R;
using System;
using System.Collections.Generic;

namespace Statistics
{
    public static class MovingAverage
    {
        private static List<IR> getR()
        {
            List<byte[]> list = Data.GetFileData();
            List<IR> output = new List<IR>();
            foreach(byte[] data in list)
            {
                List<byte> row = new List<byte>(data);
                byte key = row[0];
                row.RemoveAt(0);
                switch ((TypeR)key)
                {
                    case TypeR.R1:
                        output.Add(new R1(row));
                        break;
                    case TypeR.R2:
                        output.Add(new R2(row));
                        break;
                    case TypeR.R3:
                        output.Add(new R3(row));
                        break;
                    case TypeR.R4:
                        output.Add(new R4(row));
                        break;

                }
            }
            return output;
        }

        public static void getMovingAverage()
        {
            List<IR> rs = getR();
            foreach(IR r in rs)
            {
                Console.WriteLine(r.GetData());
            }
        }
    }
}

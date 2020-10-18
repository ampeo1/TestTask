using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics.R
{
    class ContainerR
    {
        private List<IR> rs = new List<IR>();
        public List<IR> Rs 
        {
            get
            {
                return rs;
            }
        }

        public ContainerR()
        {
            List<byte[]> list = Data.GetFileData();
            foreach (byte[] data in list)
            {
                List<byte> row = new List<byte>(data);
                byte key = row[0];
                row.RemoveAt(0);
                switch ((TypeR)key)
                {
                    case TypeR.R1:
                        rs.Add(new R1(row));
                        break;
                    case TypeR.R2:
                        rs.Add(new R2(row));
                        break;
                    case TypeR.R3:
                        rs.Add(new R3(row));
                        break;
                    case TypeR.R4:
                        rs.Add(new R4(row));
                        break;

                }
            }
        }

    }
}

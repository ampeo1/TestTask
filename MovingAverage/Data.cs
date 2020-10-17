using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Statistics
{
    public static class Data
    { 
        /*
         * 1. Построчно считывает данные из файла 
         * 2. Строку конвертируем в массив byte
         * 3. Повторяем 1 2 пока не дойдём до конца файла
         */
        public static List<byte[]> GetFileData()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "//TestData");
            FileInfo fileInfo = directoryInfo.GetFiles("test.txt").First();
            List<byte[]> data = new List<byte[]>();
            using (StreamReader fstream = new StreamReader(fileInfo.FullName))
            {
                string input = "";
                while(input != null)
                {
                    input = fstream.ReadLine();
                    if(input == null)
                    {
                        break;
                    }
                    data.Add(Array.ConvertAll(input.Split(' '), byte.Parse));
                }
            }
            return data;
        }
    }
}

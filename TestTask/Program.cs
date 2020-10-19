using System;
using System.Collections.Generic;
using Statistics;
using Statistics.R;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte[]> inputList = Data.GetFileData(Data.getDefaultPath(), "test.txt");
            ContainerR container = new ContainerR(inputList);
            List<float> list = MovingAverage.getMovingAverage(5, container);
            foreach(float item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

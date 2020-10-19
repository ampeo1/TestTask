using Statistics.R;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public static class MovingAverage
    {

        public static List<float> getMovingAverage(int window, ContainerR container)
        {
            if(window % 2 == 0 || window < 3 || window > 1000001)
            {
                throw new ArgumentException("1.The window must be odd \n 2.Should belong [3, 1000001]");
            }
            if(container.Rs.Count == 0)
            {
                throw new ArgumentException("Container is empty");
            }
            List<float> output = new List<float>();
            int i, leftRange, rightRange;
            float result, halfWindow, sizeWindow = 1, previousWindow;
            halfWindow = (window - 1) / 2;
            output.Add(container.Rs[0].Value);
            for(i = 1; i < container.Rs.Count; i++)
            {
                if(i <= halfWindow)
                {
                    previousWindow = sizeWindow;
                    rightRange = i * 2;
                    sizeWindow = rightRange + 1;
                    result = previousWindow * output[i - 1]/ sizeWindow + container.Rs[rightRange - 1].Value / sizeWindow + container.Rs[rightRange].Value / sizeWindow;
                }
                else if(i + halfWindow >= container.Rs.Count)
                {
                    previousWindow = sizeWindow;
                    leftRange = i - container.Rs.Count + 1 + i;
                    rightRange = container.Rs.Count - 1;
                    sizeWindow = rightRange - leftRange + 1;
                    result = (previousWindow * output[i - 1]) / sizeWindow - container.Rs[leftRange - 1].Value / sizeWindow - container.Rs[leftRange - 2].Value / sizeWindow;
                }
                else{
                    leftRange = i - (int)halfWindow;
                    rightRange = i + (int)halfWindow;
                    sizeWindow = window;
                    result = output[i - 1] - container.Rs[leftRange - 1].Value / sizeWindow + container.Rs[rightRange].Value / sizeWindow;
                }
                output.Add(result); 
            }

            return output;
        }
    }
}

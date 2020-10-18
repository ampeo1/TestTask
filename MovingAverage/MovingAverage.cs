using Statistics.R;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public static class MovingAverage
    {

        public static List<float> getMovingAverage(int window)
        {
            if(window % 2 == 0 && window >= 2)
            {
                throw new ArgumentException("the window must be odd");
            }
            ContainerR container = new ContainerR();
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistics;
using Statistics.R;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGetFileData()
        {
            List<byte[]> inputList = Data.GetFileData(@"D:\C#\TestTask\UnitTest\TestFile", "test1.txt");
            List<byte[]> outputList = new List<byte[]> { new byte[]{ 1, 2, 3, 4, 5 }, new byte[] { 2, 57, 34, 123, },
                                                            new byte[]{ 233, 124, 255 } };
            Assert.IsTrue(inputList[0].SequenceEqual(outputList[0]));
            Assert.IsTrue(inputList[0].SequenceEqual(outputList[0]));
            Assert.IsTrue(inputList[0].SequenceEqual(outputList[0]));
        }

        [TestMethod]
        public void TestEmptyGetFileData()
        {
            List<byte[]> inputList = Data.GetFileData(@"D:\C#\TestTask\UnitTest\TestFile", "empty.txt");
            List<byte[]> outputList = new List<byte[]>();
            Assert.IsTrue(inputList.SequenceEqual(outputList));
        }

        [TestMethod]
        public void TestContainer()
        {
            List<byte[]> list = new List<byte[]> { new byte[] { 1, 5, 6}, new byte[] { 2, 8, 6, 5}, new byte[] { 3, 6, 7, 8, 7, 5, 5 },
                new byte[]{4, 6, 7, 8, 7, 5, 5 } };
            ContainerR container = new ContainerR(list);
            Assert.AreEqual(container.Rs[0].Value, 11);
            Assert.AreEqual(container.Rs[1].Value, 240);
            Assert.AreEqual(container.Rs[2].Value, 8);
            Assert.AreEqual(container.Rs[3].Value, 5);
        }

        [TestMethod]
        public void TestEmptyContainer()
        {
            List<byte[]> list = new List<byte[]>();
            ContainerR container = new ContainerR(list);
            Assert.IsTrue(container.Rs.SequenceEqual(new List<IR>()));
        }

        [TestMethod]
        public void TestMovingAverage()
        {
            List<IR> rs = new List<IR>() {new R3(2), new R3(5), new R3(3), new R3(1), new R3(6), new R3(8), new R3(7), new R3(2), 
                                            new R3(1), new R3(10)};
            ContainerR container = new ContainerR();
            container.Rs = rs;
            int window = 5;
            List<float> result = MovingAverage.getMovingAverage(window, container);
            List<float> output = new List<float> { 2.0f, 3.33333325f, 3.4f, 4.6f, 5f, 4.8f, 4.8f, 5.60000038f, 4.333334f, 10.0000019f };
            Assert.IsTrue(result.SequenceEqual(output));
        }
    }
}

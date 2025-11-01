using Tyuiu.DunaizevAO.Sprint4.Task5.V15.Lib;

namespace Tyuiu.DunaizevAO.Sprint4.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] a = { { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 } };
            int b = 75;
            var res = ds.Calculate(a);
            Assert.AreEqual(b, res);
        }
    }
}

using Tyuiu.DunaizevAO.Sprint4.Task4.V12.Lib;

namespace Tyuiu.DunaizevAO.Sprint4.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] a = { { 3, 6, 6, 8, 8 }, { 2, 7, 2, 4, 6 }, { 3, 6, 2, 6, 4 }, { 8, 6, 2, 7, 3 }, { 5, 2, 4, 2, 3 } };
            int[,] b = { { 3, 1, 1, 1, 1 }, { 1, 7, 1, 1, 1 }, { 3, 1, 1, 1, 1 }, { 1, 1, 1, 7, 3 }, { 5, 1, 1, 1, 3 } };
            var res = ds.Calculate(a);
            Assert.AreEqual(b, res);
        }
    }
}

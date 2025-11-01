using Tyuiu.DunaizevAO.Sprint4.Task2.V11.Lib;

namespace Tyuiu.DunaizevAO.Sprint4.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
            int b = 90;
            var res = ds.Calculate(a);
            Assert.AreEqual(b, res);
        }
    }
}

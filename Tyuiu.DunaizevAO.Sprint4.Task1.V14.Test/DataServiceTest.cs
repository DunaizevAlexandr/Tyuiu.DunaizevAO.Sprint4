using Tyuiu.DunaizevAO.Sprint4.Task1.V14.Lib;

namespace Tyuiu.DunaizevAO.Sprint4.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 };
            int b = 18;
            var res = ds.Calculate(a);
            Assert.AreEqual(b, res);
        }
    }
}

using Tyuiu.DunaizevAO.Sprint4.Task0.V8.Lib;

namespace Tyuiu.DunaizevAO.Sprint4.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int b = 10584;
            var res = ds.GetMultEvenArrEl(a);
            Assert.AreEqual(b, res);
        }
    }
}

using Tyuiu.DunaizevAO.Sprint4.Task7.V4.Lib;

namespace Tyuiu.DunaizevAO.Sprint4.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 3;
            int b = 4;
            string c = "382976421897";
            int wait = 29;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}

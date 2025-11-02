using Tyuiu.DunaizevAO.Sprint4.Task6.V22.Lib;

namespace Tyuiu.DunaizevAO.Sprint4.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] a = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            string[] b = { "Снег", "Град", "Туча" };
            var res = ds.Calculate(a);
            Assert.AreEqual(a, res);
        }
    }
}

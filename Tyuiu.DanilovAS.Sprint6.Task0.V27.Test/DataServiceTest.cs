using Tyuiu.DanilovAS.Sprint6.Task0.V27.Lib;

namespace Tyuiu.DanilovAS.Sprint6.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int x = 4;
            double res = ds.Calculate(x);
            double wait = -6.0; 
            Assert.AreEqual(wait, res);
        }
    }
}
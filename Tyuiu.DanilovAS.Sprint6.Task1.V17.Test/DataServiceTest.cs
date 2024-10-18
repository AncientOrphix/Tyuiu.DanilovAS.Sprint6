using Tyuiu.DanilovAS.Sprint6.Task1.V17.Lib;

namespace Tyuiu.DanilovAS.Sprint6.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {4.34,4.16,3.71,3.27,2.93,2.50,0.71,-47.61,55.15,45.17,14.97 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
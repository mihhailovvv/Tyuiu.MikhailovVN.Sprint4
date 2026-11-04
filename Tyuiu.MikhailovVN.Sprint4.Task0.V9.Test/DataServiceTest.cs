
using Tyuiu.MikhailovVN.Sprint4.Task0.V9.Lib;
namespace Tyuiu.MikhailovVN.Sprint4.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Исходные данные из задания
            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            // Ожидаемый результат (4 + 6 + 2 + 8 + 4 + 6 + 8 = 38)
            int expected = 38;

            // Получение фактического значения из метода
            int actual = ds.GetSumEvenArrEl(numsArray);

            // Проверка на равенство
            Assert.AreEqual(expected, actual);s
        }
    }
}

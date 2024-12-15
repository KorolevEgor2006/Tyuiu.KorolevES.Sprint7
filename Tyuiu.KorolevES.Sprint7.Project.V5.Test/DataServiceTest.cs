using Tyuiu.KorolevES.Sprint7.Project.V5.Lib;
namespace Tyuiu.KorolevES.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidLoadFile()
        {
            string path = $@"C:\Users\Admin\source\repos\Tyuiu.KorolevES.Sprint7\Tyuiu.KorolevES.Sprint7.Project.V5.Test\bin\Debug\net8.0\Test.csv";
            string[,] wait = new string[,] { { "5", "4", "3","2","5" }, {"1", "24","des","tv","sc" },{"3","6","2","8","3"} };
            string[,] res = new string[ds.LoadFromFile(path).GetLength(0),ds.LoadFromFile(path).GetLength(1)];
            res=ds.LoadFromFile(path);
            CollectionAssert.AreEqual(wait,res);
        }
    }
}
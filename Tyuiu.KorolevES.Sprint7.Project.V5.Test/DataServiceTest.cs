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
            string[,] wait = new string[,] { { "5", "4", "3","2","5","-","-","-","-" }, {"1", "24","des","tv","sc", "-", "-", "-", "-" },{"3","6","2","8","3", "-", "-", "-", "-" } };
            string[,] res = new string[ds.LoadFromFile(path).GetLength(0),ds.LoadFromFile(path).GetLength(1)];
            res=ds.LoadFromFile(path);
            CollectionAssert.AreEqual(wait,res);
        }
        [TestMethod]
        public void ValidMassFilterGive() 
        {
            string[,] matrix = new string[,] { { "5", "4", "3", "2", "5" }, { "1", "24", "des", "tv", "sc" }, { "3", "6", "2", "8", "3" } };
            int column = 0;
            string[] wait = new string[] { "5", "1","3"};
            string[] res = new string[3];
            res = ds.MassFilterGive(matrix, column);
            CollectionAssert.AreEqual(wait,res);
        }
        [TestMethod]
        public void ValidAddElement() 
        {
            string[,] matrix = new string[,] { { "5", "4", "3", "2", "5", "-", "-", "-", "-" }};
            string[] data = new string[] { "5", "4", "3", "2", "5", "-", "-", "-", "-" };
            string[,] wait = new string[,] { { "5", "4", "3", "2", "5", "-", "-", "-", "-" }, { "5", "4", "3", "2", "5", "-", "-", "-", "-" } };
            string[,] res = new string[ds.AddProduct(matrix, data).GetLength(0), ds.AddProduct(matrix, data).GetLength(1)];
            res = ds.AddProduct(matrix, data);
            CollectionAssert.AreEqual(wait,res);
        }
        [TestMethod]
        public void ValidEditElement()
        {
            string[,] matrix = new string[,] { { "5", "4", "3", "2", "5", "-", "-", "-", "-" } };
            string[] data = new string[] { "5", "3", "3", "2", "5", "-", "-", "-", "-" };
            int nrow = 0;
            string[,] wait = new string[,] { { "5", "3", "3", "2", "5", "-", "-", "-", "-" }};
            string[,] res = new string[ds.EditProduct(matrix, data,nrow).GetLength(0), ds.EditProduct(matrix, data,nrow).GetLength(1)];
            res = ds.EditProduct(matrix, data,nrow);
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidDeleteElement()
        {
            string[,] matrix = new string[,] { { "5", "4", "3", "2", "5", "-", "-", "-", "-" } };
            int nrow = 0;
            string[,] wait = new string[,] {};
            string[,] res = new string[ds.DeleteProduct(matrix, nrow).GetLength(0), ds.DeleteProduct(matrix, nrow).GetLength(1)];
            res = ds.DeleteProduct(matrix, nrow);
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidSaveFromfile() 
        {
            string path = $@"C:\Users\Admin\source\repos\Tyuiu.KorolevES.Sprint7\Tyuiu.KorolevES.Sprint7.Project.V5.Test\bin\Debug\net8.0\Test2.csv";
            string[,] matrix = new string[,] { { "5", "4", "3", "2", "5", "-", "-", "-", "-" }, { "1", "24", "des", "tv", "sc", "-", "-", "-", "-" }, { "3", "6", "2", "8", "3", "-", "-", "-", "-" } };
            bool wait = true;
            string pathres = ds.SaveFromFile(matrix, path);
            FileInfo file = new FileInfo(pathres);
            bool res = file.Exists;
            Assert.AreEqual(wait, res);
        }

    }
}
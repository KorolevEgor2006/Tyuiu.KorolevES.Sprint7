using System.IO;
namespace Tyuiu.KorolevES.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public string[,] LoadFromFile(string path)
        {

            string file = File.ReadAllText(path);
            file = file.Replace('\n','\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = 9;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] liner = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    if (j < liner.Length)
                    {
                        matrix[i, j] = liner[j];
                    }
                    else 
                    {
                        matrix[i, j] = "-";
                    }
                }
            }
            return matrix;
        }
        public string[,] AddProduct(string[,] mass, string[] data) 
        {
            int rows = mass.GetLength(0);
            string[,] res = new string[rows + 1, 9];
            for(int i =0; i < rows; i++) 
            {
                for(int j=0; j < 9; j++) 
                {
                    res[i, j] = mass[i, j];
                }
            }
            for (int i = 0;i < 9; i++) 
            {
                res[rows,i]= data[i];
            }
            return res;
        }
    }
}

using System.IO;
using System.Xml;
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
        public string[,] EditProduct(string[,] mass, string[] data,int id)
        {
            int rows = mass.GetLength(0);
            string[,] res = new string[rows , 9];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    res[i, j] = mass[i, j];
                }
            }
            for (int i = 0; i < 9; i++)
            {
                res[id, i] = data[i];
            }
            return res;
        }
        public string[,] DeleteProduct(string[,] mass, int id)
        {
            
            int rows = mass.GetLength(0);
            string[,] res = new string[rows-1, 9];
            int ii = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i != id)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        res[ii, j] = mass[i, j];
                    }
                    ii++;
                }
                
            }
            return res;
        }
        public string SaveFromFile(string[,] matrix,string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists) 
            {
                File.Delete(path);
            }
            string line;
            for(int i = 0;i < matrix.GetLength(0); i++) 
            {
                line = "";
                for(int j =0;j < matrix.GetLength(1); j++) 
                {
                    line += matrix[i,j].ToString();
                    if (j != matrix.GetLength(1)-1)line += ";";
                }
                File.AppendAllText(path, line);
                if (i < matrix.GetLength(0) - 1) File.AppendAllText(path,Environment.NewLine);
            }
            return path;
        }
        public string[] MassFilterGive(string[,] matrix,int numcolumn) 
        {
            string[] res = new string[matrix.GetLength(0)];
            int ii= 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (!(res.Contains(matrix[i, numcolumn])))
                {
                    res[ii] = matrix[i, numcolumn];
                    ii++;
                }
            }
            string[] result = new string[ii];
            for (int i = 0; i < ii; i++) 
            {
                result[i]=res[i];
            }
            return result;
        }
    }
}

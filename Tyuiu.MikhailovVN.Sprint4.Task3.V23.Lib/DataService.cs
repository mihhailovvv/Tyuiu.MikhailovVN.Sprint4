
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MikhailovVN.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int lines = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DunaizevAO.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i,j] % 2 == 0)
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LavrentevVA.Sprint5.Task2.V23.Lib
{
    public class DataService : ISprint5Task2V23
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль. 7; 2; 8 6; 9; 1 2; 3; 5 Название проектов (консольного приложения, библиотеки классов, тестового модуля) оформить по шаблону в соответствии с вариантом. Интерфейс консольного приложения оформить по шаблону. Для составления пути используйте Path.Combine() (не слеши) Директорию берите через Path.GetTempPath() Или, чтобы не составлять путь можно использовать  Path.GetTempFileName(), он сразу создает файл с случайным именем в темп папке
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo FileInfo = new FileInfo(path);
            bool fileExists = FileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;  

            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                    line += matrix[i, j].ToString();
                    if (j < columns - 1)
                    {
                        line += ";";
                    }
                }
                File.AppendAllText(path, line + "\n");
            }
            return path;





        }
    }
}

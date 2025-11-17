using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.LavrentevVA.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            // Дан файл С:\DataSprint5\InPutDataFileTask6V3.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор символьных данных. Найти количество латинских букв в заданной строке. 
            string content = File.ReadAllText(path);
            int count = 0;
            foreach (char c in content)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

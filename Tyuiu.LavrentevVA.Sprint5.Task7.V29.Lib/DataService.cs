using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavrentevVA.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            //Дан файл С:\DataSprint5\InPutDataFileTask7V29.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор символьных данных.Удалить все однозначные числа из файла.Полученный результат сохранить в файл OutPutDataFileTask7V29.txt. 
            string pathsaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V29.txt";
            string content = File.ReadAllText(path);
            string result = Regex.Replace(content, @"\b\d\b", "");
            File.WriteAllText(pathsaveFile, result);
            return pathsaveFile;



        }
    }
}
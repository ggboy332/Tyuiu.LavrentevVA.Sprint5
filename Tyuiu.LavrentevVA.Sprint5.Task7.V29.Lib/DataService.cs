using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavrentevVA.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Directory.GetCurrentDirectory(), "OutPutDataFileTask7V29.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string processedLine = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] >= '0' && line[i] <= '9') &&
                            (i + 1 == line.Length || line[i + 1] == ' ' || line[i + 1] == '\t') &&
                            (i == 0 || line[i - 1] == ' ' || line[i - 1] == '\t'))
                        {
                            continue;
                        }
                        else
                        {
                            processedLine += line[i];
                        }
                    }
                    strLine += processedLine + Environment.NewLine;
                }

                File.AppendAllText(pathSaveFile, strLine);
            }
            return pathSaveFile;
        }
    }
}
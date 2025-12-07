using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BalinVV.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7

    {
        public string LoadDataAndSave(string path)
        {

            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V7.txt" });

            FileInfo f = new FileInfo(path2);
            if (f.Exists)
            {
                File.Delete(path2);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string inputText = reader.ReadToEnd();


                string outputText = Regex.Replace(inputText, @"[А-Я]", "");
                return outputText;

            }
        }
    }
}

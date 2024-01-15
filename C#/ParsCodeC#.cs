using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void CodeCShParser(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                string code = File.ReadAllText(fileInfo.FullName);
                code = ReplacePublicWithPrivate(code);
                code = ReplaceLowercaseWithUppercase(code);
                code = RemoveExtraSpacesAndTabs(code);
                string reverse = ReverseCode(code);

                File.WriteAllText(fileInfo.DirectoryName + "\\Output.cs", reverse);
                Console.WriteLine($"Код находиться в папке: {fileInfo.Directory}\\Output.cs" );
            }
            else
            {
                Console.WriteLine("Файл не существует");
            }
        }

        static string ReplacePublicWithPrivate(string code)
        {
            code = Regex.Replace(code, @"public(\s+\w+\s+\w+)\s*;", "private$1;");
            return code;
        }
        static string ReplaceLowercaseWithUppercase(string code)
        {
            code = Regex.Replace(code, @"\b\w{3,}\b", match => match.Value.ToLower());
            return code;
        }
        static string RemoveExtraSpacesAndTabs(string code)
        {
            code.Replace(" ", "\t");
            code = Regex.Replace(code, @"[\s]+", " ");
            return code;
        }
        static string ReverseCode(string code)
        {
            char[] chars = code.ToCharArray();
            Array.Reverse(chars);
            code = new string(chars);
            return code;
        }

        static void Main()
        {
            string nameFile = "Warrior_Squad.cs";

            CodeCShParser($"D:\\VS Studio\\ConsoleApp1\\{nameFile}");
        }

    }
}

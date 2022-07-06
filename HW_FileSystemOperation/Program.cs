using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HW_FileSystemOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _currentPath = Directory.GetCurrentDirectory();
            DirectoryInfo _dir = new DirectoryInfo(_currentPath);
            string _fileName1 = "NEW", _fileName2 = " Other";
            _dir.CreateSubdirectory(_fileName1);
            _dir.CreateSubdirectory(_fileName2);
            var createTime1 = Directory.GetCreationTime(_fileName1);
            var createTime2 = Directory.GetCreationTime(_fileName2);
            string pathNew = _currentPath + @"\"+ _fileName1 + @"\dirinfoN.txt";
            string pathOther = _currentPath + @"\" + _fileName2 + @"\dirinfoO.txt";
            using (StreamWriter sw = File.CreateText(pathNew))
                sw.WriteLine(createTime1);
            using (StreamWriter sw = File.CreateText(pathOther))
                sw.WriteLine(createTime2);
            Console.WriteLine("Создан подкаталог {0} и в файл dirinfoN.txt помещено время создания каталога.", _fileName1 );
            Console.WriteLine("Создан подкаталог {0} и в файл dirinfoO.txt помещено время создания каталога.", _fileName2 );
        }
    }
}

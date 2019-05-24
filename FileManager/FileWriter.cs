using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class FileWriter
    {

        private string FilePath { get; set; }

        public FileWriter(string filePath)
        {
            FilePath = filePath;
        }

        public void WriteData(string[] linesArray)
        {
            File.WriteAllLines(FilePath, linesArray);
        }

        public void WriteData(List<string> lines)
        {
            File.WriteAllLines(FilePath, lines);
        }
    }
}

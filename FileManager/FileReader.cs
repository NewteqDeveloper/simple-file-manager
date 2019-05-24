using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class FileReader
    {
        private string[] FileData { get; set; }
        public int CurrentIndex { get; set; }
        public bool IsFileComplete { get; set; }
        public int MaxLength { get; set; }

        public FileReader(string filePath)
        {
            FileData = File.ReadAllLines(filePath);
            CurrentIndex = 0;
            MaxLength = FileData.Length;
            IsFileComplete = false;
        }

        public string GetNextLine()
        {
            var result = FileData[CurrentIndex];
            CurrentIndex++;
            ValidateComplete();
            return result;
        }

        private void ValidateComplete()
        {
            if (CurrentIndex == MaxLength)
            {
                IsFileComplete = true;
            }
            else
            {
                IsFileComplete = false;
            }
        }

        public string[] SpiltNextLine(char delim)
        {
            var result = FileData[CurrentIndex].Split(delim);
            CurrentIndex++;
            ValidateComplete();
            return result;
        }

        public string GetLine(int lineNumber)
        {
            return FileData[lineNumber];
        }

    }
}

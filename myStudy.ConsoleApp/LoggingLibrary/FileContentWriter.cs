using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace myStudy.ConsoleApp.LoggingLibrary
{
    public class FileContentWriter : BaseContentWriter
    {
        string _fileName;

        public FileContentWriter(string fileName)
        {
            _fileName = fileName;
        }
        public override bool WriteToMedia(string content)
        {
            using (FileStream fs = File.Open(_fileName, FileMode.Append))
            {
                var bytes = Encoding.UTF8.GetBytes(content + "\r\n");
                fs.Write(bytes,0,bytes.Length);
            }

            return true;
        }
    }
}

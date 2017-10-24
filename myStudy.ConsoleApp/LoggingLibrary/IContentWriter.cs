using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.ConsoleApp.LoggingLibrary
{
    public interface IContentWriter
    {
        Task<bool> Write(string content);
    }
}

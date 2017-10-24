using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.ConsoleApp.LoggingLibrary
{
    public abstract class BaseContentWriter : IContentWriter
    {
        ConcurrentQueue<string> _concurrentQueue = new ConcurrentQueue<string>();

        object _lock = new object();

        public abstract bool WriteToMedia(string content);

        public async Task<bool> Write(string content)
        {
            _concurrentQueue.Enqueue(content);

            if(_concurrentQueue.Count <= 10)
            {
                return true;
            }

            lock(_lock)
            {
                Task t =  Task.Run(() => Flush());
                Task.WaitAll(new Task[] { t });
            }

            return true;
        }

        async Task Flush()
        {
            string content;
            int count=0;

            while(_concurrentQueue.TryDequeue(out content) && count <= 10)
            {
                WriteToMedia(content);
                count++;
            }
        }
    }
}

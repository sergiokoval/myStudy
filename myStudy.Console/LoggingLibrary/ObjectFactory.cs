using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.LoggingLibrary
{
    public class ObjectFactory
    {
        Dictionary<string, string> _objectConfigEntries = new Dictionary<string, string>();

        Dictionary<string, object> _objects = new Dictionary<string, object>();

        public ObjectFactory()
        {
            _objectConfigEntries.Add("NULL", typeof(NullLogStrategy).ToString());
            _objectConfigEntries.Add("FILE", typeof(FileLogStrategy).ToString());
        }

        public object Get(string key, string mode = "singleton")
        {
            object obj = null;

            if(_objects.TryGetValue(key, out obj))
            {
                return mode == "singleton" ? obj : obj.DeepClone();
            }

            string className = null;

            _objectConfigEntries.TryGetValue(key, out className);

            if (className == null)
                return null;

            var type = Type.GetType(className);

            if (type == null)
                return null;

            _objects[key] = Activator.CreateInstance(type);            

            return _objects[key];
        }
    }
}

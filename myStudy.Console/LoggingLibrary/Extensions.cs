using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.LoggingLibrary
{
    public static class Extensions
    {
        public static T DeepClone<T>(this T o)
        {
            using (var stream = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(stream, o);
                stream.Position = 0;

                return (T) bf.Deserialize(stream);
            }
        }
    }
}

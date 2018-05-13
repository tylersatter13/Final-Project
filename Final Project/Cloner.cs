using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Cloner
    {
        public static T Clone<T>(T obj)
        {
            using (var stream = new MemoryStream()) {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position =0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}

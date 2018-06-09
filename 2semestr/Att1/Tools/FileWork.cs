using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tools
{
    public class FileWork
    {
        public string Path { get; set; }
        public FileWork(string path) => Path = path;
        public string ReadText() => File.ReadAllText(Path);
        public void WriteText(string str) => File.WriteAllText(Path, str);
        public void WriteListInt(List<int> list)
        {
            FileStream file = new FileStream(Path, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(list.Count);
            foreach (var item in list)
            {
                writer.Write(item);
            }
            writer.Close();
            file.Close();
        }
        public List<int> ReadListInt()
        {
            FileStream file = new FileStream(Path,FileMode.Open);
            BinaryReader reader = new BinaryReader(file);
            int N = reader.ReadInt32();
            List<int> list = new List<int>();
            for (int i = 0; i < N; i++)
            {
                list.Add(reader.ReadInt32());
            }
            reader.Close();
            file.Close();
            return list;
        }
    }
}

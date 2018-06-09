using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myQueue
{
    public class FileWork
    {
        public string Path { get; set; }
        public FileWork(string path) => Path = path;
        public void WriteIntQueue(IntQueue queue)
        {
            FileStream file = new FileStream(Path, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(queue.Count);
            for (int i = 0; i < queue.Count; i++)
            {
                int value = queue.Dequque();
                writer.Write(value);
                queue.Enqueue(value);
            }
            writer.Close();
            file.Close();
        }
        public IntQueue ReadIntQueue()
        {
            FileStream file = new FileStream(Path, FileMode.Open);
            BinaryReader reader = new BinaryReader(file);
            int N = reader.ReadInt32();
            IntQueue queue = new IntQueue();
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(reader.ReadInt32());
            }
            reader.Close();
            file.Close();
            return queue;
        }
    }
}

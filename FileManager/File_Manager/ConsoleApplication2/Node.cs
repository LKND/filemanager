using System;

namespace ConsoleApplication2
{
    public abstract class Node
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfChange { get; set; }
        public DateTime DateOfLastAccess { get; set; }

       public abstract void Copy(Node nodeElement);
       public abstract void Write(byte[] batesArr);
       public abstract void Replace(string inDirectory);
       public abstract void Remove();
       public abstract void Open();
    }
}
    
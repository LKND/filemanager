using System.Collections.Generic;
using System.Diagnostics;
using System.IO;



namespace ConsoleApplication2
{
    class Files: Node
    {
         public string Per;
         public string NewPer;
          public IEnumerable<int> _information()
        {
            //Проверка диска на доступность
          var d = new DriveInfo(Per);
            if (d.IsReady)
            {
                // Отображение всех файлов по пути
                string[] path = Directory.GetFiles(Per);
                for (var i = 0; i < 1; i++)
                {
                    foreach (var s in path)
                    {
                        var inform = new FileInfo(s);
                        Name = inform.Name;
                        Path = inform.DirectoryName;
                        Size = inform.Length;
                        DateOfCreation = File.GetCreationTime(s);
                        DateOfChange = File.GetLastAccessTimeUtc(s);
                        DateOfLastAccess = File.GetLastAccessTime(s);
                        yield return i;
                    }
                }
            }

        }
        public override void Copy(Node nodeElement)
        {
            FileInfo fileInf = new FileInfo(Per);
            if (fileInf.Exists)
            {
                // чтение из файла
                using (FileStream fstream = File.OpenRead(Per))
                {
                    // преобразуем строку в байты
                    byte[] array = new byte[fstream.Length];
                    // считываем данные
                    fstream.Read(array, 0, array.Length);
                    fileInf.CopyTo(NewPer, true);
                }
            }
        }
        public override void Write(byte[] batesArr)
        {
            using (FileStream fstream = new FileStream(Per, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(Per);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);

            }
        }
        public override void Replace(string inDirectory)
        {
            var fileInf = new FileInfo(Per);
            if (fileInf.Exists)
            { // чтение из файла
                using (FileStream fstream = File.OpenRead(Per))
                {
                    // преобразуем строку в байты
                    var array = new byte[fstream.Length];
                    // считываем данные
                    fstream.Read(array, 0, array.Length);
                    fileInf.MoveTo(inDirectory);
                }
            }
        }
        public override void Remove()
        {
            if (!File.Exists(Per)) return;
            File.Delete(Per);
        }
        public override void Open()
        {
            //Проверка на существование файла
            if (!File.Exists(Per)) return;
            //Открываем файл внешней программой
            var p1 = new Process { StartInfo = { FileName = Per } };
            p1.Start(); 
        }

       }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MusicSolvage
{
    public static class Core
    {
        public sealed class FileInfoMp3
        {
            private FileInfo fi;

            public bool mp3 { get; }
            public string Name { get { return fi.Name; } }
            public string FullName { get { return fi.FullName; } }
            public DateTime CreationTime { get { return fi.CreationTime; } }
            public long Length { get { return fi.Length; } }

            public FileInfoMp3(string fileName)
            {
                fi = new FileInfo(fileName);
                mp3 = false;
                if (fi.Exists)
                {
                    try
                    {
                        FileStream fs = File.OpenRead(fi.FullName);
                        byte[] b2 = new byte[2];
                        int res = fs.Read(b2, 0, 2);
                        fs.Close();
                        mp3 = (b2[0] == 255 && b2[1] > 239);
                    }
                    catch
                    {
                    }
                }
            }
        }


        public static FileInfoMp3[] GetFileList(string dir)
        {
            FileInfoMp3[] fimp3v = new FileInfoMp3[0];
            DirectoryInfo di = new DirectoryInfo(dir);
            if (di.Exists)
            {
                FileInfo[] fiv = di.GetFiles();
                fimp3v = new FileInfoMp3[fiv.Length];
                for (int i = 0; i < fiv.Length; i++)
                {
                    fimp3v[i] = new FileInfoMp3(fiv[i].FullName);
                }
            }
            return fimp3v;
        }

    }
}

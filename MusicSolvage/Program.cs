using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicSolvage
{
    struct fileInfo
    {
        public string Name;
        public DateTime CreationTime;
        public long Length;
        public string FullName;
        public ushort index;
        public bool colFlag1;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string GetNewDir(string dir)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = dir;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dir = fbd.SelectedPath;
            }
            return dir;
        }

        public static void GetFileList(string dir, out FileInfo[] fiv, out bool[] mp3v)
        {
            fiv = new FileInfo[0];
            mp3v = new bool[0];
            DirectoryInfo di = new DirectoryInfo(dir);
            if (di.Exists)
            {
                fiv = di.GetFiles();
                mp3v = new bool[fiv.Length];

                for (int i = 0; i < fiv.Length; i++)
                {
                    try
                    {
                        FileStream fs = File.OpenRead(fiv[i].FullName);
                        byte[] b2 = new byte[2];
                        int res = fs.Read(b2, 0, 2);
                        fs.Close();
                        mp3v[i] = (b2[0] == 255 && b2[1] > 239);
                    }
                    catch
                    {
                    }
                }
            }
        }

        public static string Merge(string[] fnv, string newfilename)
        {
            byte[] btFrame;
            byte[] btAllFrames = new byte[0];
            string errMsg = "";
            foreach (string fn in fnv)
            {
                try
                {
                    btFrame = File.ReadAllBytes(fn);
                    btAllFrames = btAllFrames.Concat(btFrame).ToArray();
                }
                catch (Exception e)
                {
                    errMsg = e.Message;
                }
            }
            File.WriteAllBytes(newfilename, btAllFrames); // Requires System.IO
            return errMsg;
        }

        public static void DeleteFiles(DirectoryInfo  di)
            {
            foreach (FileInfo fi in di.GetFiles())
            {
                try
                {
                    File.Delete(fi.FullName);
                }
                catch (Exception)
                {
                    //Debug.WriteLine("Error on deletion of:  {0}", fi.FullName);
                }
            }
        }
    }


}

using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace MusicSolvage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //txtDir.Text = @"C:\Users\Вася\AppData\Local\Google\Chrome\User Data\Default\Media Cache";
            txtDir.Text = @"C:\Users\Вася\AppData\Local\Yandex\YandexBrowser\User Data\Default\Media Cache\";
            txtOutputDir.Text = @"C:\Users\Вася\Music";
            GetFileList();
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            txtDir.Text = GetNewDir(txtDir.Text);
            GetFileList();
        }

        private string GetNewDir(string dir)
        {
            folderBrowserDialog1.SelectedPath = dir;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dir = folderBrowserDialog1.SelectedPath;
            }
            return dir;
        }

        private void GetFileList()
        {
            tabFiles.Clear();
            DirectoryInfo di = new DirectoryInfo(txtDir.Text);
            if (di.Exists)
            {
                DataRow dr = tabFiles.NewRow();
                foreach (FileInfo file in di.GetFiles())
                {
                    bool colFlag1 = false;
                    try
                    {
                        FileStream fs = File.OpenRead(file.FullName);
                        byte[] b2 = new byte[2];
                        int res = fs.Read(b2, 0, 2);
                        fs.Close();
                        colFlag1 = (b2[0] == 255 && b2[1] > 239);
                    }
                    catch
                    {
                    }
                    tabFiles.Rows.Add(file.Name, file.CreationTime, file.Length, file.FullName, 0, colFlag1);
                }
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            string newfilename = txtOutputDir.Text + "\\" + txtNewFileName.Text.Trim() + ".mp3";
            if (newfilename != String.Empty)
            {
                string filter = String.Format("colIndexName > 0");
                DataRow[] selection = tabFiles.Select(filter, "colIndexName");

                Merge1(newfilename, selection, false);
            }
        }

        //private void Merge2(string newfilename, DataRow[] selection)
        //{
        //    StringBuilder sb = new StringBuilder("copy /B ");
        //    foreach (DataRow dr in selection)
        //    {
        //        sb.Append("\"");
        //        sb.Append(dr[colFileFullName] as string);
        //        sb.Append("\"");
        //        sb.Append("+");
        //    }
        //    sb.Remove(sb.Length - 1, 1);
        //    sb.Append(" \"");
        //    sb.Append(newfilename);
        //    sb.Append("\"");

        //    string copycmd = sb.ToString();

        //    Process cmd = new Process();
        //    cmd.StartInfo.FileName = "cmd.exe";
        //    cmd.StartInfo.RedirectStandardInput = true;
        //    cmd.StartInfo.RedirectStandardOutput = true;
        //    //cmd.StartInfo.CreateNoWindow = true;
        //    cmd.StartInfo.UseShellExecute = false;
        //    cmd.Start();

        //    cmd.StandardInput.WriteLine(copycmd);
        //    cmd.StandardInput.Flush();
        //    cmd.StandardInput.Close();
        //    cmd.WaitForExit();
        //    Debug.WriteLine(cmd.StandardOutput.ReadToEnd());
        //}


        private void Merge1(string newfilename, DataRow[] selection, bool mp3)
        {
            byte[] btFrame;
            byte[] btAllFrames = new byte[0];
            foreach (DataRow dr in selection)
            {
                btFrame = File.ReadAllBytes(dr[colFileFullName] as string);
                btAllFrames = btAllFrames.Concat(btFrame).ToArray();
            }

            File.WriteAllBytes(newfilename, btAllFrames); // Requires System.IO
        }


        private void grdFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView;
            string fullname = drv.Row[colFileFullName] as string;
            Debug.WriteLine(fullname);
            Debug.WriteLine(drv.Row[colFileName] as string);
            axWindowsMediaPlayer1.URL = fullname;
        }

        private void btnResetIndex_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in tabFiles.Rows)
            {
                dr[colIndex] = 0;
            }
        }

        private void btnDeleteAllFiles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((sender as Button).FindForm(), "Удалить все файлы?", ":-|", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(txtDir.Text);
                if (di.Exists)
                {
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        try
                        {
                            File.Delete(fi.FullName);
                        }
                        catch (Exception)
                        {
                            Debug.WriteLine("Error on deletion of:  {0}", fi.FullName);
                        }
                    }
                    GetFileList();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetFileList();
        }

        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            txtOutputDir.Text = GetNewDir(txtOutputDir.Text);
        }

        //private void CloseWaveOut()
        //{
        //    if (waveOutDevice != null)
        //    {
        //        waveOutDevice.Stop();
        //    }
        //    if (mainOutputStream != null)
        //    {
        //        audioFileReader.Dispose();
        //        audioFileReader = null;
        //    }
        //    if (waveOutDevice != null)
        //    {
        //        waveOutDevice.Dispose();
        //        waveOutDevice = null;
        //    }
        //}
    }
}


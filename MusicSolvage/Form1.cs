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
        int lastId = 0;

        public Form1()
        {
            InitializeComponent();
            //txtDir.Text = @"C:\Users\Вася\AppData\Local\Google\Chrome\User Data\Default\Media Cache";
            txtDir.Text = @"C:\Users\Vasya\AppData\Local\Yandex\YandexBrowser\User Data\Default\Media Cache\";
            txtOutputDir.Text = @"C:\Users\Vasya\Music";
            RefreshForm();
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            txtDir.Text = Program.GetNewDir(txtDir.Text);
            RefreshForm();
        }

        private void RefreshForm()
        {
            tabFiles.Clear();
            Program.GetFileList(txtDir.Text, out FileInfo[] fiv, out bool[] mp3v);
            for (int i = 0; i < fiv.Length; i++)
            {
                tabFiles.Rows.Add(fiv[i].Name, fiv[i].CreationTime, fiv[i].Length, fiv[i].FullName, 0, mp3v[i]);
            }
        }



        private void btnMerge_Click(object sender, EventArgs e)
        {
            string errMsg = String.Empty;
            string newfilename = txtNewFileName.Text.Trim();
            if (newfilename != String.Empty)
            {
                newfilename = txtOutputDir.Text + "\\" + newfilename + ".mp3";
                string filter = String.Format("colIndex > 0");
                DataRow[] selection = tabFiles.Select(filter, "colIndex");
                int count = selection.Length;
                if (count > 0)
                {
                    string[] fnv = new string[count];
                    int i = 0;
                    foreach (DataRow dr in selection)
                    {
                        fnv[i] = dr[colFileFullName] as string;
                        i++;
                    }
                    errMsg = Program.Merge(fnv, newfilename);
                }
                else
                {
                    errMsg = "Индексы не указаны.";
                }
            }
            else
            {
                errMsg = "Имя файла слияния не указано.";
            }

            if (errMsg != String.Empty)
            {
                MessageBox.Show(errMsg);
            }
            else
            {
                txtNewFileName.Text = String.Empty;
            }
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
            lastId = 1;
        }

        private void btnDeleteAllFiles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((sender as Button).FindForm(), "Удалить все файлы?", ":-|", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(txtDir.Text);
                if (di.Exists)
                {
                    Program.DeleteFiles(di);
                    RefreshForm();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            txtOutputDir.Text = Program.GetNewDir(txtOutputDir.Text);
        }

        private void grdFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.ColumnIndex == 0)
            {
                DataRowView drv = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView;
                 drv.Row[colIndex] = lastId;
                Debug.WriteLine(lastId);
                lastId = lastId + 1;
            }
        }
    }
}


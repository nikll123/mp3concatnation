namespace MusicSolvage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMerge = new System.Windows.Forms.Button();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.btnResetIndex = new System.Windows.Forms.Button();
            this.btnDeleteAllFiles = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grdFiles = new System.Windows.Forms.DataGridView();
            this.colIndexName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlag1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsFiles = new System.Data.DataSet();
            this.tabFiles = new System.Data.DataTable();
            this.colFileName = new System.Data.DataColumn();
            this.colDateTime = new System.Data.DataColumn();
            this.colFileSize = new System.Data.DataColumn();
            this.colFileFullName = new System.Data.DataColumn();
            this.colIndex = new System.Data.DataColumn();
            this.colFlag11 = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnSelectOutputDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFiles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(517, 144);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.44898F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.551021F));
            this.tableLayoutPanel2.Controls.Add(this.btnSelectDir, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.grdFiles, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSelectOutputDir, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 212);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectDir.Location = new System.Drawing.Point(480, 3);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(34, 23);
            this.btnSelectDir.TabIndex = 2;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // txtDir
            // 
            this.txtDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDir.Location = new System.Drawing.Point(3, 3);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(471, 20);
            this.txtDir.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnMerge, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNewFileName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnResetIndex, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteAllFiles, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRefresh, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 167);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(471, 42);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnMerge
            // 
            this.btnMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMerge.Location = new System.Drawing.Point(151, 3);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(74, 36);
            this.btnMerge.TabIndex = 0;
            this.btnMerge.Text = "Склеить";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewFileName.Location = new System.Drawing.Point(3, 3);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(142, 20);
            this.txtNewFileName.TabIndex = 1;
            // 
            // btnResetIndex
            // 
            this.btnResetIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetIndex.Location = new System.Drawing.Point(231, 3);
            this.btnResetIndex.Name = "btnResetIndex";
            this.btnResetIndex.Size = new System.Drawing.Size(74, 36);
            this.btnResetIndex.TabIndex = 2;
            this.btnResetIndex.Text = "Reset";
            this.btnResetIndex.UseVisualStyleBackColor = true;
            this.btnResetIndex.Click += new System.EventHandler(this.btnResetIndex_Click);
            // 
            // btnDeleteAllFiles
            // 
            this.btnDeleteAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteAllFiles.Location = new System.Drawing.Point(311, 3);
            this.btnDeleteAllFiles.Name = "btnDeleteAllFiles";
            this.btnDeleteAllFiles.Size = new System.Drawing.Size(74, 36);
            this.btnDeleteAllFiles.TabIndex = 3;
            this.btnDeleteAllFiles.Text = "Delete files";
            this.btnDeleteAllFiles.UseVisualStyleBackColor = true;
            this.btnDeleteAllFiles.Click += new System.EventHandler(this.btnDeleteAllFiles_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(391, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grdFiles
            // 
            this.grdFiles.AllowUserToAddRows = false;
            this.grdFiles.AllowUserToDeleteRows = false;
            this.grdFiles.AutoGenerateColumns = false;
            this.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndexName,
            this.colFileNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colFlag1});
            this.grdFiles.DataMember = "tabFilesName";
            this.grdFiles.DataSource = this.dsFiles;
            this.grdFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFiles.Location = new System.Drawing.Point(3, 32);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeadersWidth = 20;
            this.grdFiles.Size = new System.Drawing.Size(471, 95);
            this.grdFiles.TabIndex = 5;
            this.grdFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFiles_CellClick);
            this.grdFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFiles_CellDoubleClick);
            // 
            // colIndexName
            // 
            this.colIndexName.DataPropertyName = "colIndex";
            this.colIndexName.FillWeight = 20F;
            this.colIndexName.HeaderText = "Index";
            this.colIndexName.Name = "colIndexName";
            this.colIndexName.Width = 40;
            // 
            // colFileNameDataGridViewTextBoxColumn
            // 
            this.colFileNameDataGridViewTextBoxColumn.DataPropertyName = "colFileName";
            this.colFileNameDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.colFileNameDataGridViewTextBoxColumn.Name = "colFileNameDataGridViewTextBoxColumn";
            this.colFileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colFileNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "colDateTime";
            this.dataGridViewTextBoxColumn1.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "colFileSize";
            this.dataGridViewTextBoxColumn2.HeaderText = "Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colFlag1
            // 
            this.colFlag1.DataPropertyName = "colFlag1";
            this.colFlag1.HeaderText = "mp3";
            this.colFlag1.Name = "colFlag1";
            this.colFlag1.ReadOnly = true;
            this.colFlag1.Width = 40;
            // 
            // dsFiles
            // 
            this.dsFiles.DataSetName = "NewDataSet";
            this.dsFiles.Tables.AddRange(new System.Data.DataTable[] {
            this.tabFiles});
            // 
            // tabFiles
            // 
            this.tabFiles.Columns.AddRange(new System.Data.DataColumn[] {
            this.colFileName,
            this.colDateTime,
            this.colFileSize,
            this.colFileFullName,
            this.colIndex,
            this.colFlag11});
            this.tabFiles.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "colFileName"}, true),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "colFileFullName"}, false)});
            this.tabFiles.PrimaryKey = new System.Data.DataColumn[] {
        this.colFileName};
            this.tabFiles.TableName = "tabFilesName";
            // 
            // colFileName
            // 
            this.colFileName.AllowDBNull = false;
            this.colFileName.Caption = "File name";
            this.colFileName.ColumnName = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // colDateTime
            // 
            this.colDateTime.Caption = "Date Time";
            this.colDateTime.ColumnName = "colDateTime";
            this.colDateTime.DataType = typeof(System.DateTime);
            this.colDateTime.ReadOnly = true;
            // 
            // colFileSize
            // 
            this.colFileSize.Caption = "File size";
            this.colFileSize.ColumnName = "colFileSize";
            this.colFileSize.DataType = typeof(uint);
            this.colFileSize.ReadOnly = true;
            // 
            // colFileFullName
            // 
            this.colFileFullName.Caption = "File FullName";
            this.colFileFullName.ColumnName = "colFileFullName";
            this.colFileFullName.ReadOnly = true;
            // 
            // colIndex
            // 
            this.colIndex.Caption = "IndexCaption";
            this.colIndex.ColumnName = "colIndex";
            this.colIndex.DataType = typeof(byte);
            // 
            // colFlag11
            // 
            this.colFlag11.Caption = "mp3";
            this.colFlag11.ColumnName = "colFlag1";
            this.colFlag11.DataType = typeof(bool);
            this.colFlag11.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOutputDir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 28);
            this.panel1.TabIndex = 6;
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutputDir.Location = new System.Drawing.Point(0, 0);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(471, 20);
            this.txtOutputDir.TabIndex = 0;
            // 
            // btnSelectOutputDir
            // 
            this.btnSelectOutputDir.Location = new System.Drawing.Point(480, 133);
            this.btnSelectOutputDir.Name = "btnSelectOutputDir";
            this.btnSelectOutputDir.Size = new System.Drawing.Size(31, 23);
            this.btnSelectOutputDir.TabIndex = 7;
            this.btnSelectOutputDir.Text = "...";
            this.btnSelectOutputDir.UseVisualStyleBackColor = true;
            this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Склеиватель MP3";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFiles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.DataGridView grdFiles;
        private System.Data.DataSet dsFiles;
        private System.Data.DataTable tabFiles;
        private System.Data.DataColumn colFileName;
        private System.Data.DataColumn colDateTime;
        private System.Data.DataColumn colFileSize;
        private System.Data.DataColumn colFileFullName;
        private System.Data.DataColumn colIndex;
        private System.Windows.Forms.Button btnResetIndex;
        private System.Windows.Forms.Button btnDeleteAllFiles;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Button btnSelectOutputDir;
        private System.Data.DataColumn colFlag11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndexName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlag1;
    }
}


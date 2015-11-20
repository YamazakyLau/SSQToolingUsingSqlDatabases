namespace SSQToolingUsingSqlite
{
    partial class FormBasic
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFileOpen = new System.Windows.Forms.Label();
            this.textBoxFileOpen = new System.Windows.Forms.TextBox();
            this.treeViewAll = new System.Windows.Forms.TreeView();
            this.buttonTablesAll = new System.Windows.Forms.Button();
            this.buttonShowTableDetails = new System.Windows.Forms.Button();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.textBoxSelectInto = new System.Windows.Forms.TextBox();
            this.buttonSelectInto = new System.Windows.Forms.Button();
            this.openFileDialogSql = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelFileOpen
            // 
            this.labelFileOpen.AutoSize = true;
            this.labelFileOpen.Location = new System.Drawing.Point(13, 13);
            this.labelFileOpen.Name = "labelFileOpen";
            this.labelFileOpen.Size = new System.Drawing.Size(137, 12);
            this.labelFileOpen.TabIndex = 0;
            this.labelFileOpen.Text = "请选择一个数据库文件：";
            // 
            // textBoxFileOpen
            // 
            this.textBoxFileOpen.Location = new System.Drawing.Point(156, 10);
            this.textBoxFileOpen.Name = "textBoxFileOpen";
            this.textBoxFileOpen.Size = new System.Drawing.Size(402, 21);
            this.textBoxFileOpen.TabIndex = 1;
            this.textBoxFileOpen.Click += new System.EventHandler(this.textBoxFileOpen_Clicked);
            // 
            // treeViewAll
            // 
            this.treeViewAll.Location = new System.Drawing.Point(12, 69);
            this.treeViewAll.Name = "treeViewAll";
            this.treeViewAll.Size = new System.Drawing.Size(545, 172);
            this.treeViewAll.TabIndex = 2;
            // 
            // buttonTablesAll
            // 
            this.buttonTablesAll.Location = new System.Drawing.Point(15, 40);
            this.buttonTablesAll.Name = "buttonTablesAll";
            this.buttonTablesAll.Size = new System.Drawing.Size(75, 23);
            this.buttonTablesAll.TabIndex = 3;
            this.buttonTablesAll.Text = "显示表格";
            this.buttonTablesAll.UseVisualStyleBackColor = true;
            this.buttonTablesAll.Click += new System.EventHandler(this.buttonTablesAll_Click);
            // 
            // buttonShowTableDetails
            // 
            this.buttonShowTableDetails.Location = new System.Drawing.Point(156, 40);
            this.buttonShowTableDetails.Name = "buttonShowTableDetails";
            this.buttonShowTableDetails.Size = new System.Drawing.Size(110, 23);
            this.buttonShowTableDetails.TabIndex = 4;
            this.buttonShowTableDetails.Text = "表格属性-->";
            this.buttonShowTableDetails.UseVisualStyleBackColor = true;
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(272, 42);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(285, 21);
            this.textBoxTableName.TabIndex = 5;
            // 
            // textBoxSelectInto
            // 
            this.textBoxSelectInto.Location = new System.Drawing.Point(128, 249);
            this.textBoxSelectInto.Name = "textBoxSelectInto";
            this.textBoxSelectInto.Size = new System.Drawing.Size(429, 21);
            this.textBoxSelectInto.TabIndex = 7;
            // 
            // buttonSelectInto
            // 
            this.buttonSelectInto.Location = new System.Drawing.Point(12, 247);
            this.buttonSelectInto.Name = "buttonSelectInto";
            this.buttonSelectInto.Size = new System.Drawing.Size(110, 23);
            this.buttonSelectInto.TabIndex = 6;
            this.buttonSelectInto.Text = "查询导出-->";
            this.buttonSelectInto.UseVisualStyleBackColor = true;
            // 
            // openFileDialogSql
            // 
            this.openFileDialogSql.FileName = "openFileDialogSql";
            // 
            // FormBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 279);
            this.Controls.Add(this.textBoxSelectInto);
            this.Controls.Add(this.buttonSelectInto);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.buttonShowTableDetails);
            this.Controls.Add(this.buttonTablesAll);
            this.Controls.Add(this.treeViewAll);
            this.Controls.Add(this.textBoxFileOpen);
            this.Controls.Add(this.labelFileOpen);
            this.Name = "FormBasic";
            this.Text = "Sqlite数据库工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileOpen;
        private System.Windows.Forms.TextBox textBoxFileOpen;
        private System.Windows.Forms.TreeView treeViewAll;
        private System.Windows.Forms.Button buttonTablesAll;
        private System.Windows.Forms.Button buttonShowTableDetails;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.TextBox textBoxSelectInto;
        private System.Windows.Forms.Button buttonSelectInto;
        private System.Windows.Forms.OpenFileDialog openFileDialogSql;
    }
}


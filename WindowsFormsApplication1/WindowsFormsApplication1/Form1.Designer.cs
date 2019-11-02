namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_SourceFile = new System.Windows.Forms.Button();
            this.textBox_SourceFile = new System.Windows.Forms.TextBox();
            this.label_SourceFile = new System.Windows.Forms.Label();
            this.label_DestinationFile = new System.Windows.Forms.Label();
            this.textBox_DestinationFile = new System.Windows.Forms.TextBox();
            this.button_DestinationFile = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_ThreadCopy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SourceFile
            // 
            this.button_SourceFile.Location = new System.Drawing.Point(376, 58);
            this.button_SourceFile.Name = "button_SourceFile";
            this.button_SourceFile.Size = new System.Drawing.Size(27, 22);
            this.button_SourceFile.TabIndex = 0;
            this.button_SourceFile.Text = "...";
            this.button_SourceFile.UseVisualStyleBackColor = true;
            this.button_SourceFile.Click += new System.EventHandler(this.button_SourceFile_Click);
            // 
            // textBox_SourceFile
            // 
            this.textBox_SourceFile.Location = new System.Drawing.Point(141, 60);
            this.textBox_SourceFile.Name = "textBox_SourceFile";
            this.textBox_SourceFile.Size = new System.Drawing.Size(229, 20);
            this.textBox_SourceFile.TabIndex = 1;
            this.textBox_SourceFile.Text = "Путь к исходному файлу";
            // 
            // label_SourceFile
            // 
            this.label_SourceFile.AutoSize = true;
            this.label_SourceFile.Location = new System.Drawing.Point(48, 63);
            this.label_SourceFile.Name = "label_SourceFile";
            this.label_SourceFile.Size = new System.Drawing.Size(87, 13);
            this.label_SourceFile.TabIndex = 2;
            this.label_SourceFile.Text = "Исходный файл";
            // 
            // label_DestinationFile
            // 
            this.label_DestinationFile.AutoSize = true;
            this.label_DestinationFile.Location = new System.Drawing.Point(48, 100);
            this.label_DestinationFile.Name = "label_DestinationFile";
            this.label_DestinationFile.Size = new System.Drawing.Size(69, 13);
            this.label_DestinationFile.TabIndex = 3;
            this.label_DestinationFile.Text = "Файл-копия";
            // 
            // textBox_DestinationFile
            // 
            this.textBox_DestinationFile.Location = new System.Drawing.Point(141, 97);
            this.textBox_DestinationFile.Name = "textBox_DestinationFile";
            this.textBox_DestinationFile.Size = new System.Drawing.Size(229, 20);
            this.textBox_DestinationFile.TabIndex = 4;
            this.textBox_DestinationFile.Text = "Куда копируем?";
            // 
            // button_DestinationFile
            // 
            this.button_DestinationFile.Location = new System.Drawing.Point(376, 97);
            this.button_DestinationFile.Name = "button_DestinationFile";
            this.button_DestinationFile.Size = new System.Drawing.Size(27, 22);
            this.button_DestinationFile.TabIndex = 5;
            this.button_DestinationFile.Text = "...";
            this.button_DestinationFile.UseVisualStyleBackColor = true;
            this.button_DestinationFile.Click += new System.EventHandler(this.button_DestinationFile_Click);
            // 
            // button_Copy
            // 
            this.button_Copy.Location = new System.Drawing.Point(51, 137);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(156, 51);
            this.button_Copy.TabIndex = 6;
            this.button_Copy.Text = "Копировать";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // button_ThreadCopy
            // 
            this.button_ThreadCopy.Location = new System.Drawing.Point(246, 137);
            this.button_ThreadCopy.Name = "button_ThreadCopy";
            this.button_ThreadCopy.Size = new System.Drawing.Size(157, 51);
            this.button_ThreadCopy.TabIndex = 7;
            this.button_ThreadCopy.Text = "Копировать в отдельном потоке";
            this.button_ThreadCopy.UseVisualStyleBackColor = true;
            this.button_ThreadCopy.Click += new System.EventHandler(this.button_ThreadCopy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(51, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 45);
            this.progressBar1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 275);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_ThreadCopy);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_DestinationFile);
            this.Controls.Add(this.textBox_DestinationFile);
            this.Controls.Add(this.label_DestinationFile);
            this.Controls.Add(this.label_SourceFile);
            this.Controls.Add(this.textBox_SourceFile);
            this.Controls.Add(this.button_SourceFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SourceFile;
        private System.Windows.Forms.TextBox textBox_SourceFile;
        private System.Windows.Forms.Label label_SourceFile;
        private System.Windows.Forms.Label label_DestinationFile;
        private System.Windows.Forms.TextBox textBox_DestinationFile;
        private System.Windows.Forms.Button button_DestinationFile;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button button_ThreadCopy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


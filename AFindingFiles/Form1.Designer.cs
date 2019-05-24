namespace AFindingFiles
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
            this._tbFile = new System.Windows.Forms.TextBox();
            this._tbView = new System.Windows.Forms.TextBox();
            this._bView = new System.Windows.Forms.Button();
            this._bFind = new System.Windows.Forms.Button();
            this._lbDisplay = new System.Windows.Forms.ListBox();
            this._fBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._lSearchFileName = new System.Windows.Forms.Label();
            this._lSearchPath = new System.Windows.Forms.Label();
            this._cbRecurs = new System.Windows.Forms.CheckBox();
            this._lSearchResult = new System.Windows.Forms.Label();
            this._bClear = new System.Windows.Forms.Button();
            this._bClearAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _tbFile
            // 
            this._tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbFile.Location = new System.Drawing.Point(145, 38);
            this._tbFile.Name = "_tbFile";
            this._tbFile.Size = new System.Drawing.Size(499, 20);
            this._tbFile.TabIndex = 0;
            // 
            // _tbView
            // 
            this._tbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbView.Location = new System.Drawing.Point(145, 12);
            this._tbView.Name = "_tbView";
            this._tbView.Size = new System.Drawing.Size(411, 20);
            this._tbView.TabIndex = 1;
            // 
            // _bView
            // 
            this._bView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bView.Location = new System.Drawing.Point(563, 12);
            this._bView.Name = "_bView";
            this._bView.Size = new System.Drawing.Size(81, 23);
            this._bView.TabIndex = 2;
            this._bView.Text = "Обзор...";
            this._bView.UseVisualStyleBackColor = true;
            this._bView.Click += new System.EventHandler(this._bView_Click);
            // 
            // _bFind
            // 
            this._bFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bFind.Location = new System.Drawing.Point(156, 110);
            this._bFind.Name = "_bFind";
            this._bFind.Size = new System.Drawing.Size(488, 23);
            this._bFind.TabIndex = 3;
            this._bFind.Text = "Поиск";
            this._bFind.UseVisualStyleBackColor = true;
            this._bFind.Click += new System.EventHandler(this._bFind_Click);
            // 
            // _lbDisplay
            // 
            this._lbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbDisplay.FormattingEnabled = true;
            this._lbDisplay.Location = new System.Drawing.Point(11, 173);
            this._lbDisplay.Name = "_lbDisplay";
            this._lbDisplay.Size = new System.Drawing.Size(633, 381);
            this._lbDisplay.TabIndex = 4;
            this._lbDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAnswer_MouseDoubleClick);
            // 
            // _lSearchFileName
            // 
            this._lSearchFileName.AutoSize = true;
            this._lSearchFileName.Location = new System.Drawing.Point(8, 41);
            this._lSearchFileName.Name = "_lSearchFileName";
            this._lSearchFileName.Size = new System.Drawing.Size(116, 13);
            this._lSearchFileName.TabIndex = 5;
            this._lSearchFileName.Text = "Шаблон имени файла";
            // 
            // _lSearchPath
            // 
            this._lSearchPath.AutoSize = true;
            this._lSearchPath.Location = new System.Drawing.Point(8, 12);
            this._lSearchPath.Name = "_lSearchPath";
            this._lSearchPath.Size = new System.Drawing.Size(125, 13);
            this._lSearchPath.TabIndex = 6;
            this._lSearchPath.Text = "Стартовая директория:";
            // 
            // _cbRecurs
            // 
            this._cbRecurs.AutoSize = true;
            this._cbRecurs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbRecurs.Checked = true;
            this._cbRecurs.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbRecurs.Location = new System.Drawing.Point(22, 110);
            this._cbRecurs.Name = "_cbRecurs";
            this._cbRecurs.Size = new System.Drawing.Size(128, 17);
            this._cbRecurs.TabIndex = 8;
            this._cbRecurs.Text = "Искать в подпапках";
            this._cbRecurs.UseVisualStyleBackColor = true;
            // 
            // _lSearchResult
            // 
            this._lSearchResult.AutoSize = true;
            this._lSearchResult.Location = new System.Drawing.Point(8, 157);
            this._lSearchResult.Name = "_lSearchResult";
            this._lSearchResult.Size = new System.Drawing.Size(109, 13);
            this._lSearchResult.TabIndex = 9;
            this._lSearchResult.Text = "Результаты поиска:";
            // 
            // _bClear
            // 
            this._bClear.Location = new System.Drawing.Point(156, 139);
            this._bClear.Name = "_bClear";
            this._bClear.Size = new System.Drawing.Size(205, 23);
            this._bClear.TabIndex = 10;
            this._bClear.Text = "Очистить результаты";
            this._bClear.UseVisualStyleBackColor = true;
            this._bClear.Click += new System.EventHandler(this._bClear_Click);
            // 
            // _bClearAll
            // 
            this._bClearAll.Location = new System.Drawing.Point(432, 139);
            this._bClearAll.Name = "_bClearAll";
            this._bClearAll.Size = new System.Drawing.Size(212, 23);
            this._bClearAll.TabIndex = 11;
            this._bClearAll.Text = "Очистить все";
            this._bClearAll.UseVisualStyleBackColor = true;
            this._bClearAll.Click += new System.EventHandler(this._bClearAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Текст, содержащийся в файле:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._bClearAll);
            this.Controls.Add(this._bClear);
            this.Controls.Add(this._lSearchResult);
            this.Controls.Add(this._cbRecurs);
            this.Controls.Add(this._lSearchPath);
            this.Controls.Add(this._lSearchFileName);
            this.Controls.Add(this._lbDisplay);
            this.Controls.Add(this._bFind);
            this.Controls.Add(this._bView);
            this.Controls.Add(this._tbView);
            this.Controls.Add(this._tbFile);
            this.Name = "Form1";
            this.Text = "Форма поиска файлов по 3 критериям";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbFile;
        private System.Windows.Forms.TextBox _tbView;
        private System.Windows.Forms.Button _bView;
        private System.Windows.Forms.Button _bFind;
        private System.Windows.Forms.ListBox _lbDisplay;
        private System.Windows.Forms.FolderBrowserDialog _fBrowserDialog;
        private System.Windows.Forms.Label _lSearchFileName;
        private System.Windows.Forms.Label _lSearchPath;
        private System.Windows.Forms.CheckBox _cbRecurs;
        private System.Windows.Forms.Label _lSearchResult;
        private System.Windows.Forms.Button _bClear;
        private System.Windows.Forms.Button _bClearAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


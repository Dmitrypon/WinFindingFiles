//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;//для Process

namespace AFindingFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// обработка нажатия по кнопке "Поиск"
        /// </summary>
        private void _bFind_Click(object sender, EventArgs e)
        {
            try
            {
                _bClear_Click(sender, e);//очищаем поле с предыдущими результатами
                DirectoryInfo dir = new DirectoryInfo(this._tbView.Text);
                string file = this._tbFile.Text;
                FindInDir(dir, file, this._cbRecurs.Checked);//если нажат чекбокс, то поиск будет идти только в заданной папке
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// поиск файла в папке
        /// </summary>
        /// <param name="dir">в какой папке искать</param>
        /// <param name="pattern">какой файл искать</param>
        /// <param name="recursive">искать ли в подпапках</param>
        public void FindInDir(DirectoryInfo dir, string pattern, bool recursive)
        {
            foreach (FileInfo file in dir.GetFiles(pattern))
            {
                this._lbDisplay.Items.Add(file.FullName);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {                    
                    this.FindInDir(subdir, pattern, recursive);
                }
            }
        }

        /// <summary>
        /// поиск файла в директории
        /// </summary>
        /// <param name="dir">где искать</param>
        /// <param name="pattern">имя файла для поиска</param>
        public void FindFiles(string dir, string pattern)
        {
            this.FindInDir(new DirectoryInfo(dir), pattern, true);
        }

        /// <summary>
        /// обработка нажатия по кнопке "Обзор"
        /// </summary>
        private void _bView_Click(object sender, EventArgs e)
        {
            if (this._fBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this._tbView.Text = this._fBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// обработка нажатия по кнопке "Очистить"
        /// </summary>
        private void _bClear_Click(object sender, EventArgs e)
        {            
            this._lbDisplay.Items.Clear();
        }

        /// <summary>
        /// обработка нажатия по кнопке "Очистить все"
        /// </summary>
        private void _bClearAll_Click(object sender, EventArgs e)
        {
            this._tbFile.Text = "";
            this._tbView.Text = "";
            this._lbDisplay.Items.Clear();
        }

        /// <summary>
        /// обработка двойного клика мыши по результатам
        /// </summary>
        private void lbAnswer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(this._lbDisplay.SelectedItem.ToString());//пытаемся открыть файл программой по умолчанию
        }
    }
}

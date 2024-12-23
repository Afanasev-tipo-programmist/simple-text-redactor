﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Простой_текстовый_редактор
{
    public partial class WinFormsApp_SimpleTextEditor : Form
    {
        public WinFormsApp_SimpleTextEditor()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //получаем выбранный файл
                string filename = openFileDialog.FileName;
                //читаем файл в строку
                string filetext = System.IO.File.ReadAllText(filename);
                textField.Text = filetext;
            }
            else return;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filename, textField.Text);
            }
            else return;
        }
    }
}

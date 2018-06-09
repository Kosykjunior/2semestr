using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace _1._1
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileWork file = new FileWork(openFileDialog.FileName);
                    input.Text = file.ReadText();
                }
                catch (Exception)
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileWork file = new FileWork(saveFileDialog.FileName);
                    file.WriteText(input.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            StrTools str = new StrTools(input.Text);
            input.Text = str.GetMarks();
        }

    }
}

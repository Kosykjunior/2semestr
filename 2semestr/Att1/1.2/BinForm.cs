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

namespace _1._2
{
    public partial class BinForm : Form
    {
        public BinForm()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileWork file = new FileWork(openFileDialog.FileName);
                    InpList = file.ReadListInt();
                }
                catch (Exception)
                {
                    MessageBox.Show("error");
                }
            }
        }
        private List<int> InpList
        {
            set => Inp.Text = string.Join(" ", value);
            get
            {
                List<int> list = new List<int>();
                string[] s = Inp.Text.Split(new char[] { ' ', ','},StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in s)
                {
                    list.Add(int.Parse(item));
                }
                return list;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileWork file = new FileWork(saveFileDialog.FileName);
                    file.WriteListInt(InpList);
                }
                catch (Exception)
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            try
            {
                ListIntFiltr filtr = new ListIntFiltr(InpList);
                if (EvenBtn.Checked)
                    InpList = filtr.Even();
                else if (OddBtn.Checked)
                    InpList = filtr.Odd();
                else if (PositiveBtn.Checked)
                    InpList = filtr.Positive();
                else if (NegativeBtn.Checked)
                    InpList = filtr.Negative();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
    }
}

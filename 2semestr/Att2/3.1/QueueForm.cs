using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myQueue;
namespace _3._1
{
    public partial class QueueForm : Form
    {
        public QueueForm()
        {
            InitializeComponent();
        }
        IntQueue queue;
        private void QueueForm_Load(object sender, EventArgs e)
        {
            queue = new IntQueue();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            queue.Enqueue((int)ValueInput.Value);
            Upd();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            queue.Dequque();
            Upd();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            queue.InsertAt((int)IndexInput.Value, (int)ValueInput.Value);
            Upd();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() ==DialogResult.OK)
            {
                try
                {
                    FileWork file = new FileWork(openFileDialog.FileName);
                    queue = file.ReadIntQueue();
                    Upd();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
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
                    file.WriteIntQueue(queue);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Upd()
        {
            Output.Text = queue.ToString();
            IndexInput.Maximum = queue.Count;
        }
    }
}

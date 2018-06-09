using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myTree;
using TreeDrawTools;

namespace _5
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
        }
        TreeDraw draw;
        private void TreeForm_Load(object sender, EventArgs e)
        {
            draw = new TreeDraw(output.Size, new Tree());
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            draw.tree = new Tree((int)GetN.Value);
            output.Image = draw.Draw();
        }
    }
}

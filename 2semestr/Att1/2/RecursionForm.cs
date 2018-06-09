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
namespace _2
{
    public partial class RecursionForm : Form
    {
        public RecursionForm()
        {
            InitializeComponent();
        }
        BooleanLogic logic = new BooleanLogic("");
        private void Input_TextChanged(object sender, EventArgs e)
        {
            logic.Str = Input.Text;
            if (logic.TryGet(out bool Value))
                Output.Text = Value.ToString();
            else
                Output.Text = " ";
        }
    }
}

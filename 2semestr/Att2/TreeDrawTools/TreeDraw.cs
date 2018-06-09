using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTree;
using System.Drawing;

namespace TreeDrawTools
{
    public class TreeDraw
    {
        public Bitmap Image { get; private set; }
        Graphics G;
        public Size Size { get; set; }
        public Tree tree { get; set; }
        private int dY;
        private int R = 20;
        public TreeDraw(Size size, Tree tree)
        {
            Size = size;
            this.tree = tree;
        }
        private void Draw(Node node, int level, int left, int right)
        {
            int dX = (left + right) / 2;
            if (node.Left!=null && node.Right!=null)
            {
                G.DrawLine(Pens.Black, dX, level * dY, (dX + left)/2, (level + 1) * dY);
                G.DrawLine(Pens.Black, dX, level * dY, (dX + right)/2, (level + 1) * dY);
                Draw(node.Left, level + 1, left, dX);
                Draw(node.Left, level + 1, dX, right);
            }
            G.FillEllipse(Brushes.Red, dX - R, level * dY - R, 2 * R, 2 * R);
            G.DrawString(node.Value.ToString(), new Font("Microsoft Sans", 15), Brushes.Black, dX - 10, level * dY - 10);
        }
        public Bitmap Draw()
        {
            Image = new Bitmap(Size.Width, Size.Height);
            G = Graphics.FromImage(Image);
            dY = Size.Height / (tree.GetHeight() + 1);
            Draw(tree.Root, 1, 0, Size.Width);
            G.Dispose();
            return Image;
        }
    }
}

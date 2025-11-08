using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Karatsuba
{

    public partial class TreeView : Form
    {

        public TreeView()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = true;
            panel1.VerticalScroll.Enabled = true;
            panel1.AutoScrollMinSize = new Size(1000, 1000); // Giá trị tạm, sẽ tính lại sau


        }
     

        private TreeNode CreateNode(KaratsubaNode node)
        {

            TreeNode treeNode = new TreeNode($"{node.Expression} = {node.Result}");
            foreach (var child in node.Children)
            {
                treeNode.Nodes.Add(CreateNode(child));
            }
            return treeNode;
        }


      
        private int ComputeTreeHeight(KaratsubaNode node)
        {
            if (node.Children.Count == 0) return 1;
            int maxChildHeight = 0;
            foreach (var child in node.Children)
                maxChildHeight = Math.Max(maxChildHeight, ComputeTreeHeight(child));
            return 1 + maxChildHeight;
        }
        private Size MeasureNode(Graphics g, string text)
        {
            SizeF sizeF = g.MeasureString(text, this.Font);
            int width = (int)sizeF.Width + 10; // thêm padding ngang
            int height = (int)sizeF.Height + 4; // thêm padding dọc
            return new Size(width, height);
        }

        // Tính width thật sự của cây theo nội dung node
        private int ComputeTreeWidth(KaratsubaNode node, Graphics g, int xSpacing)
        {
            Size nodeSize = MeasureNode(g, $"{node.Expression} = {node.Result}");
            if (node.Children.Count == 0) return nodeSize.Width;

            int totalChildWidth = 0;
            foreach (var child in node.Children)
                totalChildWidth += ComputeTreeWidth(child, g, xSpacing) + xSpacing;

            return Math.Max(nodeSize.Width, totalChildWidth - xSpacing);
        }

        // DrawTree với node width tự động
        private void DrawTree(Graphics g, KaratsubaNode node, int y, int xStart, int xEnd, int ySpacing)
        {
            if (node == null) return;

            Size nodeSize = MeasureNode(g, $"{node.Expression} = {node.Result}");
            int nodeWidth = nodeSize.Width;
            int nodeHeight = nodeSize.Height;

            int nodeX = (xStart + xEnd - nodeWidth) / 2;

            Rectangle rect = new Rectangle(nodeX, y, nodeWidth, nodeHeight);
            g.FillRectangle(node.Children.Count == 0 ? Brushes.LightBlue : Brushes.Orange, rect);
            g.DrawRectangle(Pens.Black, rect);
            g.DrawString($"{node.Expression} = {node.Result}", this.Font, Brushes.Black, rect.X + 2, rect.Y + 2);

            if (node.Children.Count == 0) return;

            // Vẽ các node con
            int totalChildWidth = 0;
            List<int> childWidths = new List<int>();
            foreach (var child in node.Children)
            {
                int w = ComputeTreeWidth(child, g, 20);
                childWidths.Add(w);
                totalChildWidth += w;
            }
            totalChildWidth += 20 * (node.Children.Count - 1);

            int childX = xStart;
            for (int i = 0; i < node.Children.Count; i++)
            {
                int childWidth = childWidths[i];

                int childCenterX = childX + childWidth / 2;
                g.DrawLine(Pens.Black, nodeX + nodeWidth / 2, y + nodeHeight,
                           childCenterX, y + nodeHeight + ySpacing);

                DrawTree(g, node.Children[i], y + nodeHeight + ySpacing, childX, childX + childWidth, ySpacing);

                childX += childWidth + 20;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (Karatsuba.TreeResult != null)
            {
                int treeWidth = ComputeTreeWidth(Karatsuba.TreeResult, e.Graphics, 20);
                int treeHeight = ComputeTreeHeight(Karatsuba.TreeResult) * 70 + 50;

                e.Graphics.TranslateTransform(panel1.AutoScrollPosition.X, panel1.AutoScrollPosition.Y);

                DrawTree(e.Graphics, Karatsuba.TreeResult, 10, 0, treeWidth, 70);

                panel1.AutoScrollMinSize = new Size(treeWidth + 50, treeHeight);
            }
        }
    }
}

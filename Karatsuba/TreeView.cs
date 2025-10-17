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
            LoadTree(Karatsuba.TreeResult);


        }

        private void LoadTree(KaratsubaNode root)
        {
            treeView1.Nodes.Clear();
            if (root == null) return;

            TreeNode rootNode = CreateNode(root);
            treeView1.Nodes.Add(rootNode);
            treeView1.ExpandAll();
            this.Icon = Properties.Resources.robotic_hand;
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //Karatsuba kb= new Karatsuba();
            //kb.Show();
            //this.Hide();

            this.Close();
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
            treeView1.ExpandAll();
        }
    }
}

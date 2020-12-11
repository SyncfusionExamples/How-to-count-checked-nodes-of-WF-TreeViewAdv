using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewAdv_CheckBox
{
    public partial class Form1 : MetroForm
    {
        TreeViewAdv treeView1 = new TreeViewAdv();
        public Form1()
        {
            InitializeComponent();
            treeView1 = new TreeViewAdv();
            treeView1.Name = "treeView1";
            treeView1.ShowCheckBoxes = true;
            treeView1.Size = new Size(312, 368);
            treeView1.Style = TreeStyle.Office2016Colorful;

            //Create instances of TreeNodeAdv named treeNode1 and treenode7
            TreeNodeAdv treeNode1 = new TreeNodeAdv("Node1");
            TreeNodeAdv treeNode7 = new TreeNodeAdv("Node7");

            //Adding the subnode of [treeNode1 and treenode7] in Root [treeNode2].
            TreeNodeAdv treeNode2 = new TreeNodeAdv("Node0", new TreeNodeAdv[] {
            treeNode1, treeNode7});
            treeNode2.Expanded = true;

            //Create instances of TreeNodeAdv named treeNode3 and treenode8
            TreeNodeAdv treeNode3 = new TreeNodeAdv("Node3");
            TreeNodeAdv treeNode8 = new TreeNodeAdv("Node8");

            //Adding the subnode of [treeNode3 and treenode8] in Root [treeNode4].
            TreeNodeAdv treeNode4 = new TreeNodeAdv("Node2", new TreeNodeAdv[] {
            treeNode3, treeNode8});
            treeNode4.Expanded = true;

            // Create instances of TreeNodeAdv named treeNode5 and treenode9
            TreeNodeAdv treeNode5 = new TreeNodeAdv("Node5");
            TreeNodeAdv treeNode9 = new TreeNodeAdv("Node9");

            //Adding the subnode of [treeNode5 and treenode9] in Root [treeNode6].
            TreeNodeAdv treeNode6 = new TreeNodeAdv("Node4", new TreeNodeAdv[] {
            treeNode5, treeNode9});
            treeNode6.Expanded = true;

            //Assigning the text and Name

            treeNode1.Name = "Node1";
            treeNode1.Text = "India";

            treeNode7.Name = "Node7";
            treeNode7.Text = "China";

            treeNode2.Name = "Node0";
            treeNode2.Text = "Asia";

            treeNode3.Name = "Node3";
            treeNode3.Text = "Britain";

            treeNode8.Name = "Node8";
            treeNode8.Text = "France";

            treeNode4.Name = "Node2";
            treeNode4.Text = "Europe";

            treeNode5.Name = "Node5";
            treeNode5.Text = "South Africa";

            treeNode9.Name = "Node9";
            treeNode9.Text = "Zimbabwe";

            treeNode6.Name = "Node4";
            treeNode6.Text = "Africa";

            //Add the nodes in TreeViewAdv nodes collection
            treeView1.Nodes.AddRange(new TreeNodeAdv[] {
            treeNode2,
            treeNode4,
            treeNode6});

            // Add the TreeViewAdv to the Form controls
            this.Controls.Add(treeView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TotalNodesInTree = treeView1.GetNodeCount(true);
            int checkedCount = treeView1.CheckedNodes.Count;
            MessageBox.Show("Total nodes in tree = " + TotalNodesInTree.ToString() + "\n" + "Total number of checked nodes = " + checkedCount);
        }
    }
}

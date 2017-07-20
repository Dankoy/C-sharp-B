using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _9_TreeView
{
    class Form1 : Form
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        public Form1()
        {
            Text = "Tree of catalogs TreeView";
            TreeView tree = new TreeView();
            tree.Parent = this;
            tree.Dock = DockStyle.Fill;
            TreeNode nodeDrive = new TreeNode("D:\\");
            tree.Nodes.Add(nodeDrive);
            AddDirectories(nodeDrive);
        }

        void AddDirectories(TreeNode node)
        {
            string strPath = node.FullPath;
            DirectoryInfo dirinfo = new DirectoryInfo(strPath);
            DirectoryInfo[] adirinfo;
            try
            {
                adirinfo = dirinfo.GetDirectories();
            }
            catch { return; }
            foreach (DirectoryInfo di in adirinfo)
            {
                TreeNode nodeDir = new TreeNode(di.Name);
                node.Nodes.Add(nodeDir);
                AddDirectories(nodeDir);
            }
        }

    }
}

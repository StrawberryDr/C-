using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad;

namespace MDINotepad
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTxt MDIChild = new frmTxt();
            MDIChild.MdiParent = this;
            MDIChild.Show();
        }

        private void 垂直平铺VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 层叠CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平平铺HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 全部关闭LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}

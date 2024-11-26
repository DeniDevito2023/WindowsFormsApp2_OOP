using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_OOP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int number = 1;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count()>0)
            {
                this.ActiveMdiChild.Close();
            }
            
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {


            foreach (Form f in this.MdiChildren)
            { 
                f.Close();
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(number);
            number++;
            f.MdiParent = this;
            f.Show();
        }

        private void puctureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

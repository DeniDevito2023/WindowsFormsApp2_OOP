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

    

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form3 f3;
private void выводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.ShowDialog(this);
        }
    }
}

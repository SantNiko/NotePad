using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FindForm : Form
    {
        public int C_FIND = 0;
        public int C_REPLACE = 1;


        public FindForm()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = tabControl.SelectedTab.Text;
        }

        public void selectTab(int opcion) {
            tabControl.SelectedIndex = opcion;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = ((NotePad)this.Owner).getText();
        }
    }
}

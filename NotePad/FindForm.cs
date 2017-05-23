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

        myTextBox rtb;

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
            lblFindCount.Visible = false;
            rtb = ((NotePad)this.Owner).getText();
            int startindex = -1;

            if (tbFind.Text.Length > 0)
                startindex = rtb.FindMyText(tbFind.Text.Trim(), rtb.start, rtb.Text.Length);

            // If string was found in the RichTextBox, highlight it
            if (startindex >= 0)
            {
                // Set the highlight color as red
                rtb.SelectionColor = Color.Red;
                // Find the end index. End Index = number of characters in textbox
                int endindex = tbFind.Text.Length;
                // Highlight the search string
                rtb.Select(startindex, endindex);
                // mark the start position after the position of
                // last search string
                rtb.start = startindex + endindex;
            }
            else {
                rtb.initSearch();
            }
        }

        public void undoLast() {
            rtb.Select();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int startindex = 0;
            rtb = ((NotePad)this.Owner).getText();
            rtb.initSearch();
            int c = 0;
            
            while ((startindex = rtb.FindMyText(tbFind.Text.Trim(), rtb.start, rtb.Text.Length)) >= 0)
            {
                int endindex = tbFind.Text.Length;
                rtb.Select(startindex, endindex);
                rtb.start = startindex + endindex;
                c++;
            }
            rtb.start = 0;
            lblFindCount.Text = "Contar: "+c+" matches.";
            lblFindCount.Visible = true;
        }
    }
}

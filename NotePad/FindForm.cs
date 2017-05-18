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
            rtb = ((NotePad)this.Owner).getText();
            int startindex = 0;

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
        }

        public void undoLast() {
            rtb.Select(0,0);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {

        }
    }
}

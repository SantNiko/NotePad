using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotePad.pocos;

namespace NotePad
{
    public partial class BasicNote : Form
    {
        public BasicNote()
        {
            InitializeComponent();
            myTextBox mtb = new myTextBox();
            mtb.Dock = DockStyle.Fill;
            this.Controls.Add(mtb);
            mtb.file = new myFile("newdoc.txt", false);
        }

        public BasicNote(myFile file)
        {
            InitializeComponent();
            myTextBox mtb = new myTextBox();
            mtb.Dock = DockStyle.Fill;
            this.Controls.Add(mtb);

        }

        private void BasicNote_Load(object sender, EventArgs e)
        {

        }
    }
}

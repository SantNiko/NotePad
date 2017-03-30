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
    public partial class NotePad : Form
    {

        private String filePath;

        public NotePad()
        {
            InitializeComponent();
            filePath = "";
        }

        private void mfNew_Click(object sender, EventArgs e)
        {

        }

        private void mfOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName != "") {
                    filePath = ofd.FileName;
                    //MessageBox.Show(filePath); // Aqui compruebo que realmente me está cogiendo al ruta del fichero - BIEN
                    rtbFile.Text = System.IO.File.ReadAllLines;
                }
            }
        }

        private void mfSave_Click(object sender, EventArgs e)
        {

        }
    }
}

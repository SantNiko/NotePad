using NotePad.pocos;
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

        private myFile file;

        public NotePad()
        {
            InitializeComponent();
            file = new myFile();
        }

        private void msgSave() {
            if (MessageBox.Show("El fichero actual fue modificado, desea modificarlo?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                mfSave_Click(null, null);
            }
        }

        private void mfNew_Click(object sender, EventArgs e)
        {
            if (file.modified)
            {
                //preguntar si quiere guardar fichero actual
                msgSave();
            }
            //borrar contenido y filepath?
            rtbFile.Text = "";
            file = new myFile();

        }

        private void mfOpen_Click(object sender, EventArgs e)
        {
            if (file.modified)
            {
                //preguntar si quiere guardar fichero actual
                msgSave();
            }
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName != "") {
                    file.filePath = ofd.FileName;
                    //MessageBox.Show(filePath); // Aqui compruebo que realmente me está cogiendo al ruta del fichero - BIEN
                    rtbFile.LoadFile(file.filePath, RichTextBoxStreamType.PlainText); // bien, abrí un fichero sql y me lo abrió
                    file.modified = false;
                }
            }
        }

        private void mfSave_Click(object sender, EventArgs e)
        {
            if (file.filePath == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "*.txt";
                sfd.Filter = "Plain Text Files|*.txt";
                //sfd.ShowDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != "")
                    {
                        file.filePath = sfd.FileName;
                        rtbFile.SaveFile(file.filePath, RichTextBoxStreamType.PlainText);
                        file.modified = false;
                    }
                }
            }
            else {
                rtbFile.SaveFile(file.filePath, RichTextBoxStreamType.PlainText);
                file.modified = false;
            }
        }

        private void rtbFile_TextChanged(object sender, EventArgs e)
        {
            file.modified = true;
        }

        private void NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (file.modified)
            {
                //preguntar si quiere guardar fichero actual
                msgSave();
            }
            Application.Exit();
        }

        private void mfClose_Click(object sender, EventArgs e)
        {
            NotePad_FormClosing(null,null);
        }

        private void mfSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.txt";
            sfd.Filter = "Plain Text Files|*.txt";
            //sfd.ShowDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != "")
                {
                    file.filePath = sfd.FileName;
                    rtbFile.SaveFile(file.filePath, RichTextBoxStreamType.PlainText);
                    file.modified = false;
                }
            }
        }
    }
}

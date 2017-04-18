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
        private static int nBlank = 1;
        private List<myFile> file;

        public NotePad()
        {
            InitializeComponent();
            file = new List<myFile>();
            file.Add(new myFile());
            this.mfNew.Click += new EventHandler(nuevo);
            this.mfOpen.Click += new System.EventHandler(abrir);
            this.mfSave.Click += new System.EventHandler(guardar);

        }

        private void msgSave() {
            if (MessageBox.Show("El fichero actual fue modificado, desea modificarlo?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                guardar(null, null);
            }
        }

        private void nuevo(object sender, EventArgs e) {
            nuevoBlanco(null, null);
            RichTextBox rtb =  (RichTextBox)tbControl.SelectedTab.Controls[0];
            rtb.Text = "";
            file.Add(new myFile());
        }

        private void abrir(object sender, EventArgs e)
        {
            nuevo(null, null);
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName != "") {
                    file[tbControl.SelectedIndex].filePath = ofd.FileName;
                    tbControl.SelectedTab.Text = ofd.FileName;
                    //MessageBox.Show(file[tbControl.SelectedIndex].filePath); // Aqui compruebo que realmente me está cogiendo al ruta del fichero - BIEN
                    ((RichTextBox)tbControl.SelectedTab.Controls[0]).LoadFile(file[tbControl.SelectedIndex].filePath, RichTextBoxStreamType.PlainText); // bien, abrí un fichero sql y me lo abrió
                    file[tbControl.SelectedIndex].modified = false;
                }
            }
        }

        private void guardar(object sender, EventArgs e)
        {
            if (file[tbControl.SelectedIndex].filePath == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "*.txt";
                sfd.Filter = "Plain Text Files|*.txt";
                //sfd.ShowDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != "")
                    {
                        file[tbControl.SelectedIndex].filePath = sfd.FileName;
                        ((RichTextBox)tbControl.SelectedTab.Controls[0]).SaveFile(file[tbControl.SelectedIndex].filePath, RichTextBoxStreamType.PlainText);
                        tbControl.SelectedTab.Text = sfd.FileName;
                        file[tbControl.SelectedIndex].modified = false;
                    }
                }
            }
            else {
                //rtbFile.SaveFile(file.filePath, RichTextBoxStreamType.PlainText);
                file[tbControl.SelectedIndex].modified = false;
            }
        }

        private void rtbFile_TextChanged(object sender, EventArgs e)
        {
            file[tbControl.SelectedIndex].modified = true;
        }

        private void NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (file[tbControl.SelectedIndex].modified)
            {
                //preguntar si quiere guardar fichero actual
                msgSave();
            }
           // Application.Exit();
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
                    file[tbControl.SelectedIndex].filePath = sfd.FileName;
                    //rtbFile.SaveFile(file.filePath, RichTextBoxStreamType.PlainText);
                    file[tbControl.SelectedIndex].modified = false;
                }
            }
        }
        private void nuevoBlanco(object sender, EventArgs e)
        {
                TabPage tbN = new TabPage("NewTabPage" + nBlank);
                RichTextBox rtbN = new RichTextBox();
                rtbN.Name = "file";
                rtbN.Dock = DockStyle.Fill; 
                tbN.Controls.Add(rtbN);
                tbControl.TabPages.Insert(tbControl.TabPages.Count - 1, tbN);
                tbControl.SelectedTab = tbN;
                nBlank++;
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbControl.SelectedTab == tabMas) {
                nuevo(null,null);
            }
        }
    }
}

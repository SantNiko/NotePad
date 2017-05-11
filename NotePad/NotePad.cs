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
        public static int CONST_TABPAGES = 0;
        public static int CONST_WINDOWS = 1;

        private List<myTextBox> textos;

        public NotePad()
        {
            InitializeComponent();
            textos.Add(new myTextBox());
            tbControl.TabPages[0].Controls.Add(textos[0]);
            this.mfNew.Click += new EventHandler(nuevo);
            this.mfOpen.Click += new System.EventHandler(abrir);
            this.mfSave.Click += new System.EventHandler(s);
            this.msFind.Click += new System.EventHandler(openFind);

        }
        
        private bool msgSave(String fichero) {
            if (MessageBox.Show("El fichero " + fichero + " fue modificado, desea modificarlo?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool b = guardar(null, null);
                return b;
            }
            else {
                return true;
            }
            
        }

        private void nuevo(object sender, EventArgs e) {
            nuevoBlanco(null, null);
            
        }

        private void nuevoBlanco(object sender, EventArgs e)
        {

            if (mwTabs.Checked)
            {

            } else if (mwWindow.Checked){

            }

        }

        private void abrir(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName != "") {
                }
            }
        }

        private void s(object sender, EventArgs e)
        {
            guardar(sender, e);
        }

        private void sAs(object sender, EventArgs e)
        {
            mfSaveAs_Click(sender, e);
        }

        private bool guardar(object sender, EventArgs e)
        {
            return false;
        }

        private void textChanged(object sender, EventArgs e)
        {
            
        }

        private void NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void mfClose_Click(object sender, EventArgs e)
        {
            NotePad_FormClosing(null,null);
        }

        private bool mfSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.txt";
            sfd.Filter = "Plain Text Files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != "")
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tbControl.SelectedTab == tabMas)
            //{
            //    nuevo(null, null);
            //}
            //else {
            //    if (files[tbControl.SelectedIndex].filePath != "")
            //{
            //    this.Text = "Notepad - " + files[tbControl.SelectedIndex].filePath;
            //}
            //else {
            //    this.Text = "Notepad";
            //}
            //}
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            textChanged(sender,e);
        }

        private void openFind(object sender, EventArgs e) {
            // Create form to be owned.
            Form ownedForm = new FindForm();
            this.AddOwnedForm(ownedForm);
            // Show the owned form.
            ownedForm.Show();
        }
        private void openReplace(object sender, EventArgs e)
        {
            // Create form to be owned.
            FindForm ownedForm = new FindForm();
            this.AddOwnedForm(ownedForm);
            ownedForm.selectTab(ownedForm.C_REPLACE);
            ownedForm.Show();
        }

        public myTextBox getText() {
            return (myTextBox)(tbControl.SelectedTab.Controls[0]);
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbControl.Dispose();
            foreach (var item in tbControl.TabPages)
            {
                
                myTextBox mtb = (myTextBox)(((TabPage)item).Controls[0]);
                BasicNote newMDIChild = new BasicNote(mtb.file);
                // Set the Parent Form of the Child window.  
                newMDIChild.MdiParent = this;
                // Display the new form.  
                newMDIChild.Show();
            }
            nBlank = 0;
        }

        private void tagPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbControl = new TabControl();
            tbControl.Dock = DockStyle.Fill;

            foreach (var item in this.MdiChildren)
            {
                TabPage tbN = new TabPage("NewTabPage" + nBlank);
                myTextBox mtb = ((myTextBox)((BasicNote)item).Controls[0]);
                tbN.Controls.Add(mtb);
                tbControl.TabPages.Insert(tbControl.TabPages.Count - 1, tbN);

            }
            tbControl.Visible = true;
        }
    }
}

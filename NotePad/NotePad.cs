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
            textos = new List<myTextBox>();
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
            myTextBox mtbN = new myTextBox();
            mtbN.Dock = DockStyle.Fill;
            mtbN.TextChanged += textChanged;

            if (mwTabs.Checked)
            {
                TabPage tbN = new TabPage("NewTabPage" + nBlank);
                textos.Add(mtbN);
                tbN.Controls.Add(mtbN);
                tbControl.TabPages.Insert(tbControl.TabPages.Count - 1, tbN);
                tbControl.SelectedTab = tbN;
                nBlank++;

            } else if (mwWindow.Checked){
                BasicNote newMDIChild = new BasicNote(mtbN); 
                newMDIChild.MdiParent = this; 
                newMDIChild.Show();
            }

        }

        private void abrir(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName != "") {
                    if (mwTabs.Checked)
                    {
                        ((myTextBox)tbControl.SelectedTab.Controls[0]).filePath = ofd.FileName;
                        this.Text = "Notepad - " + ofd.FileName;
                    }
                    else {
                        ((myTextBox)this.ActiveMdiChild.Controls[0]).filePath = ofd.FileName;
                    }
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
            myTextBox mtb;
            if (mwTabs.Checked)
            {
                mtb = ((myTextBox)tbControl.SelectedTab.Controls[0]);
            }
            else {
                mtb = ((myTextBox)this.ActiveMdiChild.Controls[0]);
            }

            if (mtb.filePath == "")
            {
                bool b = mfSaveAs_Click(null, null);
                return b;
            }
            else
            {
                mtb.SaveFile(mtb.filePath, RichTextBoxStreamType.PlainText);
                mtb.isModified = false;
                return true;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            myTextBox mtb;
            if (mwTabs.Checked)
            {
                mtb = ((myTextBox)tbControl.SelectedTab.Controls[0]);
            }
            else
            {
                mtb = ((myTextBox)this.ActiveMdiChild.Controls[0]);
            }
            mtb.isModified = true;
        }

        private void NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < textos.Count; i++)
            {
                if (textos[i].isModified)
                {
                    string msg="";
                    if (mwTabs.Checked)
                    {
                        tbControl.SelectedIndex = i;
                        msg = tbControl.TabPages[i].Text;
                    }
                    else {
                        MdiChildren[i].Focus();
                        msg = MdiChildren[i].Text;
                    }
                    if (!msgSave(msg))
                    {
                        e.Cancel = true;
                        i = textos.Count;
                    }

                }
            }
        }

        private void mfClose_Click(object sender, EventArgs e)
        {
            NotePad_FormClosing(null,null);
        }

        private bool mfSaveAs_Click(object sender, EventArgs e)
        {
            myTextBox mtb;
            if (mwTabs.Checked)
            {
                mtb = ((myTextBox)tbControl.SelectedTab.Controls[0]);
            }
            else
            {
                mtb = ((myTextBox)this.ActiveMdiChild.Controls[0]);
            }

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
            mwTabs.Checked = false;
            mwTabs.Enabled = true;
            mwWindow.Checked = true;
            mwWindow.Enabled = false;
            int s = tbControl.SelectedIndex;

            TabPage tb = tbControl.SelectedTab;
            myTextBox mtb = (myTextBox)(tb.Controls[0]);
            mtb.Dock = DockStyle.Fill;
            BasicNote newMDIChild = new BasicNote(mtb);
            if (mtb.filePath != "")
            {
                newMDIChild.Text = mtb.filePath;
            }
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();

            for (int i = 0; i < tbControl.TabCount-1; i++)
            {
                if (i!=s)
                {
                TabPage tba = tbControl.TabPages[i];
                myTextBox mtba = (myTextBox)(tba.Controls[0]);
                mtba.Dock = DockStyle.Fill;
                BasicNote newMDIChilda = new BasicNote(mtba);
                    if (mtba.filePath != "")
                    {
                        newMDIChilda.Text = mtba.filePath;
                    }
                // Set the Parent Form of the Child window.  
                newMDIChilda.MdiParent = this;
                // Display the new form.  
                newMDIChilda.Show();
                }
                
            }
            tbControl.TabPages.Clear();
            tbControl.Visible=false;
            nBlank = 0;
        }

        private void tagPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mwTabs.Checked = true;
            mwTabs.Enabled = false;
            mwWindow.Checked = false;
            mwWindow.Enabled = true;

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                TabPage tbN = new TabPage("NewTabPage" + nBlank);
                nBlank++;
                myTextBox mtb = ((myTextBox)((BasicNote)this.MdiChildren[0]).Controls[0]);
                tbN.Controls.Add(mtb);
                tbControl.TabPages.Add(tbN);
                this.MdiChildren[0].Dispose();
            }
            
                

            
            tbControl.Controls.Add(this.tabMas);
            tbControl.Visible = true;
        }
    }
}

﻿using NotePad.pocos;
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
        private List<myFile> files;

        public NotePad()
        {
            InitializeComponent();
            files = new List<myFile>();
            files.Add(new myFile());
            this.mfNew.Click += new EventHandler(nuevo);
            this.mfOpen.Click += new System.EventHandler(abrir);
            this.mfSave.Click += new System.EventHandler(guardar);

        }

        private void msgSave(String fichero) {
            if (MessageBox.Show("El fichero "+fichero+" fue modificado, desea modificarlo?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                guardar(null, null);
            }
        }

        private void nuevo(object sender, EventArgs e) {
            nuevoBlanco(null, null);
            files.Add(new myFile());
        }

        private void nuevoBlanco(object sender, EventArgs e)
        {
                TabPage tbN = new TabPage("NewTabPage" + nBlank);
                RichTextBox rtbN = new RichTextBox();
                rtbN.Name = "file";
                rtbN.Dock = DockStyle.Fill;
                rtbN.TextChanged += textChanged; 
                tbN.Controls.Add(rtbN);
                tbControl.TabPages.Insert(tbControl.TabPages.Count - 1, tbN);
                tbControl.SelectedTab = tbN;
                nBlank++;
        }

        private void abrir(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName != "") {
                    nuevo(null, null);
                    files[tbControl.SelectedIndex].filePath = ofd.FileName;
                    tbControl.SelectedTab.Text = ofd.FileName;//titulo del tab
                    //MessageBox.Show(file[tbControl.SelectedIndex].filePath); // Aqui compruebo que realmente me está cogiendo al ruta del fichero - BIEN
                    ((RichTextBox)tbControl.SelectedTab.Controls[0]).LoadFile(files[tbControl.SelectedIndex].filePath, RichTextBoxStreamType.PlainText); // bien, abrí un fichero sql y me lo abrió
                    files[tbControl.SelectedIndex].modified = false;
                }
            }
        }

        private void guardar(object sender, EventArgs e)
        {
            if (files[tbControl.SelectedIndex].filePath == "")
            {
                mfSaveAs_Click(null, null);
            }
            else {
                ((RichTextBox)tbControl.SelectedTab.Controls[0]).SaveFile(files[tbControl.SelectedIndex].filePath, RichTextBoxStreamType.PlainText);
                files[tbControl.SelectedIndex].modified = false;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            files[tbControl.SelectedIndex].modified = true;
        }

        private void NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].modified)
                {
                    msgSave(tbControl.TabPages[i].Text);
                }
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
                    files[tbControl.SelectedIndex].filePath = sfd.FileName;
                    ((RichTextBox)tbControl.SelectedTab.Controls[0]).SaveFile(files[tbControl.SelectedIndex].filePath, RichTextBoxStreamType.PlainText);
                    tbControl.SelectedTab.Text = sfd.FileName;//titulo del tab
                    files[tbControl.SelectedIndex].modified = false;
                }
            }
        }
        

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbControl.SelectedTab == tabMas) {
                nuevo(null,null);
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            textChanged(sender,e);
        }
    }
}

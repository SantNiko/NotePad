namespace NotePad
{
    partial class NotePad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mfNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mfOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mfSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mfSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mfClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.meCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.meCut = new System.Windows.Forms.ToolStripMenuItem();
            this.meRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.meUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.msFind = new System.Windows.Forms.ToolStripMenuItem();
            this.msFindReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mqAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbFile = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mSearch,
            this.mQuestion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfNew,
            this.mfOpen,
            this.mfSave,
            this.mfSaveAs,
            this.mfClose});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(37, 20);
            this.mFile.Text = "File";
            // 
            // mfNew
            // 
            this.mfNew.Image = global::NotePad.Properties.Resources._new;
            this.mfNew.Name = "mfNew";
            this.mfNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mfNew.Size = new System.Drawing.Size(177, 22);
            this.mfNew.Text = "&New";
            this.mfNew.Click += new System.EventHandler(this.mfNew_Click);
            // 
            // mfOpen
            // 
            this.mfOpen.Image = global::NotePad.Properties.Resources.open;
            this.mfOpen.Name = "mfOpen";
            this.mfOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mfOpen.Size = new System.Drawing.Size(177, 22);
            this.mfOpen.Text = "&Open";
            this.mfOpen.Click += new System.EventHandler(this.mfOpen_Click);
            // 
            // mfSave
            // 
            this.mfSave.Image = global::NotePad.Properties.Resources.save;
            this.mfSave.Name = "mfSave";
            this.mfSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mfSave.Size = new System.Drawing.Size(177, 22);
            this.mfSave.Text = "&Save";
            this.mfSave.Click += new System.EventHandler(this.mfSave_Click);
            // 
            // mfSaveAs
            // 
            this.mfSaveAs.Name = "mfSaveAs";
            this.mfSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.mfSaveAs.Size = new System.Drawing.Size(177, 22);
            this.mfSaveAs.Text = "Save As";
            // 
            // mfClose
            // 
            this.mfClose.Image = global::NotePad.Properties.Resources.close;
            this.mfClose.Name = "mfClose";
            this.mfClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mfClose.Size = new System.Drawing.Size(177, 22);
            this.mfClose.Text = "&Close";
            this.mfClose.Click += new System.EventHandler(this.mfClose_Click);
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meCopy,
            this.mePaste,
            this.meCut,
            this.meRedo,
            this.meUndo});
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(39, 20);
            this.mEdit.Text = "Edit";
            // 
            // meCopy
            // 
            this.meCopy.Image = global::NotePad.Properties.Resources.copy;
            this.meCopy.Name = "meCopy";
            this.meCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.meCopy.Size = new System.Drawing.Size(144, 22);
            this.meCopy.Text = "&Copy";
            // 
            // mePaste
            // 
            this.mePaste.Image = global::NotePad.Properties.Resources.paste;
            this.mePaste.Name = "mePaste";
            this.mePaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mePaste.Size = new System.Drawing.Size(144, 22);
            this.mePaste.Text = "&Paste";
            // 
            // meCut
            // 
            this.meCut.Image = global::NotePad.Properties.Resources.cut;
            this.meCut.Name = "meCut";
            this.meCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.meCut.Size = new System.Drawing.Size(144, 22);
            this.meCut.Text = "Cu&t";
            // 
            // meRedo
            // 
            this.meRedo.Image = global::NotePad.Properties.Resources.Redo;
            this.meRedo.Name = "meRedo";
            this.meRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.meRedo.Size = new System.Drawing.Size(144, 22);
            this.meRedo.Text = "&Redo";
            // 
            // meUndo
            // 
            this.meUndo.Image = global::NotePad.Properties.Resources.undo;
            this.meUndo.Name = "meUndo";
            this.meUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.meUndo.Size = new System.Drawing.Size(144, 22);
            this.meUndo.Text = "&Undo";
            // 
            // mSearch
            // 
            this.mSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFind,
            this.msFindReplace});
            this.mSearch.Name = "mSearch";
            this.mSearch.Size = new System.Drawing.Size(54, 20);
            this.mSearch.Text = "Search";
            // 
            // msFind
            // 
            this.msFind.Image = global::NotePad.Properties.Resources.find;
            this.msFind.Name = "msFind";
            this.msFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.msFind.Size = new System.Drawing.Size(184, 22);
            this.msFind.Text = "&Find";
            // 
            // msFindReplace
            // 
            this.msFindReplace.Image = global::NotePad.Properties.Resources.findReplace;
            this.msFindReplace.Name = "msFindReplace";
            this.msFindReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.msFindReplace.Size = new System.Drawing.Size(184, 22);
            this.msFindReplace.Text = "Find &Replace";
            // 
            // mQuestion
            // 
            this.mQuestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mqAbout});
            this.mQuestion.Name = "mQuestion";
            this.mQuestion.Size = new System.Drawing.Size(24, 20);
            this.mQuestion.Text = "?";
            // 
            // mqAbout
            // 
            this.mqAbout.Name = "mqAbout";
            this.mqAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mqAbout.Size = new System.Drawing.Size(175, 22);
            this.mqAbout.Text = "&About Notepad";
            // 
            // rtbFile
            // 
            this.rtbFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFile.Location = new System.Drawing.Point(0, 24);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.Size = new System.Drawing.Size(539, 361);
            this.rtbFile.TabIndex = 1;
            this.rtbFile.Text = "";
            this.rtbFile.TextChanged += new System.EventHandler(this.rtbFile_TextChanged);
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 385);
            this.Controls.Add(this.rtbFile);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotePad";
            this.Text = "NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotePad_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mfNew;
        private System.Windows.Forms.ToolStripMenuItem mfOpen;
        private System.Windows.Forms.ToolStripMenuItem mfSave;
        private System.Windows.Forms.ToolStripMenuItem mfSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mfClose;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem meCopy;
        private System.Windows.Forms.ToolStripMenuItem mePaste;
        private System.Windows.Forms.ToolStripMenuItem meCut;
        private System.Windows.Forms.ToolStripMenuItem meRedo;
        private System.Windows.Forms.ToolStripMenuItem meUndo;
        private System.Windows.Forms.ToolStripMenuItem mSearch;
        private System.Windows.Forms.ToolStripMenuItem msFind;
        private System.Windows.Forms.ToolStripMenuItem msFindReplace;
        private System.Windows.Forms.ToolStripMenuItem mQuestion;
        private System.Windows.Forms.ToolStripMenuItem mqAbout;
        private System.Windows.Forms.RichTextBox rtbFile;
    }
}


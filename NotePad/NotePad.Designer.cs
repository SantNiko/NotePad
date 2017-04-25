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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSBNew = new System.Windows.Forms.ToolStripButton();
            this.toolSBSave = new System.Windows.Forms.ToolStripButton();
            this.toolSBOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSBCut = new System.Windows.Forms.ToolStripButton();
            this.toolSBCopy = new System.Windows.Forms.ToolStripButton();
            this.toolSBPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSBUndo = new System.Windows.Forms.ToolStripButton();
            this.toolSBRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSBFind = new System.Windows.Forms.ToolStripButton();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabMas = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tabMas.SuspendLayout();
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
            // 
            // mfOpen
            // 
            this.mfOpen.Image = global::NotePad.Properties.Resources.open;
            this.mfOpen.Name = "mfOpen";
            this.mfOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mfOpen.Size = new System.Drawing.Size(177, 22);
            this.mfOpen.Text = "&Open";
            // 
            // mfSave
            // 
            this.mfSave.Image = global::NotePad.Properties.Resources.save;
            this.mfSave.Name = "mfSave";
            this.mfSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mfSave.Size = new System.Drawing.Size(177, 22);
            this.mfSave.Text = "&Save";
            // 
            // mfSaveAs
            // 
            this.mfSaveAs.Name = "mfSaveAs";
            this.mfSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.mfSaveAs.Size = new System.Drawing.Size(177, 22);
            this.mfSaveAs.Text = "Save As";
            this.mfSaveAs.Click += new System.EventHandler(this.mfSaveAs_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSBNew,
            this.toolSBSave,
            this.toolSBOpen,
            this.toolStripSeparator1,
            this.toolSBCut,
            this.toolSBCopy,
            this.toolSBPaste,
            this.toolStripSeparator2,
            this.toolSBUndo,
            this.toolSBRedo,
            this.toolStripSeparator3,
            this.toolSBFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(539, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSBNew
            // 
            this.toolSBNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBNew.Image = global::NotePad.Properties.Resources._new;
            this.toolSBNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBNew.Name = "toolSBNew";
            this.toolSBNew.Size = new System.Drawing.Size(23, 22);
            this.toolSBNew.Text = "toolStripButton1";
            this.toolSBNew.Click += new System.EventHandler(this.nuevo);
            // 
            // toolSBSave
            // 
            this.toolSBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBSave.Image = global::NotePad.Properties.Resources.save;
            this.toolSBSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBSave.Name = "toolSBSave";
            this.toolSBSave.Size = new System.Drawing.Size(23, 22);
            this.toolSBSave.Text = "toolStripButton2";
            this.toolSBSave.Click += new System.EventHandler(this.guardar);
            // 
            // toolSBOpen
            // 
            this.toolSBOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBOpen.Image = global::NotePad.Properties.Resources.open;
            this.toolSBOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBOpen.Name = "toolSBOpen";
            this.toolSBOpen.Size = new System.Drawing.Size(23, 22);
            this.toolSBOpen.Text = "toolStripButton3";
            this.toolSBOpen.Click += new System.EventHandler(this.abrir);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSBCut
            // 
            this.toolSBCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBCut.Image = global::NotePad.Properties.Resources.cut;
            this.toolSBCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBCut.Name = "toolSBCut";
            this.toolSBCut.Size = new System.Drawing.Size(23, 22);
            this.toolSBCut.Text = "toolStripButton4";
            // 
            // toolSBCopy
            // 
            this.toolSBCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBCopy.Image = global::NotePad.Properties.Resources.copy;
            this.toolSBCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBCopy.Name = "toolSBCopy";
            this.toolSBCopy.Size = new System.Drawing.Size(23, 22);
            this.toolSBCopy.Text = "toolStripButton5";
            // 
            // toolSBPaste
            // 
            this.toolSBPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBPaste.Image = global::NotePad.Properties.Resources.paste;
            this.toolSBPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBPaste.Name = "toolSBPaste";
            this.toolSBPaste.Size = new System.Drawing.Size(23, 22);
            this.toolSBPaste.Text = "toolStripButton6";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSBUndo
            // 
            this.toolSBUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBUndo.Image = global::NotePad.Properties.Resources.undo;
            this.toolSBUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBUndo.Name = "toolSBUndo";
            this.toolSBUndo.Size = new System.Drawing.Size(23, 22);
            this.toolSBUndo.Text = "toolStripButton7";
            // 
            // toolSBRedo
            // 
            this.toolSBRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBRedo.Image = global::NotePad.Properties.Resources.Redo;
            this.toolSBRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBRedo.Name = "toolSBRedo";
            this.toolSBRedo.Size = new System.Drawing.Size(23, 22);
            this.toolSBRedo.Text = "toolStripButton8";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSBFind
            // 
            this.toolSBFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBFind.Image = global::NotePad.Properties.Resources.find;
            this.toolSBFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBFind.Name = "toolSBFind";
            this.toolSBFind.Size = new System.Drawing.Size(23, 22);
            this.toolSBFind.Text = "toolStripButton9";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage0);
            this.tbControl.Controls.Add(this.tabMas);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 49);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(539, 336);
            this.tbControl.TabIndex = 3;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.richTextBox2);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Size = new System.Drawing.Size(531, 310);
            this.tabPage0.TabIndex = 2;
            this.tabPage0.Text = "tabPage0";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(531, 310);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // tabMas
            // 
            this.tabMas.Controls.Add(this.richTextBox1);
            this.tabMas.Location = new System.Drawing.Point(4, 22);
            this.tabMas.Name = "tabMas";
            this.tabMas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMas.Size = new System.Drawing.Size(531, 310);
            this.tabMas.TabIndex = 1;
            this.tabMas.Text = "+";
            this.tabMas.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 304);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 385);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotePad";
            this.Text = "NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotePad_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabMas.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSBNew;
        private System.Windows.Forms.ToolStripButton toolSBSave;
        private System.Windows.Forms.ToolStripButton toolSBOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolSBCut;
        private System.Windows.Forms.ToolStripButton toolSBCopy;
        private System.Windows.Forms.ToolStripButton toolSBPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolSBUndo;
        private System.Windows.Forms.ToolStripButton toolSBRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolSBFind;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabMas;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
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
            this.mWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mwWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mwTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.mLenguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mlEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mlSpanish = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabMas = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabMas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mSearch,
            this.mWindow,
            this.mLenguage,
            this.mQuestion});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
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
            resources.ApplyResources(this.mFile, "mFile");
            // 
            // mfNew
            // 
            this.mfNew.Image = global::NotePad.Properties.Resources._new;
            this.mfNew.Name = "mfNew";
            resources.ApplyResources(this.mfNew, "mfNew");
            // 
            // mfOpen
            // 
            this.mfOpen.Image = global::NotePad.Properties.Resources.open;
            this.mfOpen.Name = "mfOpen";
            resources.ApplyResources(this.mfOpen, "mfOpen");
            // 
            // mfSave
            // 
            this.mfSave.Image = global::NotePad.Properties.Resources.save;
            this.mfSave.Name = "mfSave";
            resources.ApplyResources(this.mfSave, "mfSave");
            // 
            // mfSaveAs
            // 
            this.mfSaveAs.Name = "mfSaveAs";
            resources.ApplyResources(this.mfSaveAs, "mfSaveAs");
            this.mfSaveAs.Click += new System.EventHandler(this.sAs);
            // 
            // mfClose
            // 
            this.mfClose.Image = global::NotePad.Properties.Resources.close;
            this.mfClose.Name = "mfClose";
            resources.ApplyResources(this.mfClose, "mfClose");
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
            resources.ApplyResources(this.mEdit, "mEdit");
            this.mEdit.Click += new System.EventHandler(this.mEdit_Click);
            // 
            // meCopy
            // 
            this.meCopy.Image = global::NotePad.Properties.Resources.copy;
            this.meCopy.Name = "meCopy";
            resources.ApplyResources(this.meCopy, "meCopy");
            // 
            // mePaste
            // 
            this.mePaste.Image = global::NotePad.Properties.Resources.paste;
            this.mePaste.Name = "mePaste";
            resources.ApplyResources(this.mePaste, "mePaste");
            // 
            // meCut
            // 
            this.meCut.Image = global::NotePad.Properties.Resources.cut;
            this.meCut.Name = "meCut";
            resources.ApplyResources(this.meCut, "meCut");
            // 
            // meRedo
            // 
            this.meRedo.Image = global::NotePad.Properties.Resources.Redo;
            this.meRedo.Name = "meRedo";
            resources.ApplyResources(this.meRedo, "meRedo");
            // 
            // meUndo
            // 
            this.meUndo.Image = global::NotePad.Properties.Resources.undo;
            this.meUndo.Name = "meUndo";
            resources.ApplyResources(this.meUndo, "meUndo");
            // 
            // mSearch
            // 
            this.mSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFind,
            this.msFindReplace});
            this.mSearch.Name = "mSearch";
            resources.ApplyResources(this.mSearch, "mSearch");
            // 
            // msFind
            // 
            this.msFind.Image = global::NotePad.Properties.Resources.find;
            this.msFind.Name = "msFind";
            resources.ApplyResources(this.msFind, "msFind");
            // 
            // msFindReplace
            // 
            this.msFindReplace.Image = global::NotePad.Properties.Resources.findReplace;
            this.msFindReplace.Name = "msFindReplace";
            resources.ApplyResources(this.msFindReplace, "msFindReplace");
            // 
            // mWindow
            // 
            this.mWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mwWindow,
            this.mwTabs});
            this.mWindow.Name = "mWindow";
            resources.ApplyResources(this.mWindow, "mWindow");
            // 
            // mwWindow
            // 
            this.mwWindow.Name = "mwWindow";
            resources.ApplyResources(this.mwWindow, "mwWindow");
            this.mwWindow.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // mwTabs
            // 
            this.mwTabs.Checked = true;
            this.mwTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.mwTabs, "mwTabs");
            this.mwTabs.Name = "mwTabs";
            this.mwTabs.Click += new System.EventHandler(this.tagPagesToolStripMenuItem_Click);
            // 
            // mLenguage
            // 
            this.mLenguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mlEnglish,
            this.mlSpanish});
            this.mLenguage.Name = "mLenguage";
            resources.ApplyResources(this.mLenguage, "mLenguage");
            // 
            // mlEnglish
            // 
            this.mlEnglish.Checked = true;
            this.mlEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.mlEnglish, "mlEnglish");
            this.mlEnglish.Name = "mlEnglish";
            this.mlEnglish.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // mlSpanish
            // 
            this.mlSpanish.Name = "mlSpanish";
            resources.ApplyResources(this.mlSpanish, "mlSpanish");
            this.mlSpanish.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // mQuestion
            // 
            this.mQuestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mqAbout});
            this.mQuestion.Name = "mQuestion";
            resources.ApplyResources(this.mQuestion, "mQuestion");
            // 
            // mqAbout
            // 
            this.mqAbout.Name = "mqAbout";
            resources.ApplyResources(this.mqAbout, "mqAbout");
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
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolSBNew
            // 
            this.toolSBNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBNew.Image = global::NotePad.Properties.Resources._new;
            resources.ApplyResources(this.toolSBNew, "toolSBNew");
            this.toolSBNew.Name = "toolSBNew";
            this.toolSBNew.Click += new System.EventHandler(this.nuevo);
            // 
            // toolSBSave
            // 
            this.toolSBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBSave.Image = global::NotePad.Properties.Resources.save;
            resources.ApplyResources(this.toolSBSave, "toolSBSave");
            this.toolSBSave.Name = "toolSBSave";
            this.toolSBSave.Click += new System.EventHandler(this.s);
            // 
            // toolSBOpen
            // 
            this.toolSBOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBOpen.Image = global::NotePad.Properties.Resources.open;
            resources.ApplyResources(this.toolSBOpen, "toolSBOpen");
            this.toolSBOpen.Name = "toolSBOpen";
            this.toolSBOpen.Click += new System.EventHandler(this.abrir);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolSBCut
            // 
            this.toolSBCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBCut.Image = global::NotePad.Properties.Resources.cut;
            resources.ApplyResources(this.toolSBCut, "toolSBCut");
            this.toolSBCut.Name = "toolSBCut";
            // 
            // toolSBCopy
            // 
            this.toolSBCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBCopy.Image = global::NotePad.Properties.Resources.copy;
            resources.ApplyResources(this.toolSBCopy, "toolSBCopy");
            this.toolSBCopy.Name = "toolSBCopy";
            // 
            // toolSBPaste
            // 
            this.toolSBPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBPaste.Image = global::NotePad.Properties.Resources.paste;
            resources.ApplyResources(this.toolSBPaste, "toolSBPaste");
            this.toolSBPaste.Name = "toolSBPaste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolSBUndo
            // 
            this.toolSBUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBUndo.Image = global::NotePad.Properties.Resources.undo;
            resources.ApplyResources(this.toolSBUndo, "toolSBUndo");
            this.toolSBUndo.Name = "toolSBUndo";
            // 
            // toolSBRedo
            // 
            this.toolSBRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBRedo.Image = global::NotePad.Properties.Resources.Redo;
            resources.ApplyResources(this.toolSBRedo, "toolSBRedo");
            this.toolSBRedo.Name = "toolSBRedo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolSBFind
            // 
            this.toolSBFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSBFind.Image = global::NotePad.Properties.Resources.find;
            resources.ApplyResources(this.toolSBFind, "toolSBFind");
            this.toolSBFind.Name = "toolSBFind";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage0);
            this.tbControl.Controls.Add(this.tabMas);
            resources.ApplyResources(this.tbControl, "tbControl");
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tabPage0
            // 
            resources.ApplyResources(this.tabPage0, "tabPage0");
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // tabMas
            // 
            this.tabMas.Controls.Add(this.richTextBox1);
            resources.ApplyResources(this.tabMas, "tabMas");
            this.tabMas.Name = "tabMas";
            this.tabMas.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // NotePad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotePad_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbControl.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem mWindow;
        private System.Windows.Forms.ToolStripMenuItem mwWindow;
        private System.Windows.Forms.ToolStripMenuItem mwTabs;
        private System.Windows.Forms.ToolStripMenuItem mLenguage;
        private System.Windows.Forms.ToolStripMenuItem mlEnglish;
        private System.Windows.Forms.ToolStripMenuItem mlSpanish;
    }
}


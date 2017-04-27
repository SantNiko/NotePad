namespace NotePad
{
    partial class FindForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lblFindCount = new System.Windows.Forms.Label();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReplaceClose = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReplaceFind = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabReplace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFind);
            this.tabControl.Controls.Add(this.tabReplace);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(259, 219);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.pictureBox1);
            this.tabFind.Controls.Add(this.btnClose);
            this.tabFind.Controls.Add(this.btnCount);
            this.tabFind.Controls.Add(this.btnFindNext);
            this.tabFind.Controls.Add(this.label1);
            this.tabFind.Controls.Add(this.tbFind);
            this.tabFind.Controls.Add(this.lblFindCount);
            this.tabFind.Location = new System.Drawing.Point(4, 22);
            this.tabFind.Name = "tabFind";
            this.tabFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabFind.Size = new System.Drawing.Size(251, 193);
            this.tabFind.TabIndex = 0;
            this.tabFind.Text = "Buscar";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NotePad.Properties.Resources.find;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(122, 142);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(122, 104);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(121, 21);
            this.btnCount.TabIndex = 19;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(122, 63);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(121, 23);
            this.btnFindNext.TabIndex = 18;
            this.btnFindNext.Text = "Encontrar Siguiente";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar:";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(83, 5);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(160, 20);
            this.tbFind.TabIndex = 14;
            // 
            // lblFindCount
            // 
            this.lblFindCount.AutoSize = true;
            this.lblFindCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFindCount.Location = new System.Drawing.Point(6, 175);
            this.lblFindCount.Name = "lblFindCount";
            this.lblFindCount.Size = new System.Drawing.Size(93, 13);
            this.lblFindCount.TabIndex = 5;
            this.lblFindCount.Text = "Contar: 0 matches";
            this.lblFindCount.Visible = false;
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.pictureBox2);
            this.tabReplace.Controls.Add(this.btnReplaceClose);
            this.tabReplace.Controls.Add(this.btnReplace);
            this.tabReplace.Controls.Add(this.btnReplaceFind);
            this.tabReplace.Controls.Add(this.label4);
            this.tabReplace.Controls.Add(this.label3);
            this.tabReplace.Controls.Add(this.tbReplaceFind);
            this.tabReplace.Controls.Add(this.tbReplace);
            this.tabReplace.Location = new System.Drawing.Point(4, 22);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplace.Size = new System.Drawing.Size(251, 193);
            this.tabReplace.TabIndex = 1;
            this.tabReplace.Text = "Reemplazar";
            this.tabReplace.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NotePad.Properties.Resources.findReplace;
            this.pictureBox2.Location = new System.Drawing.Point(12, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnReplaceClose
            // 
            this.btnReplaceClose.Location = new System.Drawing.Point(122, 142);
            this.btnReplaceClose.Name = "btnReplaceClose";
            this.btnReplaceClose.Size = new System.Drawing.Size(121, 23);
            this.btnReplaceClose.TabIndex = 11;
            this.btnReplaceClose.Text = "Cerrar";
            this.btnReplaceClose.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(122, 104);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(121, 21);
            this.btnReplace.TabIndex = 10;
            this.btnReplace.Text = "Remplazar";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnReplaceFind
            // 
            this.btnReplaceFind.Location = new System.Drawing.Point(122, 63);
            this.btnReplaceFind.Name = "btnReplaceFind";
            this.btnReplaceFind.Size = new System.Drawing.Size(121, 23);
            this.btnReplaceFind.TabIndex = 9;
            this.btnReplaceFind.Text = "Encontrar Siguiente";
            this.btnReplaceFind.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Remplazar:";
            // 
            // tbReplaceFind
            // 
            this.tbReplaceFind.Location = new System.Drawing.Point(83, 5);
            this.tbReplaceFind.Name = "tbReplaceFind";
            this.tbReplaceFind.Size = new System.Drawing.Size(160, 20);
            this.tbReplaceFind.TabIndex = 7;
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(83, 31);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(160, 20);
            this.tbReplace.TabIndex = 7;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 219);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.Text = "Buscar";
            this.tabControl.ResumeLayout(false);
            this.tabFind.ResumeLayout(false);
            this.tabFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.Label lblFindCount;
        private System.Windows.Forms.TabPage tabReplace;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReplaceClose;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReplaceFind;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFind;
    }
}
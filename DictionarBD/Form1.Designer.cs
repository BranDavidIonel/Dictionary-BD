namespace DictionarBD
{
    partial class Form1
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ENtoRO = new System.Windows.Forms.ToolStripMenuItem();
            this.ROtoEN = new System.Windows.Forms.ToolStripMenuItem();
            this.raportCuvinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l2 = new System.Windows.Forms.ListBox();
            this.l1 = new System.Windows.Forms.ListBox();
            this.cuvant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txInserareR = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.txInserareE = new System.Windows.Forms.TextBox();
            this.labelTxIn = new System.Windows.Forms.Label();
            this.labelTxTran = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.itemNone,
            this.ENtoRO,
            this.ROtoEN,
            this.raportCuvinteToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 41);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(538, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::DictionarBD.Properties.Resources.EXIT;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(68, 37);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // itemNone
            // 
            this.itemNone.AutoToolTip = true;
            this.itemNone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.itemNone.CheckOnClick = true;
            this.itemNone.DoubleClickEnabled = true;
            this.itemNone.Image = global::DictionarBD.Properties.Resources.RO_EN;
            this.itemNone.Name = "itemNone";
            this.itemNone.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.itemNone.Size = new System.Drawing.Size(49, 26);
            this.itemNone.Text = "R-E";
            // 
            // ENtoRO
            // 
            this.ENtoRO.AutoToolTip = true;
            this.ENtoRO.CheckOnClick = true;
            this.ENtoRO.DoubleClickEnabled = true;
            this.ENtoRO.Image = global::DictionarBD.Properties.Resources.EN_RO;
            this.ENtoRO.Name = "ENtoRO";
            this.ENtoRO.Size = new System.Drawing.Size(57, 37);
            this.ENtoRO.Text = "E-R";
            this.ENtoRO.Click += new System.EventHandler(this.ENtoRO_Click);
            // 
            // ROtoEN
            // 
            this.ROtoEN.Image = global::DictionarBD.Properties.Resources.RO_EN;
            this.ROtoEN.Name = "ROtoEN";
            this.ROtoEN.Size = new System.Drawing.Size(60, 37);
            this.ROtoEN.Text = "R-O";
            this.ROtoEN.Click += new System.EventHandler(this.ROtoEN_Click);
            // 
            // raportCuvinteToolStripMenuItem
            // 
            this.raportCuvinteToolStripMenuItem.Name = "raportCuvinteToolStripMenuItem";
            this.raportCuvinteToolStripMenuItem.Size = new System.Drawing.Size(98, 37);
            this.raportCuvinteToolStripMenuItem.Text = "Raport Cuvinte";
            this.raportCuvinteToolStripMenuItem.Click += new System.EventHandler(this.raportCuvinteToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::DictionarBD.Properties.Resources.user;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(60, 37);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // l2
            // 
            this.l2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.FormattingEnabled = true;
            this.l2.ItemHeight = 16;
            this.l2.Location = new System.Drawing.Point(317, 119);
            this.l2.Margin = new System.Windows.Forms.Padding(2);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(170, 228);
            this.l2.TabIndex = 8;
            // 
            // l1
            // 
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.FormattingEnabled = true;
            this.l1.ItemHeight = 16;
            this.l1.Location = new System.Drawing.Point(41, 119);
            this.l1.Margin = new System.Windows.Forms.Padding(2);
            this.l1.Name = "l1";
            this.l1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l1.Size = new System.Drawing.Size(169, 228);
            this.l1.TabIndex = 7;
            this.l1.SelectedIndexChanged += new System.EventHandler(this.l1_SelectedIndexChanged);
            // 
            // cuvant
            // 
            this.cuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuvant.Location = new System.Drawing.Point(41, 86);
            this.cuvant.Margin = new System.Windows.Forms.Padding(2);
            this.cuvant.Name = "cuvant";
            this.cuvant.Size = new System.Drawing.Size(160, 22);
            this.cuvant.TabIndex = 5;
            this.cuvant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cuvant_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inserare noua";
            // 
            // txInserareR
            // 
            this.txInserareR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txInserareR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInserareR.Location = new System.Drawing.Point(174, 422);
            this.txInserareR.Margin = new System.Windows.Forms.Padding(2);
            this.txInserareR.Name = "txInserareR";
            this.txInserareR.Size = new System.Drawing.Size(124, 22);
            this.txInserareR.TabIndex = 10;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdaugare.Location = new System.Drawing.Point(436, 419);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(67, 29);
            this.btnAdaugare.TabIndex = 11;
            this.btnAdaugare.Text = "&Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // txInserareE
            // 
            this.txInserareE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txInserareE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInserareE.Location = new System.Drawing.Point(174, 462);
            this.txInserareE.Margin = new System.Windows.Forms.Padding(2);
            this.txInserareE.Multiline = true;
            this.txInserareE.Name = "txInserareE";
            this.txInserareE.Size = new System.Drawing.Size(124, 39);
            this.txInserareE.TabIndex = 12;
            // 
            // labelTxIn
            // 
            this.labelTxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTxIn.AutoSize = true;
            this.labelTxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxIn.Location = new System.Drawing.Point(26, 428);
            this.labelTxIn.Name = "labelTxIn";
            this.labelTxIn.Size = new System.Drawing.Size(143, 16);
            this.labelTxIn.TabIndex = 13;
            this.labelTxIn.Text = "Cuvantul in romana:";
            // 
            // labelTxTran
            // 
            this.labelTxTran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTxTran.AutoSize = true;
            this.labelTxTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxTran.Location = new System.Drawing.Point(2, 462);
            this.labelTxTran.Name = "labelTxTran";
            this.labelTxTran.Size = new System.Drawing.Size(167, 16);
            this.labelTxTran.TabIndex = 14;
            this.labelTxTran.Text = "Traducerile in engleza:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(436, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.BackgroundImage = global::DictionarBD.Properties.Resources.switch__2_;
            this.btnSwitch.Location = new System.Drawing.Point(317, 428);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(51, 50);
            this.btnSwitch.TabIndex = 17;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::DictionarBD.Properties.Resources.cauta1;
            this.button1.Location = new System.Drawing.Point(243, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 38);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 522);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelTxTran);
            this.Controls.Add(this.labelTxIn);
            this.Controls.Add(this.txInserareE);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txInserareR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuvant);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Dictionar BD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemNone;
        private System.Windows.Forms.ToolStripMenuItem ENtoRO;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ListBox l2;
        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cuvant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem raportCuvinteToolStripMenuItem;
        private System.Windows.Forms.TextBox txInserareR;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox txInserareE;
        private System.Windows.Forms.Label labelTxIn;
        private System.Windows.Forms.Label labelTxTran;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem ROtoEN;
        private System.Windows.Forms.Button btnSwitch;
    }
}


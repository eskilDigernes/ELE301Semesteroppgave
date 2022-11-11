namespace sentral
{
    partial class Sentral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leggTilBrukerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avsluttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisBrukera = new System.Windows.Forms.Button();
            this.dgwBrukere = new System.Windows.Forms.DataGridView();
            this.kortid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etternavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyldigtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwHjelpetraad = new System.ComponentModel.BackgroundWorker();
            this.btnStartSentral = new System.Windows.Forms.Button();
            this.txtServerStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrukere)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(16, 29);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leggTilBrukerToolStripMenuItem,
            this.avsluttToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(72, 29);
            this.menuToolStripMenuItem1.Text = "Meny";
            // 
            // leggTilBrukerToolStripMenuItem
            // 
            this.leggTilBrukerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.leggTilBrukerToolStripMenuItem.Name = "leggTilBrukerToolStripMenuItem";
            this.leggTilBrukerToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.leggTilBrukerToolStripMenuItem.Text = "Brukera";
            this.leggTilBrukerToolStripMenuItem.Click += new System.EventHandler(this.leggTilBrukerToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.addUserToolStripMenuItem.Text = "Legg til";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.deleteUserToolStripMenuItem.Text = "Endre / slett";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // avsluttToolStripMenuItem
            // 
            this.avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            this.avsluttToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.avsluttToolStripMenuItem.Text = "Avslutt";
            this.avsluttToolStripMenuItem.Click += new System.EventHandler(this.avsluttToolStripMenuItem_Click);
            // 
            // btnVisBrukera
            // 
            this.btnVisBrukera.Location = new System.Drawing.Point(12, 60);
            this.btnVisBrukera.Name = "btnVisBrukera";
            this.btnVisBrukera.Size = new System.Drawing.Size(185, 40);
            this.btnVisBrukera.TabIndex = 2;
            this.btnVisBrukera.Text = "oppdater brukerliste";
            this.btnVisBrukera.UseVisualStyleBackColor = true;
            this.btnVisBrukera.Click += new System.EventHandler(this.btnVisBrukera_Click);
            // 
            // dgwBrukere
            // 
            this.dgwBrukere.AllowUserToDeleteRows = false;
            this.dgwBrukere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBrukere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kortid,
            this.fornavn,
            this.etternavn,
            this.epost,
            this.pin,
            this.gyldigtil});
            this.dgwBrukere.Location = new System.Drawing.Point(12, 120);
            this.dgwBrukere.Name = "dgwBrukere";
            this.dgwBrukere.ReadOnly = true;
            this.dgwBrukere.RowHeadersWidth = 62;
            this.dgwBrukere.RowTemplate.Height = 33;
            this.dgwBrukere.Size = new System.Drawing.Size(970, 451);
            this.dgwBrukere.TabIndex = 10;
            this.dgwBrukere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kortid
            // 
            this.kortid.HeaderText = "kortid:";
            this.kortid.MinimumWidth = 8;
            this.kortid.Name = "kortid";
            this.kortid.ReadOnly = true;
            this.kortid.Width = 80;
            // 
            // fornavn
            // 
            this.fornavn.HeaderText = "fornavn:";
            this.fornavn.MinimumWidth = 8;
            this.fornavn.Name = "fornavn";
            this.fornavn.ReadOnly = true;
            this.fornavn.Width = 150;
            // 
            // etternavn
            // 
            this.etternavn.HeaderText = "etternavn:";
            this.etternavn.MinimumWidth = 8;
            this.etternavn.Name = "etternavn";
            this.etternavn.ReadOnly = true;
            this.etternavn.Width = 150;
            // 
            // epost
            // 
            this.epost.HeaderText = "e-post:";
            this.epost.MinimumWidth = 8;
            this.epost.Name = "epost";
            this.epost.ReadOnly = true;
            this.epost.Width = 290;
            // 
            // pin
            // 
            this.pin.HeaderText = "pin:";
            this.pin.MinimumWidth = 8;
            this.pin.Name = "pin";
            this.pin.ReadOnly = true;
            this.pin.Width = 80;
            // 
            // gyldigtil
            // 
            this.gyldigtil.HeaderText = "gyldig til:";
            this.gyldigtil.MinimumWidth = 8;
            this.gyldigtil.Name = "gyldigtil";
            this.gyldigtil.ReadOnly = true;
            this.gyldigtil.Width = 150;
            // 
            // bwHjelpetraad
            // 
            this.bwHjelpetraad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwHjelpetraad_DoWork);
            this.bwHjelpetraad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwHjelpetraad_RunWorkerCompleted);
            // 
            // btnStartSentral
            // 
            this.btnStartSentral.Location = new System.Drawing.Point(412, 60);
            this.btnStartSentral.Name = "btnStartSentral";
            this.btnStartSentral.Size = new System.Drawing.Size(115, 40);
            this.btnStartSentral.TabIndex = 11;
            this.btnStartSentral.Text = "start sentral";
            this.btnStartSentral.UseVisualStyleBackColor = true;
            this.btnStartSentral.Click += new System.EventHandler(this.btnStartSentral_Click);
            // 
            // txtServerStatus
            // 
            this.txtServerStatus.Location = new System.Drawing.Point(533, 69);
            this.txtServerStatus.Name = "txtServerStatus";
            this.txtServerStatus.Size = new System.Drawing.Size(195, 31);
            this.txtServerStatus.TabIndex = 13;
            this.txtServerStatus.TextChanged += new System.EventHandler(this.txtServerStatus_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "status:";
            // 
            // Sentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerStatus);
            this.Controls.Add(this.btnStartSentral);
            this.Controls.Add(this.dgwBrukere);
            this.Controls.Add(this.btnVisBrukera);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sentral";
            this.Text = "Sentral";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrukere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem leggTilBrukerToolStripMenuItem;
        private ToolStripMenuItem avsluttToolStripMenuItem;
        private Button btnVisBrukera;
        private DataGridView dgwBrukere;
        private DataGridViewTextBoxColumn kortid;
        private DataGridViewTextBoxColumn fornavn;
        private DataGridViewTextBoxColumn etternavn;
        private DataGridViewTextBoxColumn epost;
        private DataGridViewTextBoxColumn pin;
        private DataGridViewTextBoxColumn gyldigtil;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwHjelpetraad;
        private Button btnStartSentral;
        private TextBox txtServerStatus;
        private Label label1;
    }
}
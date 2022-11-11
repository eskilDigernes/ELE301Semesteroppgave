namespace sentral
{
    partial class Form4
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
            this.txtRomNr = new System.Windows.Forms.TextBox();
            this.btnLeggTil = new System.Windows.Forms.Button();
            this.cbKortID = new System.Windows.Forms.ComboBox();
            this.btnEndre = new System.Windows.Forms.Button();
            this.btnSlett = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRomNr
            // 
            this.txtRomNr.Location = new System.Drawing.Point(53, 131);
            this.txtRomNr.Name = "txtRomNr";
            this.txtRomNr.Size = new System.Drawing.Size(150, 31);
            this.txtRomNr.TabIndex = 0;
            this.txtRomNr.TextChanged += new System.EventHandler(this.txtRomNr_TextChanged);
            // 
            // btnLeggTil
            // 
            this.btnLeggTil.Location = new System.Drawing.Point(53, 231);
            this.btnLeggTil.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnLeggTil.Name = "btnLeggTil";
            this.btnLeggTil.Size = new System.Drawing.Size(112, 34);
            this.btnLeggTil.TabIndex = 1;
            this.btnLeggTil.Text = "Legg til";
            this.btnLeggTil.UseVisualStyleBackColor = true;
            this.btnLeggTil.Click += new System.EventHandler(this.btnLeggTil_Click);
            // 
            // cbKortID
            // 
            this.cbKortID.FormattingEnabled = true;
            this.cbKortID.Location = new System.Drawing.Point(53, 75);
            this.cbKortID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.cbKortID.Name = "cbKortID";
            this.cbKortID.Size = new System.Drawing.Size(150, 33);
            this.cbKortID.TabIndex = 2;
            this.cbKortID.SelectedIndexChanged += new System.EventHandler(this.cbKortID_SelectedIndexChanged);
            // 
            // btnEndre
            // 
            this.btnEndre.Location = new System.Drawing.Point(198, 231);
            this.btnEndre.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnEndre.Name = "btnEndre";
            this.btnEndre.Size = new System.Drawing.Size(112, 34);
            this.btnEndre.TabIndex = 3;
            this.btnEndre.Text = "Endre";
            this.btnEndre.UseVisualStyleBackColor = true;
            this.btnEndre.Click += new System.EventHandler(this.btnEndre_Click);
            // 
            // btnSlett
            // 
            this.btnSlett.Location = new System.Drawing.Point(343, 231);
            this.btnSlett.Name = "btnSlett";
            this.btnSlett.Size = new System.Drawing.Size(112, 34);
            this.btnSlett.TabIndex = 4;
            this.btnSlett.Text = "Slett";
            this.btnSlett.UseVisualStyleBackColor = true;
            this.btnSlett.Click += new System.EventHandler(this.btnSlett_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(343, 337);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(112, 34);
            this.btnAvslutt.TabIndex = 5;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnSlett);
            this.Controls.Add(this.btnEndre);
            this.Controls.Add(this.cbKortID);
            this.Controls.Add(this.btnLeggTil);
            this.Controls.Add(this.txtRomNr);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRomNr;
        private Button btnLeggTil;
        private ComboBox cbKortID;
        private Button btnEndre;
        private Button btnSlett;
        private Button btnAvslutt;
    }
}
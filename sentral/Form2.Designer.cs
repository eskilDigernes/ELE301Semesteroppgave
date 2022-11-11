namespace sentral
{
    partial class LeggTilBruker
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
            this.txtEtternavn = new System.Windows.Forms.TextBox();
            this.txtKortID = new System.Windows.Forms.TextBox();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.txtFornavn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLeggTil = new System.Windows.Forms.Button();
            this.btnTom = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPickDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtEtternavn
            // 
            this.txtEtternavn.Location = new System.Drawing.Point(220, 133);
            this.txtEtternavn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtEtternavn.Name = "txtEtternavn";
            this.txtEtternavn.Size = new System.Drawing.Size(150, 31);
            this.txtEtternavn.TabIndex = 2;
            this.txtEtternavn.TextChanged += new System.EventHandler(this.txtEtternavn_TextChanged);
            // 
            // txtKortID
            // 
            this.txtKortID.Location = new System.Drawing.Point(220, 45);
            this.txtKortID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtKortID.Name = "txtKortID";
            this.txtKortID.Size = new System.Drawing.Size(150, 31);
            this.txtKortID.TabIndex = 0;
            this.txtKortID.TextChanged += new System.EventHandler(this.txtKortID_TextChanged);
            // 
            // txtEpost
            // 
            this.txtEpost.Location = new System.Drawing.Point(220, 177);
            this.txtEpost.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtEpost.Name = "txtEpost";
            this.txtEpost.Size = new System.Drawing.Size(150, 31);
            this.txtEpost.TabIndex = 3;
            this.txtEpost.TextChanged += new System.EventHandler(this.txtEpost_TextChanged);
            // 
            // txtFornavn
            // 
            this.txtFornavn.Location = new System.Drawing.Point(220, 89);
            this.txtFornavn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtFornavn.Name = "txtFornavn";
            this.txtFornavn.Size = new System.Drawing.Size(150, 31);
            this.txtFornavn.TabIndex = 1;
            this.txtFornavn.TextChanged += new System.EventHandler(this.txtFornavn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "etternavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "epost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "kort id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "gyldighet";
            // 
            // btnLeggTil
            // 
            this.btnLeggTil.Location = new System.Drawing.Point(59, 335);
            this.btnLeggTil.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnLeggTil.Name = "btnLeggTil";
            this.btnLeggTil.Size = new System.Drawing.Size(112, 34);
            this.btnLeggTil.TabIndex = 6;
            this.btnLeggTil.Text = "legg til";
            this.btnLeggTil.UseVisualStyleBackColor = true;
            this.btnLeggTil.Click += new System.EventHandler(this.btnLeggTil_Click);
            // 
            // btnTom
            // 
            this.btnTom.Location = new System.Drawing.Point(194, 335);
            this.btnTom.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnTom.Name = "btnTom";
            this.btnTom.Size = new System.Drawing.Size(112, 34);
            this.btnTom.TabIndex = 7;
            this.btnTom.Text = "tøm";
            this.btnTom.UseVisualStyleBackColor = true;
            this.btnTom.Click += new System.EventHandler(this.btnTom_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(329, 335);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(112, 34);
            this.btnAvbryt.TabIndex = 8;
            this.btnAvbryt.Text = "avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(220, 221);
            this.txtPin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(150, 31);
            this.txtPin.TabIndex = 4;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "pin";
            // 
            // dtPickDate
            // 
            this.dtPickDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickDate.Location = new System.Drawing.Point(220, 265);
            this.dtPickDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dtPickDate.Name = "dtPickDate";
            this.dtPickDate.Size = new System.Drawing.Size(150, 31);
            this.dtPickDate.TabIndex = 5;
            this.dtPickDate.ValueChanged += new System.EventHandler(this.dtPickDate_ValueChanged);
            // 
            // LeggTilBruker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.dtPickDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnTom);
            this.Controls.Add(this.btnLeggTil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFornavn);
            this.Controls.Add(this.txtEpost);
            this.Controls.Add(this.txtKortID);
            this.Controls.Add(this.txtEtternavn);
            this.Name = "LeggTilBruker";
            this.Text = "Legg til bruker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEtternavn;
        private TextBox txtKortID;
        private TextBox txtEpost;
        private TextBox txtFornavn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLeggTil;
        private Button btnTom;
        private Button btnAvbryt;
        private TextBox txtPin;
        private Label label7;
        private DateTimePicker dtPickDate;
    }
}
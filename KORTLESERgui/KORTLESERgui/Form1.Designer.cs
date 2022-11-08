namespace KORTLESERgui
{
    partial class Form1
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
            this.btnLoggInn = new System.Windows.Forms.Button();
            this.txtKortID = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.cbAlleSeriellePorter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLogg = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDørLåstUlåst = new System.Windows.Forms.TextBox();
            this.txtDørÅpenLukket = new System.Windows.Forms.TextBox();
            this.txtAlarm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Alarm = new System.Windows.Forms.Label();
            this.btnSendMelding = new System.Windows.Forms.Button();
            this.bwSeriellKommunikasjon = new System.ComponentModel.BackgroundWorker();
            this.txtMottattTekst = new System.Windows.Forms.TextBox();
            this.txtTekstSomSkalSendes = new System.Windows.Forms.TextBox();
            this.bwHjelpetråd = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnLoggInn
            // 
            this.btnLoggInn.Location = new System.Drawing.Point(848, 163);
            this.btnLoggInn.Name = "btnLoggInn";
            this.btnLoggInn.Size = new System.Drawing.Size(92, 50);
            this.btnLoggInn.TabIndex = 0;
            this.btnLoggInn.Text = "Logg inn";
            this.btnLoggInn.UseVisualStyleBackColor = true;
            this.btnLoggInn.Click += new System.EventHandler(this.btnLoggInn_Click);
            // 
            // txtKortID
            // 
            this.txtKortID.Location = new System.Drawing.Point(848, 89);
            this.txtKortID.Name = "txtKortID";
            this.txtKortID.Size = new System.Drawing.Size(190, 31);
            this.txtKortID.TabIndex = 1;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(848, 126);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(190, 31);
            this.txtPIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "KortID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(946, 163);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(92, 50);
            this.btnAvbryt.TabIndex = 0;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // cbAlleSeriellePorter
            // 
            this.cbAlleSeriellePorter.FormattingEnabled = true;
            this.cbAlleSeriellePorter.Location = new System.Drawing.Point(136, 410);
            this.cbAlleSeriellePorter.Name = "cbAlleSeriellePorter";
            this.cbAlleSeriellePorter.Size = new System.Drawing.Size(182, 33);
            this.cbAlleSeriellePorter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "COM port:";
            // 
            // lbLogg
            // 
            this.lbLogg.FormattingEnabled = true;
            this.lbLogg.ItemHeight = 25;
            this.lbLogg.Location = new System.Drawing.Point(34, 18);
            this.lbLogg.Name = "lbLogg";
            this.lbLogg.Size = new System.Drawing.Size(701, 354);
            this.lbLogg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(773, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Velkommen til KORTLESER!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vennligst logg inn...";
            // 
            // txtDørLåstUlåst
            // 
            this.txtDørLåstUlåst.Location = new System.Drawing.Point(895, 396);
            this.txtDørLåstUlåst.Name = "txtDørLåstUlåst";
            this.txtDørLåstUlåst.Size = new System.Drawing.Size(80, 31);
            this.txtDørLåstUlåst.TabIndex = 8;
            // 
            // txtDørÅpenLukket
            // 
            this.txtDørÅpenLukket.Location = new System.Drawing.Point(981, 396);
            this.txtDørÅpenLukket.Name = "txtDørÅpenLukket";
            this.txtDørÅpenLukket.Size = new System.Drawing.Size(80, 31);
            this.txtDørÅpenLukket.TabIndex = 8;
            // 
            // txtAlarm
            // 
            this.txtAlarm.Location = new System.Drawing.Point(895, 445);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(80, 31);
            this.txtAlarm.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(789, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dørtilstand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(897, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 9;
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Location = new System.Drawing.Point(804, 448);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(59, 25);
            this.Alarm.TabIndex = 9;
            this.Alarm.Text = "Alarm";
            // 
            // btnSendMelding
            // 
            this.btnSendMelding.Location = new System.Drawing.Point(870, 252);
            this.btnSendMelding.Name = "btnSendMelding";
            this.btnSendMelding.Size = new System.Drawing.Size(168, 34);
            this.btnSendMelding.TabIndex = 10;
            this.btnSendMelding.Text = "Send melding";
            this.btnSendMelding.UseVisualStyleBackColor = true;
            this.btnSendMelding.Click += new System.EventHandler(this.btnSendMelding_Click);
            // 
            // bwSeriellKommunikasjon
            // 
            this.bwSeriellKommunikasjon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSeriellKommunikasjon_DoWork);
            this.bwSeriellKommunikasjon.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSeriellKommunikasjon_RunWorkerCompleted);
            // 
            // txtMottattTekst
            // 
            this.txtMottattTekst.Location = new System.Drawing.Point(805, 292);
            this.txtMottattTekst.Name = "txtMottattTekst";
            this.txtMottattTekst.ReadOnly = true;
            this.txtMottattTekst.Size = new System.Drawing.Size(233, 31);
            this.txtMottattTekst.TabIndex = 11;
            // 
            // txtTekstSomSkalSendes
            // 
            this.txtTekstSomSkalSendes.Location = new System.Drawing.Point(804, 329);
            this.txtTekstSomSkalSendes.Name = "txtTekstSomSkalSendes";
            this.txtTekstSomSkalSendes.Size = new System.Drawing.Size(233, 31);
            this.txtTekstSomSkalSendes.TabIndex = 11;
            // 
            // bwHjelpetråd
            // 
            this.bwHjelpetråd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwHjelpetråd_DoWork);
            this.bwHjelpetråd.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwHjelpetråd_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 578);
            this.Controls.Add(this.txtTekstSomSkalSendes);
            this.Controls.Add(this.txtMottattTekst);
            this.Controls.Add(this.btnSendMelding);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlarm);
            this.Controls.Add(this.txtDørÅpenLukket);
            this.Controls.Add(this.txtDørLåstUlåst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLogg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAlleSeriellePorter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtKortID);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnLoggInn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Klient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLoggInn;
        private TextBox txtKortID;
        private TextBox txtPIN;
        private Label label1;
        private Label label2;
        private Button btnAvbryt;
        private ComboBox cbAlleSeriellePorter;
        private Label label3;
        private ListBox lbLogg;
        private Label label4;
        private Label label5;
        private TextBox txtDørLåstUlåst;
        private TextBox txtDørÅpenLukket;
        private TextBox txtAlarm;
        private Label label6;
        private Label label7;
        private Label Alarm;
        private Button btnSendMelding;
        private System.ComponentModel.BackgroundWorker bwSeriellKommunikasjon;
        private System.ComponentModel.BackgroundWorker bwHjelpetråd;
        private TextBox txtMottattTekst;
        private TextBox txtTekstSomSkalSendes;
    }
}
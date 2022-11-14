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
            this.txtKortID = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.txtKortlesernr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKortID
            // 
            this.txtKortID.Location = new System.Drawing.Point(706, 127);
            this.txtKortID.Margin = new System.Windows.Forms.Padding(2);
            this.txtKortID.Name = "txtKortID";
            this.txtKortID.ReadOnly = true;
            this.txtKortID.Size = new System.Drawing.Size(153, 27);
            this.txtKortID.TabIndex = 1;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(706, 169);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(153, 27);
            this.txtPIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "KortID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // cbAlleSeriellePorter
            // 
            this.cbAlleSeriellePorter.FormattingEnabled = true;
            this.cbAlleSeriellePorter.Location = new System.Drawing.Point(109, 328);
            this.cbAlleSeriellePorter.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlleSeriellePorter.Name = "cbAlleSeriellePorter";
            this.cbAlleSeriellePorter.Size = new System.Drawing.Size(146, 28);
            this.cbAlleSeriellePorter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "COM port:";
            // 
            // lbLogg
            // 
            this.lbLogg.FormattingEnabled = true;
            this.lbLogg.ItemHeight = 20;
            this.lbLogg.Location = new System.Drawing.Point(27, 14);
            this.lbLogg.Margin = new System.Windows.Forms.Padding(2);
            this.lbLogg.Name = "lbLogg";
            this.lbLogg.Size = new System.Drawing.Size(562, 284);
            this.lbLogg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(618, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Velkommen til KORTLESER!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tast inn kortlesernr og aktiver";
            // 
            // txtDørLåstUlåst
            // 
            this.txtDørLåstUlåst.Location = new System.Drawing.Point(716, 375);
            this.txtDørLåstUlåst.Margin = new System.Windows.Forms.Padding(2);
            this.txtDørLåstUlåst.Name = "txtDørLåstUlåst";
            this.txtDørLåstUlåst.Size = new System.Drawing.Size(65, 27);
            this.txtDørLåstUlåst.TabIndex = 8;
            // 
            // txtDørÅpenLukket
            // 
            this.txtDørÅpenLukket.Location = new System.Drawing.Point(785, 375);
            this.txtDørÅpenLukket.Margin = new System.Windows.Forms.Padding(2);
            this.txtDørÅpenLukket.Name = "txtDørÅpenLukket";
            this.txtDørÅpenLukket.Size = new System.Drawing.Size(65, 27);
            this.txtDørÅpenLukket.TabIndex = 8;
            // 
            // txtAlarm
            // 
            this.txtAlarm.Location = new System.Drawing.Point(716, 414);
            this.txtAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(65, 27);
            this.txtAlarm.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dørtilstand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 9;
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Location = new System.Drawing.Point(643, 417);
            this.Alarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(49, 20);
            this.Alarm.TabIndex = 9;
            this.Alarm.Text = "Alarm";
            // 
            // btnSendMelding
            // 
            this.btnSendMelding.Location = new System.Drawing.Point(696, 260);
            this.btnSendMelding.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMelding.Name = "btnSendMelding";
            this.btnSendMelding.Size = new System.Drawing.Size(134, 27);
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
            this.txtMottattTekst.Location = new System.Drawing.Point(644, 292);
            this.txtMottattTekst.Margin = new System.Windows.Forms.Padding(2);
            this.txtMottattTekst.Name = "txtMottattTekst";
            this.txtMottattTekst.ReadOnly = true;
            this.txtMottattTekst.Size = new System.Drawing.Size(187, 27);
            this.txtMottattTekst.TabIndex = 11;
            // 
            // txtTekstSomSkalSendes
            // 
            this.txtTekstSomSkalSendes.Location = new System.Drawing.Point(643, 322);
            this.txtTekstSomSkalSendes.Margin = new System.Windows.Forms.Padding(2);
            this.txtTekstSomSkalSendes.Name = "txtTekstSomSkalSendes";
            this.txtTekstSomSkalSendes.Size = new System.Drawing.Size(187, 27);
            this.txtTekstSomSkalSendes.TabIndex = 11;
            // 
            // bwHjelpetråd
            // 
            this.bwHjelpetråd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwHjelpetråd_DoWork);
            this.bwHjelpetråd.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwHjelpetråd_RunWorkerCompleted);
            // 
            // txtKortlesernr
            // 
            this.txtKortlesernr.Location = new System.Drawing.Point(706, 74);
            this.txtKortlesernr.Margin = new System.Windows.Forms.Padding(2);
            this.txtKortlesernr.Name = "txtKortlesernr";
            this.txtKortlesernr.ReadOnly = true;
            this.txtKortlesernr.Size = new System.Drawing.Size(153, 27);
            this.txtKortlesernr.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kortlesernr:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKortlesernr);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kortleser";
            this.Load += new System.EventHandler(this.Klient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtKortID;
        private TextBox txtPIN;
        private Label label1;
        private Label label2;
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
        private TextBox txtKortlesernr;
        private Label label8;
    }
}
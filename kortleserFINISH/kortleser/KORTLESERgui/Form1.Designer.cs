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
            this.components = new System.ComponentModel.Container();
            this.txtKortID = new System.Windows.Forms.TextBox();
            this.txtKortlesernr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlleSeriellePorter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bwSeriellKommunikasjon = new System.ComponentModel.BackgroundWorker();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.txtTid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAlarm = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDørLåstUlåst = new System.Windows.Forms.TextBox();
            this.txtDørÅpenLukket = new System.Windows.Forms.TextBox();
            this.txtSisteID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKortID
            // 
            this.txtKortID.Location = new System.Drawing.Point(78, 113);
            this.txtKortID.Margin = new System.Windows.Forms.Padding(2);
            this.txtKortID.MaxLength = 4;
            this.txtKortID.Name = "txtKortID";
            this.txtKortID.ReadOnly = true;
            this.txtKortID.Size = new System.Drawing.Size(122, 23);
            this.txtKortID.TabIndex = 1;
            // 
            // txtKortlesernr
            // 
            this.txtKortlesernr.Location = new System.Drawing.Point(78, 86);
            this.txtKortlesernr.Margin = new System.Windows.Forms.Padding(2);
            this.txtKortlesernr.MaxLength = 4;
            this.txtKortlesernr.Name = "txtKortlesernr";
            this.txtKortlesernr.Size = new System.Drawing.Size(122, 23);
            this.txtKortlesernr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "KortID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // cbAlleSeriellePorter
            // 
            this.cbAlleSeriellePorter.FormattingEnabled = true;
            this.cbAlleSeriellePorter.Location = new System.Drawing.Point(78, 59);
            this.cbAlleSeriellePorter.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlleSeriellePorter.Name = "cbAlleSeriellePorter";
            this.cbAlleSeriellePorter.Size = new System.Drawing.Size(122, 23);
            this.cbAlleSeriellePorter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "COM port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Velkommen til KORTLESER!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Venter på tilkobling";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 9;
            // 
            // bwSeriellKommunikasjon
            // 
            this.bwSeriellKommunikasjon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSeriellKommunikasjon_DoWork);
            this.bwSeriellKommunikasjon.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSeriellKommunikasjon_RunWorkerCompleted);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(78, 140);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(122, 23);
            this.txtPIN.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kortlesernr";
            // 
            // timerTick
            // 
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(174, 31);
            this.txtTid.Name = "txtTid";
            this.txtTid.ReadOnly = true;
            this.txtTid.Size = new System.Drawing.Size(26, 23);
            this.txtTid.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fyll inn relevant data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 276);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Alarm";
            // 
            // lbAlarm
            // 
            this.lbAlarm.FormattingEnabled = true;
            this.lbAlarm.ItemHeight = 15;
            this.lbAlarm.Location = new System.Drawing.Point(78, 266);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(122, 34);
            this.lbAlarm.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dør status";
            // 
            // txtDørLåstUlåst
            // 
            this.txtDørLåstUlåst.Location = new System.Drawing.Point(78, 238);
            this.txtDørLåstUlåst.Margin = new System.Windows.Forms.Padding(2);
            this.txtDørLåstUlåst.MaxLength = 4;
            this.txtDørLåstUlåst.Name = "txtDørLåstUlåst";
            this.txtDørLåstUlåst.ReadOnly = true;
            this.txtDørLåstUlåst.Size = new System.Drawing.Size(122, 23);
            this.txtDørLåstUlåst.TabIndex = 21;
            this.txtDørLåstUlåst.Text = "Låst";
            // 
            // txtDørÅpenLukket
            // 
            this.txtDørÅpenLukket.Location = new System.Drawing.Point(78, 211);
            this.txtDørÅpenLukket.Margin = new System.Windows.Forms.Padding(2);
            this.txtDørÅpenLukket.MaxLength = 4;
            this.txtDørÅpenLukket.Name = "txtDørÅpenLukket";
            this.txtDørÅpenLukket.ReadOnly = true;
            this.txtDørÅpenLukket.Size = new System.Drawing.Size(122, 23);
            this.txtDørÅpenLukket.TabIndex = 22;
            this.txtDørÅpenLukket.Text = "Lukket";
            // 
            // txtSisteID
            // 
            this.txtSisteID.Location = new System.Drawing.Point(78, 184);
            this.txtSisteID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSisteID.MaxLength = 4;
            this.txtSisteID.Name = "txtSisteID";
            this.txtSisteID.ReadOnly = true;
            this.txtSisteID.Size = new System.Drawing.Size(122, 23);
            this.txtSisteID.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Siste ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 307);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSisteID);
            this.Controls.Add(this.txtDørÅpenLukket);
            this.Controls.Add(this.txtDørLåstUlåst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbAlarm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAlleSeriellePorter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKortlesernr);
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
        private TextBox txtKortlesernr;
        private Label label1;
        private Label label2;
        private ComboBox cbAlleSeriellePorter;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private System.ComponentModel.BackgroundWorker bwSeriellKommunikasjon;
        private TextBox txtPIN;
        private Label label8;
        private System.Windows.Forms.Timer timerTick;
        private TextBox txtTid;
        private Label label6;
        private Label label9;
        private ListBox lbAlarm;
        private Label label10;
        private TextBox txtDørLåstUlåst;
        private TextBox txtDørÅpenLukket;
        private TextBox txtSisteID;
        private Label label11;
    }
}
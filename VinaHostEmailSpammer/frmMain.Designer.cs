namespace VinaHostEmailSpammer
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.txtListMail = new System.Windows.Forms.TextBox();
			this.cbxIsHtml = new System.Windows.Forms.CheckBox();
			this.rtbMailContent = new System.Windows.Forms.RichTextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.cbxDelaySeconds = new System.Windows.Forms.NumericUpDown();
			this.tmrSendMail = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.cbxDelaySeconds)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtListMail
			// 
			this.txtListMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtListMail.Location = new System.Drawing.Point(23, 41);
			this.txtListMail.Multiline = true;
			this.txtListMail.Name = "txtListMail";
			this.txtListMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtListMail.Size = new System.Drawing.Size(235, 305);
			this.txtListMail.TabIndex = 0;
			this.txtListMail.TextChanged += new System.EventHandler(this.txtListMail_TextChanged);
			// 
			// cbxIsHtml
			// 
			this.cbxIsHtml.AutoSize = true;
			this.cbxIsHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxIsHtml.Location = new System.Drawing.Point(567, 67);
			this.cbxIsHtml.Name = "cbxIsHtml";
			this.cbxIsHtml.Size = new System.Drawing.Size(77, 20);
			this.cbxIsHtml.TabIndex = 3;
			this.cbxIsHtml.Text = "Is HTML";
			this.cbxIsHtml.UseVisualStyleBackColor = true;
			// 
			// rtbMailContent
			// 
			this.rtbMailContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbMailContent.Location = new System.Drawing.Point(285, 93);
			this.rtbMailContent.Name = "rtbMailContent";
			this.rtbMailContent.Size = new System.Drawing.Size(359, 253);
			this.rtbMailContent.TabIndex = 2;
			this.rtbMailContent.Text = "";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(531, 371);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(123, 61);
			this.btnSend.TabIndex = 5;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtSubject
			// 
			this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubject.Location = new System.Drawing.Point(285, 41);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(359, 22);
			this.txtSubject.TabIndex = 1;
			// 
			// cbxDelaySeconds
			// 
			this.cbxDelaySeconds.Location = new System.Drawing.Point(11, 35);
			this.cbxDelaySeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.cbxDelaySeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.cbxDelaySeconds.Name = "cbxDelaySeconds";
			this.cbxDelaySeconds.Size = new System.Drawing.Size(120, 20);
			this.cbxDelaySeconds.TabIndex = 4;
			this.cbxDelaySeconds.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// tmrSendMail
			// 
			this.tmrSendMail.Tick += new System.EventHandler(this.tmrSendMail_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(285, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mail Content:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Receiver Email Addresses:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Delay Seconds:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Email Subject:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(274, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(380, 354);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 354);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtPassword);
			this.groupBox3.Controls.Add(this.txtEmail);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.cbxDelaySeconds);
			this.groupBox3.Location = new System.Drawing.Point(12, 366);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(510, 66);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(155, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(155, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Email Address:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(262, 39);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(236, 20);
			this.txtPassword.TabIndex = 10;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(262, 12);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(236, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(666, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(74, 17);
			this.lblStatus.Text = "Email Sent: 0";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 461);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.rtbMailContent);
			this.Controls.Add(this.cbxIsHtml);
			this.Controls.Add(this.txtListMail);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "VinaHost Email Spammer";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cbxDelaySeconds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtListMail;
		private System.Windows.Forms.CheckBox cbxIsHtml;
		private System.Windows.Forms.RichTextBox rtbMailContent;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.NumericUpDown cbxDelaySeconds;
		private System.Windows.Forms.Timer tmrSendMail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}


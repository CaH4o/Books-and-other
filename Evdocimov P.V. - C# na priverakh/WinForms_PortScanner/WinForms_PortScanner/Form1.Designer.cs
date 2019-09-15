namespace WinForms_PortScanner
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
			this.label1 = new System.Windows.Forms.Label();
			this.nBeginPort = new System.Windows.Forms.NumericUpDown();
			this.nEndPort = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.tIPAddress = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nEndPort)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP Address";
			// 
			// nBeginPort
			// 
			this.nBeginPort.Location = new System.Drawing.Point(238, 9);
			this.nBeginPort.Name = "nBeginPort";
			this.nBeginPort.Size = new System.Drawing.Size(59, 20);
			this.nBeginPort.TabIndex = 1;
			// 
			// nEndPort
			// 
			this.nEndPort.Location = new System.Drawing.Point(321, 9);
			this.nEndPort.Name = "nEndPort";
			this.nEndPort.Size = new System.Drawing.Size(59, 20);
			this.nEndPort.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(386, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Scaning";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(15, 35);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(457, 227);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(179, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Ports: from";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(303, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "to";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(15, 268);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(460, 23);
			this.progressBar1.TabIndex = 7;
			// 
			// tIPAddress
			// 
			this.tIPAddress.Location = new System.Drawing.Point(72, 9);
			this.tIPAddress.Name = "tIPAddress";
			this.tIPAddress.Size = new System.Drawing.Size(101, 20);
			this.tIPAddress.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 302);
			this.Controls.Add(this.tIPAddress);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nEndPort);
			this.Controls.Add(this.nBeginPort);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "IP Address";
			((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nEndPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nBeginPort;
		private System.Windows.Forms.NumericUpDown nEndPort;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox tIPAddress;
	}
}


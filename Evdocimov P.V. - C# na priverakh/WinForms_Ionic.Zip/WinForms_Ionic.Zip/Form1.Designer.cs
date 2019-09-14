namespace WinForms_Ionic.Zip
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button_Select = new System.Windows.Forms.Button();
			this.button_Save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 24);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button_Select
			// 
			this.button_Select.Location = new System.Drawing.Point(24, 61);
			this.button_Select.Name = "button_Select";
			this.button_Select.Size = new System.Drawing.Size(123, 23);
			this.button_Select.TabIndex = 1;
			this.button_Select.Text = "Select the folder";
			this.button_Select.UseVisualStyleBackColor = true;
			this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(168, 61);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(90, 23);
			this.button_Save.TabIndex = 2;
			this.button_Save.Text = "Save as";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 115);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.button_Select);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Archiving";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button_Select;
		private System.Windows.Forms.Button button_Save;
	}
}


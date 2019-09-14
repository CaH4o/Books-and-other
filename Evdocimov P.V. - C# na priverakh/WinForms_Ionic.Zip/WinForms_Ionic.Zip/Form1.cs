using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace WinForms_Ionic.Zip
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		FolderBrowserDialog fo = new FolderBrowserDialog();

		private void button_Select_Click(object sender, EventArgs e)
		{


			if (fo.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = fo.SelectedPath;
			}
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Zip files (*.zip)|*.zip";

			if (textBox1.Text != "" && sfd.ShowDialog() == DialogResult.OK)
			{
				ZipFile zf = new ZipFile(sfd.FileName);
				zf.AddDirectory(fo.SelectedPath);
				zf.Save();
				MessageBox.Show("Archiving was successful.", "Done");
			}
		}
	}
}

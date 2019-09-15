using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_CurrencyConverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			listBox1.SetSelected(0, true);
			listBox2.SetSelected(1, true);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string from = listBox1.SelectedItem.ToString();
			string to = listBox2.SelectedItem.ToString();
		
			if (webBrowser1.IsOffline == true)
			{
				MessageBox.Show("Нет подключения к интернету.");
			}
			else if (from == "" || to == "")
			{
				MessageBox.Show("Выберите валюту конвертации", "Внимание!");
			}
			else if (from == to)
			{
				MessageBox.Show("Это одна и та же валюта!", "Внимание!");
			}
			else if (textBox1.Text == "")
			{
				MessageBox.Show("Введите количество валюты!", "Внимание!");
			}
			else
			{
				string TargerURL = "https://www.google.ru/search?q=" +
				textBox1.Text + " " + from + " %D0%B2 " + to;
				webBrowser1.Navigate(TargerURL);
			}
		}
	}
}

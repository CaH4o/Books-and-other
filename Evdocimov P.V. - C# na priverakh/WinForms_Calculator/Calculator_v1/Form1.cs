using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v1
{
	enum StateCacl {
		NoN,
		HasLeftOperand,
		HasZnak,
		HasRightOperand
	}
	enum Oper {
		Plus,
		Minus,
		Multiply,
		Divide
	}

	public partial class Form1 : Form
	{
		float a, b, c;
		Oper oper;
		StateCacl state;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			c = 0;
			textBox1.Text = c.ToString();
			state = StateCacl.NoN;
		}

		//-------------------------  0, 1-9  -------------------------------//

		private void button_Zero_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand)
				textBox1.Text += 0;
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 0;
		}

		private void button_One_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 1;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "1";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 1;
		}

		private void button_Two_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 2;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "2";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 2;
		}

		private void button_Three_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 3;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "3";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 3;
		}

		private void button_Four_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 4;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "4";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 4;
		}

		private void button_Five_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 5;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "5";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 5;
		}

		private void button_six_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 6;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "6";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 6;
		}

		private void button_Seven_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 7;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "7";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 7;
		}

		private void button_Eight_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 8;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "8";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 8;
		}

		private void button_Nine_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand || state == StateCacl.HasZnak)
			{
				textBox1.Text += 9;
				state = StateCacl.HasRightOperand;
			}
			else if (state == StateCacl.NoN)
			{
				textBox1.Text = "9";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasLeftOperand)
				textBox1.Text += 9;
		}

		//-------------------------   +, -, /, *   -------------------------------//

		private void button_Plus_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasLeftOperand)
			{
				a = float.Parse(textBox1.Text);
				textBox1.Text += "+";
				oper = Oper.Plus;
				state = StateCacl.HasZnak;
			}
			else if (state == StateCacl.HasZnak)
			{
				textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
				textBox1.Text += "+";
				oper = Oper.Plus;
			}
		}

		private void button_Minus_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasLeftOperand)
			{
				a = float.Parse(textBox1.Text);
				textBox1.Text += "-";
				oper = Oper.Minus;
				state = StateCacl.HasZnak;
			}
			else if (state == StateCacl.HasZnak)
			{
				textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
				textBox1.Text += "-";
				oper = Oper.Minus;
			}
		}

		private void button_Mult_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasLeftOperand)
			{
				a = float.Parse(textBox1.Text);
				textBox1.Text += "*";
				oper = Oper.Multiply;
				state = StateCacl.HasZnak;
			}
			else if (state == StateCacl.HasZnak)
			{
				textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
				textBox1.Text += "*";
				oper = Oper.Multiply;
			}
		}
		
		private void button_Dev_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasLeftOperand)
			{
				a = float.Parse(textBox1.Text);
				textBox1.Text +=  "/";
				oper = Oper.Divide;
				state = StateCacl.HasZnak;
			}
			else if (state == StateCacl.HasZnak)
			{
				textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
				textBox1.Text += "/";
				oper = Oper.Divide;
			}
		}

		//-------------------------   Other   -------------------------------//

		//+/-
		private void button_Plus_Minus_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasLeftOperand && textBox1.Text != "0")
			{
				if (textBox1.Text.Substring(0, 1) == "-")
				{
					textBox1.Text = textBox1.Text.Replace("-", "");
				}
				else
				{
					textBox1.Text = "-" + textBox1.Text;
				}
			}
			else if (state == StateCacl.HasRightOperand)
			{
				if (textBox1.Text.Substring(GetOperatorIndex() + 1, 1) == "-")
				{
					textBox1.Text = textBox1.Text.Remove(GetOperatorIndex() + 1, 1);
				}
				else
				{
					textBox1.Text = textBox1.Text.Insert(GetOperatorIndex() + 1, "-");
				}
			}


		}

		//.
		private void button_dot_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.NoN)
			{
				textBox1.Text = "0,";
				state = StateCacl.HasLeftOperand;
			}
			else if (state == StateCacl.HasZnak)
			{
				textBox1.Text += "0,";
				state = StateCacl.HasRightOperand;
			}
			else
			{
				char[] Ch = { ',', '.' };

				if (textBox1.Text.IndexOfAny(Ch) == -1)
					textBox1.Text += ",";
			}

		}

		//=
		private void button_Result_Click(object sender, EventArgs e)
		{
			if (state == StateCacl.HasRightOperand)
			{
				int operInd = GetOperatorIndex();
				b = float.Parse(textBox1.Text.Substring(operInd + 1, textBox1.TextLength - operInd - 1));

				Calculate();
				textBox1.Text = string.Format("{0:f2}", c.ToString()) ;
				a = c;
				state = StateCacl.HasLeftOperand;
			}
		}

		//C
		private void button_C_Click(object sender, EventArgs e)
		{
			state = StateCacl.NoN;
			c = 0;
			textBox1.Text = c.ToString();
		}

		//<--
		private void button_BackSpace_Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength != 0)
			{
				if (state == StateCacl.HasLeftOperand)
				{
					if (textBox1.TextLength - 1 == 0)
					{
						textBox1.Clear();
						state = StateCacl.NoN;
					}
					else
					{
						textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
					}
				}
				else if (state == StateCacl.HasZnak)
				{
					textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
					state = StateCacl.HasLeftOperand;
				}
				else if (state == StateCacl.HasRightOperand)
				{
					if (textBox1.TextLength - 1 == GetOperatorIndex() + 1)
					{
						state = StateCacl.HasZnak;
					}

					textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
				}
			}
		}

		private void Calculate()
		{
			if (b == 0) 
				oper = Oper.Multiply;

			switch (oper)
			{
				case Oper.Plus:		c = a + b; break;
				case Oper.Minus:	c = a - b; break;
				case Oper.Multiply:	c = a * b; break;
				case Oper.Divide:	c = a / b; break;
				default: break;
			}
		}

		private int GetOperatorIndex()
		{
			char[] Ch = { '+', '-', '*', '/' };
			return textBox1.Text.IndexOfAny(Ch, 1);
		}
	}
}

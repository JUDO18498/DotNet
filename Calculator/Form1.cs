using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{ public partial class Form1 : Form
	{
		Double resultvalue = 0;
		String operation = "";
		bool isoperationperformed = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button_click(object sender, EventArgs e)
		{
			if ((result.Text == "0") || (isoperationperformed))
				result.Clear();
		isoperationperformed = false;
		Button button = (Button)sender;
			if (button.Text == ".")
			{if(!result.Text.Contains("."))
				result.Text = result.Text + button.Text;
			}
			else
				result.Text = result.Text + button.Text;
	}

	private void button_Click(object sender, EventArgs e)
	{

	}

		private void operator_click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (resultvalue != 0)
			{
				button16.PerformClick();
				operation = button.Text;
				label1.Text = resultvalue + " " + operation;
				isoperationperformed = true;
			}
			else
			{
				operation = button.Text;
				resultvalue = Double.Parse(result.Text);
				label1.Text = resultvalue + " " + operation;
				isoperationperformed = true;
			}

	
		}

		private void button5_Click(object sender, EventArgs e)
		{
			result.Text = "0";

	
		}

		private void button11_Click(object sender, EventArgs e)
		{
			result.Text = "0";
			resultvalue = 0;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			switch (operation)
			{
				case "+":
					result.Text = (resultvalue + Double.Parse(result.Text)).ToString();
					break;
				case "-":
					result.Text = (resultvalue - Double.Parse(result.Text)).ToString();
					break;
				case "*":
					result.Text = (resultvalue * Double.Parse(result.Text)).ToString();
					break;
				case "/":
					result.Text = (resultvalue / Double.Parse(result.Text)).ToString();
					break;
				default:
					break;
			}
			resultvalue = Double.Parse(result.Text);

			label1.Text = "";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

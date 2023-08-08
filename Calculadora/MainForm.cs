/*
 * Created by SharpDevelop.
 * User: Alunos
 * Date: 01/03/2023
 * Time: 19:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int x;
			x = int.Parse(textBox1.Text);
			int y;
			y = int.Parse(textBox2.Text);
			int s;
			s = x + y;
			textBox3.Text = s.ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int x;
			x = int.Parse(textBox1.Text);
			int y;
			y = int.Parse(textBox2.Text);
			int s;
			s = x - y;
			textBox3.Text = s.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			float x;
			x = float.Parse(textBox1.Text);
			float y;
			y = float.Parse(textBox2.Text);
			float s;
			s = x * y;
			textBox3.Text = s.ToString();
		}
		void Button4Click(object sender, EventArgs e)
		{
			float x;
			x = float.Parse(textBox1.Text);
			float y;
			y = float.Parse(textBox2.Text);
			float s;
			s = x / y;
			textBox3.Text = s.ToString();
		}
		void Button5Click(object sender, EventArgs e)
		{		
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
	}
}
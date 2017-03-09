using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReachTextBox
	{
	public partial class Form1: Form
		{
		public Form1()
			{
			InitializeComponent();
			}

		private void button1_Click(object sender, EventArgs e)
			{
			// не забути оаторизацію

			Form2 f2 = new Form2(this);
			f2.Show();
			
			}

		private void textBox1_TextChanged(object sender, EventArgs e)
			{
			MessageBox.Show("Test");
			}
		}
	}

git push origin master  //запушити
	git clone https://github.com/PavloMarchuk/NoteManager //клонувати з сервера на інший комп
	git pull // зкачати нові чужі коміти з сервера

 

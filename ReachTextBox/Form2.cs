﻿using System;
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
	public partial class Form2: Form
		{
		Form1 f1;

		public Form2(Form1 x)
			{			
			InitializeComponent();
			this.f1 = x;
			}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
			{
			f1.Close();
			}
		}
	}

﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 24/10/2024
 * Time: 07:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace suma
{
	/// <summary>
	/// Description of Formdivicion.
	/// </summary>
	public partial class divi : Form
	{
		public divi()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncalClick(object sender, EventArgs e)
		{
			string num1 = txtnum1.Text;
			string num2 = txtnum2.Text;
			int n1 = Int32.Parse(num1);
			int n2 = Int32.Parse(num2);
			int resul = n1 / n2;
			string r = resul.ToString();
			lbresultado.Text = r;
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 24/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace suma
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnsumaClick(object sender, EventArgs e)
		{
			
			suma formsuma = new suma();
			formsuma.Show();
		}
		
		void BtndivicionClick(object sender, EventArgs e)
		{
			 divi formdivicion = new divi();
			formdivicion.Show();
		}
		
		void BtnrestaClick(object sender, EventArgs e)
		{
			 res formresta = new res();
			formresta.Show();
		}
		
		void BtnmultiClick(object sender, EventArgs e)
		{
			 mul formmulti = new mul();
			formmulti.Show();			
		}
		
		void BtnraizClick(object sender, EventArgs e)
		{
			
			 ra formraiz = new ra();
			formraiz.Show();			
		}
	}
}

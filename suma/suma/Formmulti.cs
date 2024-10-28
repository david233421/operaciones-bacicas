/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 24/10/2024
 * Time: 08:00 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace suma
{
	/// <summary>
	/// Description of Formmulti.
	/// </summary>
	public partial class mul : Form
	{
		public mul()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		double num1,num2;
		void BtnmultiClick(object sender, EventArgs e)
		{
			double multi;
			num1 = Convert.ToDouble(txtnum1.Text);
			num2 = Convert.ToDouble(txtnum2.Text);
			multi = num1*num2;
			MessageBox.Show("la respuesta es "+multi);
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 24/10/2024
 * Time: 08:00 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace suma
{
	partial class mul
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtnum1 = new System.Windows.Forms.TextBox();
			this.txtnum2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnmulti = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtnum1
			// 
			this.txtnum1.Location = new System.Drawing.Point(13, 44);
			this.txtnum1.Name = "txtnum1";
			this.txtnum1.Size = new System.Drawing.Size(100, 20);
			this.txtnum1.TabIndex = 0;
			// 
			// txtnum2
			// 
			this.txtnum2.Location = new System.Drawing.Point(192, 43);
			this.txtnum2.Name = "txtnum2";
			this.txtnum2.Size = new System.Drawing.Size(100, 20);
			this.txtnum2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "numero1 ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(192, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "numero2";
			// 
			// btnmulti
			// 
			this.btnmulti.Location = new System.Drawing.Point(134, 173);
			this.btnmulti.Name = "btnmulti";
			this.btnmulti.Size = new System.Drawing.Size(75, 23);
			this.btnmulti.TabIndex = 4;
			this.btnmulti.Text = "numtipica";
			this.btnmulti.UseVisualStyleBackColor = true;
			this.btnmulti.Click += new System.EventHandler(this.BtnmultiClick);
			// 
			// mul
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 261);
			this.Controls.Add(this.btnmulti);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnum2);
			this.Controls.Add(this.txtnum1);
			this.Name = "mul";
			this.Text = "Formmulti";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnmulti;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnum2;
		private System.Windows.Forms.TextBox txtnum1;
	}
}

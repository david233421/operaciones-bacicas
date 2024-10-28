/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 24/10/2024
 * Time: 07:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace suma
{
	partial class divi
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
			this.lbresultado = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btncal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtnum1
			// 
			this.txtnum1.Location = new System.Drawing.Point(13, 81);
			this.txtnum1.Name = "txtnum1";
			this.txtnum1.Size = new System.Drawing.Size(90, 20);
			this.txtnum1.TabIndex = 0;
			// 
			// txtnum2
			// 
			this.txtnum2.Location = new System.Drawing.Point(182, 81);
			this.txtnum2.Name = "txtnum2";
			this.txtnum2.Size = new System.Drawing.Size(90, 20);
			this.txtnum2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(109, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "/";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(278, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "=";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbresultado
			// 
			this.lbresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbresultado.Location = new System.Drawing.Point(351, 72);
			this.lbresultado.Name = "lbresultado";
			this.lbresultado.Size = new System.Drawing.Size(67, 30);
			this.lbresultado.TabIndex = 4;
			this.lbresultado.Text = "......";
			this.lbresultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(79, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(306, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Inserte los numeros que desea dividir";
			// 
			// btncal
			// 
			this.btncal.Location = new System.Drawing.Point(342, 129);
			this.btncal.Name = "btncal";
			this.btncal.Size = new System.Drawing.Size(75, 23);
			this.btncal.TabIndex = 6;
			this.btncal.Text = "Calcular";
			this.btncal.UseVisualStyleBackColor = true;
			this.btncal.Click += new System.EventHandler(this.BtncalClick);
			// 
			// divi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 164);
			this.Controls.Add(this.btncal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbresultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnum2);
			this.Controls.Add(this.txtnum1);
			this.Name = "divi";
			this.Text = "Formdivicion";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btncal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbresultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnum2;
		private System.Windows.Forms.TextBox txtnum1;
	}
}

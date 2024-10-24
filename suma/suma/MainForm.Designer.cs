/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 24/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace suma
{
	partial class MainForm
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
			this.btnsuma = new System.Windows.Forms.Button();
			this.btnresta = new System.Windows.Forms.Button();
			this.btndivicion = new System.Windows.Forms.Button();
			this.btnmulti = new System.Windows.Forms.Button();
			this.btnraiz = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnsuma
			// 
			this.btnsuma.Location = new System.Drawing.Point(60, 12);
			this.btnsuma.Name = "btnsuma";
			this.btnsuma.Size = new System.Drawing.Size(75, 23);
			this.btnsuma.TabIndex = 2;
			this.btnsuma.Text = "suma";
			this.btnsuma.UseVisualStyleBackColor = true;
			this.btnsuma.Click += new System.EventHandler(this.BtnsumaClick);
			// 
			// btnresta
			// 
			this.btnresta.Location = new System.Drawing.Point(298, 12);
			this.btnresta.Name = "btnresta";
			this.btnresta.Size = new System.Drawing.Size(75, 23);
			this.btnresta.TabIndex = 3;
			this.btnresta.Text = "resta";
			this.btnresta.UseVisualStyleBackColor = true;
			this.btnresta.Click += new System.EventHandler(this.BtnrestaClick);
			// 
			// btndivicion
			// 
			this.btndivicion.Location = new System.Drawing.Point(60, 53);
			this.btndivicion.Name = "btndivicion";
			this.btndivicion.Size = new System.Drawing.Size(75, 25);
			this.btndivicion.TabIndex = 4;
			this.btndivicion.Text = "divicion";
			this.btndivicion.UseVisualStyleBackColor = true;
			this.btndivicion.Click += new System.EventHandler(this.BtndivicionClick);
			// 
			// btnmulti
			// 
			this.btnmulti.Location = new System.Drawing.Point(298, 53);
			this.btnmulti.Name = "btnmulti";
			this.btnmulti.Size = new System.Drawing.Size(75, 23);
			this.btnmulti.TabIndex = 5;
			this.btnmulti.Text = "multiplicacion";
			this.btnmulti.UseVisualStyleBackColor = true;
			this.btnmulti.Click += new System.EventHandler(this.BtnmultiClick);
			// 
			// btnraiz
			// 
			this.btnraiz.Location = new System.Drawing.Point(178, 117);
			this.btnraiz.Name = "btnraiz";
			this.btnraiz.Size = new System.Drawing.Size(75, 23);
			this.btnraiz.TabIndex = 10;
			this.btnraiz.Text = "raiz cuadrada";
			this.btnraiz.UseVisualStyleBackColor = true;
			this.btnraiz.Click += new System.EventHandler(this.BtnraizClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 261);
			this.Controls.Add(this.btnraiz);
			this.Controls.Add(this.btnmulti);
			this.Controls.Add(this.btndivicion);
			this.Controls.Add(this.btnresta);
			this.Controls.Add(this.btnsuma);
			this.Name = "MainForm";
			this.Text = "suma";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnraiz;
		private System.Windows.Forms.Button btnmulti;
		private System.Windows.Forms.Button btndivicion;
		private System.Windows.Forms.Button btnresta;
		private System.Windows.Forms.Button btnsuma;
		
	}
}

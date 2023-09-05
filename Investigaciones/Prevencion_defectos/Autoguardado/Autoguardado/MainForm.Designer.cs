/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 04/09/2023
 * Time: 01:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Autoguardado
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
			this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.buttonColor = new System.Windows.Forms.Button();
			this.buttonCargar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxGraph
			// 
			this.pictureBoxGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxGraph.Location = new System.Drawing.Point(12, 14);
			this.pictureBoxGraph.Name = "pictureBoxGraph";
			this.pictureBoxGraph.Size = new System.Drawing.Size(794, 553);
			this.pictureBoxGraph.TabIndex = 5;
			this.pictureBoxGraph.TabStop = false;
			this.pictureBoxGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxGraphMouseClick);
			// 
			// buttonColor
			// 
			this.buttonColor.Location = new System.Drawing.Point(841, 72);
			this.buttonColor.Name = "buttonColor";
			this.buttonColor.Size = new System.Drawing.Size(90, 47);
			this.buttonColor.TabIndex = 6;
			this.buttonColor.Text = "Cambiar color";
			this.buttonColor.UseVisualStyleBackColor = true;
			this.buttonColor.Click += new System.EventHandler(this.ButtonColorClick);
			// 
			// buttonCargar
			// 
			this.buttonCargar.Location = new System.Drawing.Point(841, 145);
			this.buttonCargar.Name = "buttonCargar";
			this.buttonCargar.Size = new System.Drawing.Size(90, 47);
			this.buttonCargar.TabIndex = 7;
			this.buttonCargar.Text = "Cargar";
			this.buttonCargar.UseVisualStyleBackColor = true;
			this.buttonCargar.Click += new System.EventHandler(this.ButtonCargarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 579);
			this.Controls.Add(this.buttonCargar);
			this.Controls.Add(this.buttonColor);
			this.Controls.Add(this.pictureBoxGraph);
			this.Name = "MainForm";
			this.Text = "Autoguardado";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonCargar;
		private System.Windows.Forms.Button buttonColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.PictureBox pictureBoxGraph;
	}
}

/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 29/08/2023
 * Time: 10:00 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Actividad_a3
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
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.comboBoxOperator = new System.Windows.Forms.ComboBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.progressBar6 = new System.Windows.Forms.ProgressBar();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.lbl6 = new System.Windows.Forms.Label();
			this.lbl5 = new System.Windows.Forms.Label();
			this.lbl4 = new System.Windows.Forms.Label();
			this.progressBar5 = new System.Windows.Forms.ProgressBar();
			this.lblResultado1 = new System.Windows.Forms.Label();
			this.lblResultado2 = new System.Windows.Forms.Label();
			this.lblResultado3 = new System.Windows.Forms.Label();
			this.lblResultado4 = new System.Windows.Forms.Label();
			this.lblResultado5 = new System.Windows.Forms.Label();
			this.lblResultado6 = new System.Windows.Forms.Label();
			this.buttonMulti = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Location = new System.Drawing.Point(57, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(249, 23);
			this.label5.TabIndex = 24;
			this.label5.Text = "Tiempo estimado (segundos)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownTime
			// 
			this.numericUpDownTime.Location = new System.Drawing.Point(319, 193);
			this.numericUpDownTime.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownTime.Name = "numericUpDownTime";
			this.numericUpDownTime.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownTime.TabIndex = 23;
			this.numericUpDownTime.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new System.Drawing.Point(57, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(645, 32);
			this.label4.TabIndex = 22;
			this.label4.Text = "Simulacion de procesamiento por multiprogramacion";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(57, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "Operador  ------------>";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(57, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(249, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Segundo valor  ------------>";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(319, 147);
			this.numericUpDown2.Maximum = new decimal(new int[] {
									500,
									0,
									0,
									0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 19;
			this.numericUpDown2.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// comboBoxOperator
			// 
			this.comboBoxOperator.FormattingEnabled = true;
			this.comboBoxOperator.Items.AddRange(new object[] {
									"+",
									"-",
									"*",
									"/"});
			this.comboBoxOperator.Location = new System.Drawing.Point(318, 100);
			this.comboBoxOperator.Name = "comboBoxOperator";
			this.comboBoxOperator.Size = new System.Drawing.Size(121, 21);
			this.comboBoxOperator.TabIndex = 18;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(319, 59);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									500,
									0,
									0,
									0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 17;
			this.numericUpDown1.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(57, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Primer valor  ------------>";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(545, 80);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(124, 41);
			this.buttonAdd.TabIndex = 15;
			this.buttonAdd.Text = "Agregar proceso";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// progressBar6
			// 
			this.progressBar6.Location = new System.Drawing.Point(213, 470);
			this.progressBar6.Name = "progressBar6";
			this.progressBar6.Size = new System.Drawing.Size(312, 23);
			this.progressBar6.TabIndex = 25;
			// 
			// lbl1
			// 
			this.lbl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl1.Location = new System.Drawing.Point(28, 252);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(159, 23);
			this.lbl1.TabIndex = 26;
			this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl2
			// 
			this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl2.Location = new System.Drawing.Point(28, 297);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(159, 23);
			this.lbl2.TabIndex = 27;
			this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl3
			// 
			this.lbl3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl3.Location = new System.Drawing.Point(28, 339);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(159, 23);
			this.lbl3.TabIndex = 28;
			this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(213, 252);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(312, 23);
			this.progressBar1.TabIndex = 29;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(213, 297);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(312, 23);
			this.progressBar2.TabIndex = 30;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(213, 339);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(312, 23);
			this.progressBar3.TabIndex = 36;
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(213, 383);
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(312, 23);
			this.progressBar4.TabIndex = 35;
			// 
			// lbl6
			// 
			this.lbl6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl6.Location = new System.Drawing.Point(28, 470);
			this.lbl6.Name = "lbl6";
			this.lbl6.Size = new System.Drawing.Size(159, 23);
			this.lbl6.TabIndex = 34;
			this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl5
			// 
			this.lbl5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl5.Location = new System.Drawing.Point(28, 428);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(159, 23);
			this.lbl5.TabIndex = 33;
			this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl4
			// 
			this.lbl4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl4.Location = new System.Drawing.Point(28, 383);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(159, 23);
			this.lbl4.TabIndex = 32;
			this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// progressBar5
			// 
			this.progressBar5.Location = new System.Drawing.Point(213, 428);
			this.progressBar5.Name = "progressBar5";
			this.progressBar5.Size = new System.Drawing.Size(312, 23);
			this.progressBar5.TabIndex = 31;
			// 
			// lblResultado1
			// 
			this.lblResultado1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblResultado1.Location = new System.Drawing.Point(555, 252);
			this.lblResultado1.Name = "lblResultado1";
			this.lblResultado1.Size = new System.Drawing.Size(159, 23);
			this.lblResultado1.TabIndex = 37;
			this.lblResultado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResultado2
			// 
			this.lblResultado2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblResultado2.Location = new System.Drawing.Point(555, 297);
			this.lblResultado2.Name = "lblResultado2";
			this.lblResultado2.Size = new System.Drawing.Size(159, 23);
			this.lblResultado2.TabIndex = 38;
			this.lblResultado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResultado3
			// 
			this.lblResultado3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblResultado3.Location = new System.Drawing.Point(555, 339);
			this.lblResultado3.Name = "lblResultado3";
			this.lblResultado3.Size = new System.Drawing.Size(159, 23);
			this.lblResultado3.TabIndex = 39;
			this.lblResultado3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResultado4
			// 
			this.lblResultado4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblResultado4.Location = new System.Drawing.Point(555, 383);
			this.lblResultado4.Name = "lblResultado4";
			this.lblResultado4.Size = new System.Drawing.Size(159, 23);
			this.lblResultado4.TabIndex = 40;
			this.lblResultado4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResultado5
			// 
			this.lblResultado5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblResultado5.Location = new System.Drawing.Point(555, 428);
			this.lblResultado5.Name = "lblResultado5";
			this.lblResultado5.Size = new System.Drawing.Size(159, 23);
			this.lblResultado5.TabIndex = 41;
			this.lblResultado5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResultado6
			// 
			this.lblResultado6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblResultado6.Location = new System.Drawing.Point(555, 470);
			this.lblResultado6.Name = "lblResultado6";
			this.lblResultado6.Size = new System.Drawing.Size(159, 23);
			this.lblResultado6.TabIndex = 42;
			this.lblResultado6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonMulti
			// 
			this.buttonMulti.Location = new System.Drawing.Point(545, 147);
			this.buttonMulti.Name = "buttonMulti";
			this.buttonMulti.Size = new System.Drawing.Size(124, 41);
			this.buttonMulti.TabIndex = 43;
			this.buttonMulti.Text = "Ejecutar procesos";
			this.buttonMulti.UseVisualStyleBackColor = true;
			this.buttonMulti.Click += new System.EventHandler(this.ButtonMultiClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 545);
			this.Controls.Add(this.buttonMulti);
			this.Controls.Add(this.lblResultado6);
			this.Controls.Add(this.lblResultado5);
			this.Controls.Add(this.lblResultado4);
			this.Controls.Add(this.lblResultado3);
			this.Controls.Add(this.lblResultado2);
			this.Controls.Add(this.lblResultado1);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.progressBar4);
			this.Controls.Add(this.lbl6);
			this.Controls.Add(this.lbl5);
			this.Controls.Add(this.lbl4);
			this.Controls.Add(this.progressBar5);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.progressBar6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numericUpDownTime);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.comboBoxOperator);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAdd);
			this.Name = "MainForm";
			this.Text = "Actividad_a3";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonMulti;
		private System.Windows.Forms.Label lblResultado6;
		private System.Windows.Forms.Label lblResultado5;
		private System.Windows.Forms.Label lblResultado4;
		private System.Windows.Forms.Label lblResultado3;
		private System.Windows.Forms.Label lblResultado2;
		private System.Windows.Forms.Label lblResultado1;
		private System.Windows.Forms.ProgressBar progressBar5;
		private System.Windows.Forms.Label lbl4;
		private System.Windows.Forms.Label lbl5;
		private System.Windows.Forms.Label lbl6;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.ProgressBar progressBar6;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.ComboBox comboBoxOperator;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownTime;
		private System.Windows.Forms.Label label5;
	}
}

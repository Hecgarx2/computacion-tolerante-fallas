/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 04/09/2023
 * Time: 01:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Autoguardado
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Bitmap bmpGraph;
		Bitmap bmpLine;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bmpGraph = new Bitmap(pictureBoxGraph.Width, pictureBoxGraph.Height);
			bmpLine = new Bitmap(pictureBoxGraph.Width, pictureBoxGraph.Height);
			pictureBoxGraph.BackgroundImage = bmpLine;
			pictureBoxGraph.Image = bmpGraph;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void PictureBoxGraphMouseClick(object sender, MouseEventArgs e)
		{
			float w_p, h_p, w_b, h_b, r_x, r_y, r, d_x, d_y, x_b, y_b, x_p, y_p;
			
			w_p = pictureBoxGraph.Width;
			h_p = pictureBoxGraph.Height;
			w_b = bmpGraph.Width;
			h_b = bmpGraph.Height;
			
			x_p = e.X;
			y_p = e.Y;
		
			r_x = w_p/w_b;
			r_y = h_p/h_b;
			
			if(r_x < r_y){
				r = r_x;
			}
			else{
				r = r_y;
			}
			
		
			d_x = (w_p - w_b*r)/2;
			d_y = (h_p - h_b*r)/2;
		
			x_b = (x_p - d_x)/r;
			y_b = (y_p - d_y)/r;
			
			Point center = new Point((int)x_b, (int)y_b);
			Color color = colorDialog1.Color;
			Circle newCircle = new Circle(30, center, color);
			escribir(newCircle);
			
			Graphics circle = Graphics.FromImage(bmpGraph);
			Brush brush = new SolidBrush(colorDialog1.Color);
			circle.FillEllipse(brush, newCircle.Center.X-30, newCircle.Center.Y-30, 60, 60);
			pictureBoxGraph.Refresh();
			
		}
		
		void ButtonColorClick(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
		}
		
		void escribir(Circle newCircle){
			StreamWriter archivo = new StreamWriter("circulos.txt", true);
			string linea = newCircle.Center.X.ToString() +'\n'+ newCircle.Center.Y.ToString() +'\n'+ newCircle.Radio.ToString() +'\n'+ newCircle.Color.Name;
			
			archivo.WriteLine(linea);
			archivo.Close();
		}
		
		void ButtonCargarClick(object sender, EventArgs e)
		{
			StreamReader archivo = new StreamReader("circulos.txt");
			Color color;
			string linea;
			int x = 0, y = 0, radio = 0, caso = 1;
			while ( (linea = archivo.ReadLine()) != null) {
				switch (caso) {
					case 1:
						x = int.Parse(linea);
						caso++;
						break;
					case 2:
						y = int.Parse(linea);
						caso++;
						break;
					case 3:
						radio = int.Parse(linea);
						caso++;
						break;
					case 4:
						color = Color.FromName(linea);
						caso = 1;
						Graphics circle = Graphics.FromImage(bmpGraph);
						Brush brush = new SolidBrush(color);
						circle.FillEllipse(brush, x - 30, y - 30, 60, 60);
						pictureBoxGraph.Refresh();
						break;
				}
			}
			
			archivo.Close();
		}
	}
}

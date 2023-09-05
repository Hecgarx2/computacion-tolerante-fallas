/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 04/09/2023
 * Time: 01:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Autoguardado
{
	/// <summary>
	/// Description of Circle.
	/// </summary>
	public class Circle
	{
		int radio;
		Point center;
		Color color;
		
		public Color Color {
			get { return color; }
		}
		
		public Point Center {
			get { return center; }
		}
		
		public int Radio {
			get { return radio; }
		}
		
		public Circle()
		{
		}
		public Circle(int radio, Point center, Color color)
		{
			this.radio = radio;
			this.center = center;
			this.color = color;
		}
		
	}
}

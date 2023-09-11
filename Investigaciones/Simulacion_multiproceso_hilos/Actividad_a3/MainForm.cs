/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 29/08/2023
 * Time: 10:00 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;			//Libreria de los hilos
using System.Windows.Forms;

namespace Actividad_a3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int count = 0;		//Contador de procesos
		int[] resultados;				//Arrelgo de resultados
		int[] tiempos;					//Arrelgo de tiempos
		ProgressBar[] progressBars;     //Arreglo de barras de progreso para los procesos
		Label[] labelsList;				//Arreglo de textos para los procesos
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//Inicializo arreglo con todas las barras de progreso
            progressBars = new ProgressBar[] { progressBar1, progressBar2, progressBar3, 
                progressBar4, progressBar5,progressBar6};
			//Inicializo arreglo con todas las barras de progreso
			labelsList = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5,lbl6};
			resultados = new int[6];
			tiempos = new int[6];
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			//Este if valida que se haya elegido un operador
			if (comboBoxOperator.SelectedItem != null) {
				if (count != 6) {
					//Aqui se agrega cada valor elegido a al label
					labelsList[count].Text = numericUpDown1.Value.ToString() + ' ' + comboBoxOperator.SelectedItem + ' ' + numericUpDown2.Value.ToString();
					resultados[count] = result((int)numericUpDown1.Value, (int)numericUpDown2.Value, comboBoxOperator.SelectedItem.ToString());
					tiempos[count] = (int)numericUpDownTime.Value;
					count++;
				}
				else{
					MessageBox.Show("Has alcanzado el limite de procesos");
				}
			}
		}
		//Boton para empezar los procesos
		void ButtonMultiClick(object sender, EventArgs e)
		{
			//Creo un hilo para cada barra de tareas que carga la barra a la velocida elegida por el usuario
			Thread proceso1 = new Thread(new ThreadStart(cargarProceso1));
			Thread proceso2 = new Thread(new ThreadStart(cargarProceso2));
			Thread proceso3 = new Thread(new ThreadStart(cargarProceso3));
			Thread proceso4 = new Thread(new ThreadStart(cargarProceso4));
			Thread proceso5 = new Thread(new ThreadStart(cargarProceso5));
			Thread proceso6 = new Thread(new ThreadStart(cargarProceso6));
			//Este switch es el encargado de disparar los hilos en base a los procesos que tenga el contador
			switch (count) {	
				case 1:
					proceso1.Start();
					break;
				case 2:
					proceso1.Start();
					proceso2.Start();	
					break;
				case 3:
					proceso1.Start();
					proceso2.Start();
					proceso3.Start();
					break;
				case 4:
					proceso1.Start();
					proceso2.Start();
					proceso3.Start();
					proceso4.Start();
					break;
				case 5:
					proceso1.Start();
					proceso2.Start();
					proceso3.Start();
					proceso4.Start();
					proceso5.Start();
					break;
				case 6:
					proceso1.Start();
					proceso2.Start();
					proceso3.Start();
					proceso4.Start();
					proceso5.Start();
					proceso6.Start();
					break;
			}
			
		}
		
		//Clase que calcula el resultado de la operacion elegida
		int result(int num1, int num2, string id){
			int total = 0;
			switch (id) {
				case "+": 
					return total = num1 + num2;
					
				case "-":
					return total = num1 - num2;
					
				case "*":
					return total = num1 * num2;
					
				case "/":
					return total = num1 / num2;
			}
			return total;
		}
		
		//Metodo invocado por el primer hilo encargado del primer proceso
		void cargarProceso1(){
			int time = tiempos[0];
			
			time = (time*1000)/100;					//Calculo el timepo en segundos y lo divido entre 100 que es el valor de la barra de progreso
				
			while (progressBar1.Value != 100) {		//Ciclo while que controla el tiempo de la barra de progreso
				progressBar1.Invoke((MethodInvoker)delegate{
					progressBar1.Value++;
				});
                Thread.Sleep(time);					
            }
			
			lblResultado1.Invoke((MethodInvoker)delegate{
				lblResultado1.Text = '=' + resultados[0].ToString();			                     	
         	});
		}
		//Metodo invocado por el segundo hilo encargado del segundo proceso
		void cargarProceso2(){
			int time = tiempos[1];
			
			time = (time*1000)/100;					//Calculo el timepo en segundos y lo divido entre 100 que es el valor de la barra de progreso
				
			while (progressBar2.Value != 100) {		//Ciclo while que controla el tiempo de la barra de progreso
                progressBar2.Invoke((MethodInvoker)delegate{
					progressBar2.Value++;
				});
                Thread.Sleep(time);					
			}
			
			lblResultado2.Invoke((MethodInvoker)delegate{
				lblResultado2.Text = '=' + resultados[1].ToString();			                     	
         	});
		}
		//Metodo invocado por el tercer hilo encargado del tercer proceso
		void cargarProceso3(){
			int time = tiempos[2];
			
			time = (time*1000)/100;					//Calculo el timepo en segundos y lo divido entre 100 que es el valor de la barra de progreso
				
			while (progressBar3.Value != 100) {		//Ciclo while que controla el tiempo de la barra de progreso
                progressBar3.Invoke((MethodInvoker)delegate{
					progressBar3.Value++;
				});
                Thread.Sleep(time);					
			}
			
			lblResultado3.Invoke((MethodInvoker)delegate{
				lblResultado3.Text = '=' + resultados[2].ToString();			                     	
         	});
		}
		//Metodo invocado por el cuarto hilo encargado del cuarto proceso
		void cargarProceso4(){
			int time = tiempos[3];
			
			time = (time*1000)/100;					//Calculo el timepo en segundos y lo divido entre 100 que es el valor de la barra de progreso
				
			while (progressBar4.Value != 100) {		//Ciclo while que controla el tiempo de la barra de progreso
                progressBar4.Invoke((MethodInvoker)delegate{
					progressBar4.Value++;
				});
                Thread.Sleep(time);					
			}
			
			lblResultado4.Invoke((MethodInvoker)delegate{
				lblResultado4.Text = '=' + resultados[3].ToString();			                     	
         	});
		}
		//Metodo invocado por el quinto hilo encargado del quinto proceso
		void cargarProceso5(){
			int time = tiempos[4];
			
			time = (time*1000)/100;					//Calculo el timepo en segundos y lo divido entre 100 que es el valor de la barra de progreso
				
			while (progressBar5.Value != 100) {		//Ciclo while que controla el tiempo de la barra de progreso
                progressBar5.Invoke((MethodInvoker)delegate{
					progressBar5.Value++;
				});
                Thread.Sleep(time);					
			}
			
			lblResultado5.Invoke((MethodInvoker)delegate{
				lblResultado5.Text = '=' + resultados[4].ToString();			                     	
         	});
		}
		//Metodo invocado por el sexto hilo encargado del sexto proceso
		void cargarProceso6(){
			int time = tiempos[5];
			
			time = (time*1000)/100;					//Calculo el timepo en segundos y lo divido entre 100 que es el valor de la barra de progreso
				
			while (progressBar6.Value != 100) {		//Ciclo while que controla el tiempo de la barra de progreso
                progressBar6.Invoke((MethodInvoker)delegate{
					progressBar6.Value++;
				});
                Thread.Sleep(time);					
			}
			
			lblResultado6.Invoke((MethodInvoker)delegate{
				lblResultado6.Text = '=' + resultados[5].ToString();			                     	
         	});
		}
	}
}

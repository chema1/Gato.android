using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace pruebas
{
	[Activity (Label = "pruebas", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		#region Declarar Botones
		Button btn1;
		Button btn2;
		Button btn3;
		Button btn4;
		Button btn5;
		Button btn6;
		Button btn7;
		Button btn8;
		Button btn9;
		#endregion

		protected byte[,] Matriz =new byte[,]{{3,4,5},{6,7,8},{9,10,11}};
		int contador = 1;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			#region inicializar botones
			btn1 = FindViewById <Button> (Resource.Id.button1);
			btn2 = FindViewById <Button> (Resource.Id.button2);
			btn3 = FindViewById <Button> (Resource.Id.button3);
			btn4 = FindViewById <Button> (Resource.Id.button4);
			btn5 = FindViewById <Button> (Resource.Id.button5);
			btn6 = FindViewById <Button> (Resource.Id.button6);
			btn7 = FindViewById <Button> (Resource.Id.button7);
			btn8 = FindViewById <Button> (Resource.Id.button8);
			btn9 = FindViewById <Button> (Resource.Id.button9);
			#endregion

			btn1.Click += btn1_Click;
			btn2.Click += btn2_Click;
			btn3.Click += btn3_Click;
			btn4.Click += btn4_Click;
			btn5.Click += btn5_Click;
			btn6.Click += btn6_Click;
			btn7.Click += btn7_Click;
			btn8.Click += btn8_Click;
			btn9.Click += btn9_Click;


		} 
		//*********************************************************************
		void btn1_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn1.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [0, 0] = 1;
			} 
			else {
				this.btn1.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [0, 0] = 2;
			}
			this.contador++;
			this.btn1.Enabled = false;

			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}

		void btn2_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn2.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [0, 1] = 1;
			} 
			else {
				this.btn2.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [0, 1] = 2;
			}
			this.contador++;
			this.btn2.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}

		void btn3_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn3.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [0, 2] = 1;
			} 
			else {
				this.btn3.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [0, 2] = 2;
			}
			this.contador++;
			this.btn3.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}
		//*********************************************************************

		void btn4_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn4.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [1, 0] = 1;
			} 
			else {
				this.btn4.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [1, 0] = 2;
			}
			this.contador++;
			this.btn4.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}

		void btn5_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn5.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [1, 1] = 1;
			} 
			else {
				this.btn5.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [1, 1] = 2;
			}
			this.contador++;
			this.btn5.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}

		void btn6_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn6.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [1, 2] = 1;
			} 
			else {
				this.btn6.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [1, 2] = 2;
			}
			this.contador++;
			this.btn6.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}

		}
		//*********************************************************************
		void btn7_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn7.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [2, 0] = 1;
			} 
			else {
				this.btn7.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [2, 0] = 2;
			}
			this.contador++;
			this.btn7.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}

		void btn8_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn8.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [2, 1] = 1;
			} 
			else {
				this.btn8.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [2, 1] = 2;
			}
			this.contador++;
			this.btn8.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}

		void btn9_Click(object sender, EventArgs e){
			if (contador % 2 == 0) {
				this.btn9.SetBackgroundResource (Resource.Drawable.circle);
				Matriz [2, 2] = 1;
			} 
			else {
				this.btn9.SetBackgroundResource (Resource.Drawable.ex);
				Matriz [2, 2] = 2;
			}
			this.contador++;
			this.btn9.Enabled = false;
			if (comprobar () != 0) {
				//this.ShowDialog ("gana "+comprobar());
				Console.WriteLine ("gano " + comprobar());
			}
		}

		protected byte comprobar(){
			for (int i = 0; i < this.Matriz.GetLength (0); i++) {
				if (this.Matriz [i, 0] == this.Matriz [i, 1] && this.Matriz [i, 1] == this.Matriz [i, 2]) {
					return this.Matriz [i, 0];
				}
				if (this.Matriz [0, i] == this.Matriz [1, i] && this.Matriz [1, i] == this.Matriz [2, i]) {
					return this.Matriz [0, i];
				}
			}
				if (this.Matriz [0, 0] == this.Matriz [1, 1] && this.Matriz [1, 1] == this.Matriz [2, 2]) {
					return this.Matriz[0,0];
				}
				else if (this.Matriz [2, 0] == this.Matriz [1, 1] && this.Matriz [1, 1] == this.Matriz [0, 2]) {
					return this.Matriz[2,0];
				}
			return 0;	
		}

	}
}



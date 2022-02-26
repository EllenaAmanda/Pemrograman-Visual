/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 26/02/2022
 * Time: 17.46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			string nama = textBox1.Text;
			string jk = textBox2.Text;
			string nim = textBox3.Text;
			string fakultas = textBox4.Text;
			string jurusan = textBox5.Text;
			string stambuk = textBox6.Text;
			
			string batas = "  ||  ";
			
			listbox1.Items.Add(nama+batas+jk+batas+nim+batas+fakultas+batas+jurusan+batas+stambuk);
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			listbox1.Items.RemoveAt(listbox1.SelectedIndex);
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZentryLauncherFree
{
	public partial class Form1 : Form
	{
		public string Ip { get; set; }
		public int Port { get; set; }
		public Form1()
		{
			InitializeComponent();
			Ip = "127.0.0.1";
			Port = 30120;

		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start($"fivem://connect/{Ip}:{Port}");

		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opa
{
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None; // убираем рамку и кнопки
			Timer timer = new Timer();
			timer.Interval = 3000;
			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();


		}

		


		private void StartForm_Load(object sender, EventArgs e)
		{

		}
	}
}

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

		private Timer timer;

		public StartForm()
		{
			InitializeComponent();
			// Настройка таймера
			timer = new Timer();
			timer.Interval = 30000; // Задержка в миллисекундах (3 секунды)
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			timer.Stop(); // Останавливаем таймер

			// Создаем и отображаем MainForm
			MainForm mainForm = new MainForm();
			mainForm.Show();

			// Закрываем StartForm
			this.Close();
		}

		private void StartForm_Load(object sender, EventArgs e)
		{
			this.ControlBox = false; // убираем крестик и другие кнопки
			
		}
		
	}

}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 

            string path = Application.ExecutablePath;
            string path2 = "connect.txt"; // наименование текстового файла для подключения

            if (System.IO.File.Exists(path2)) // проверка существования текстового файла
            {
                using (StreamReader sr = File.OpenText(path2))
                {
                    string line = sr.ReadToEnd();                           // чтение содержимого текстового файла
                    if ((System.IO.Directory.Exists(line)) && ((File.Exists(line + "\\AuroraDB.accdb"))))   // проверка существования указанной директории и файла БД в ней
                        AppDomain.CurrentDomain.SetData("DataDirectory", line);   // если файл БД по данной директории существует, путь из файла программно присваивается приложению
                    else
                    {
                        MessageBox.Show("В файле connect отсутствует адрес подключения или неправильно указана директория");
                        MenuItem2.Visible = false;  // устранение возможности перехода на другие формы, связанные с базой данных
                        MenuItem3.Visible = false;
                        MenuItem4.Visible = false;
                    }
                }
                this.TopMost = false;
            }
            else      // если текстовый файл подключения отсутствует
            {
                this.TopMost = true;
                MessageBox.Show("Отсутствует подключение к базе данных. Файл connect с адресом подключения будет создан автоматически.");
                OpenFileDialog ConnectionDBDialog = new OpenFileDialog();             // пользователю предлагается подключиться вручную к базе данных
                ConnectionDBDialog.Filter = String.Empty;
                ConnectionDBDialog.Filter = "Файл базы данных (*.accdb)|*.accdb";
                ConnectionDBDialog.Title = "Выберите файл базы данных";
                string filename = null;
                if (ConnectionDBDialog.ShowDialog() == DialogResult.OK)    // если пользователь выбрал базу данных и нажал на кнопку "ОК"
                {
                    MenuItem2.Visible = true;    // появление скрытых элементов для перехода на связанные с БД формы
                    MenuItem3.Visible = true;
                    MenuItem4.Visible = true;
                    filename = ConnectionDBDialog.InitialDirectory;
                    string dbPath = ConnectionDBDialog.FileName;
                    string dbpath = System.IO.Path.GetDirectoryName(dbPath);
                    AppDomain.CurrentDomain.SetData("DataDirectory", dbpath);
                    StreamWriter file = new StreamWriter(path2, false);    // открытие файла подключения
                    file.Write(dbpath);  // запись пути к базе данных в тектовый файл подключения
                    file.Close();
                    this.TopMost = false;
                }
                else // если пользователь не выбрал базу даннхы и нажал "отмена", для него элементы перехода на связанные с базой данных формы скрываются
                {
                    MessageBox.Show("Требуется адрес подключения к базе данных!");
                    MenuItem2.Visible = false;
                    MenuItem3.Visible = false;
                    MenuItem4.Visible = false;
                    this.TopMost = false;
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void подразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm Department = new DepartmentForm(); // создаем объект типа Form2
            Department.Show();

        }

        private void начальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepBossForm DepBoss = new DepBossForm(); // создаем объект типа Form2
            DepBoss.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm Worker = new WorkerForm(); // создаем объект типа Form2
            Worker.Show();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfrastructureForm Infrastructure = new InfrastructureForm(); // создаем объект типа Form2
            Infrastructure.Show();
        }

        private void статусОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusInfForm StatusInf = new StatusInfForm(); // создаем объект типа Form2
            StatusInf.Show();
        }

        private void связьСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string path2 = "connect.txt";
            OpenFileDialog ConnectionDBDialog = new OpenFileDialog();
            ConnectionDBDialog.Filter = String.Empty;
            ConnectionDBDialog.Filter = "Файл базы данных (*.accdb)|*.accdb";
            ConnectionDBDialog.Title = "Выберите файл базы данных";
            string filename = null;
            if (ConnectionDBDialog.ShowDialog() == DialogResult.OK)
            {
                MenuItem2.Visible = true;
                MenuItem3.Visible = true;
                MenuItem4.Visible = true;

                filename = ConnectionDBDialog.InitialDirectory;
                string dbPath = ConnectionDBDialog.FileName;
                string dbpath = System.IO.Path.GetDirectoryName(dbPath);
                AppDomain.CurrentDomain.SetData("DataDirectory", dbpath);
                StreamWriter file = new StreamWriter(path2, false);
                file.Write(dbpath);
                file.Close();
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

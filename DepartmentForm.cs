using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opa
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
            timer1.Interval = 15 * 1000;                            // Описание таймера на форме
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }

        bool kontrol = false;

        public bool FaktR     // событие при изменении логической переменной kontrol для установки флажка в значение true/false
        {
            get { return kontrol; }
            set
            {
                kontrol = value;
                if (kontrol == true)
                {

                    DataGridViewCell cell1 = null;
                    foreach (DataGridViewCell selectedCell in depTable.SelectedCells)
                    {
                        cell1 = selectedCell;
                        break;
                    }
                    if (cell1 != null)
                    {
                        DataGridViewRow row1 = cell1.OwningRow;
                        row1.Cells[2].Value = true;
                    }
                }
                else
                {
                    DataGridViewCell cell1 = null;
                    foreach (DataGridViewCell selectedCell in depTable.SelectedCells)
                    {
                        cell1 = selectedCell;
                        break;
                    }
                    if (cell1 != null)
                    {
                        DataGridViewRow row1 = cell1.OwningRow;
                        row1.Cells[2].Value = false; // в квадратных скобках указать индекс столбца, где введены флажки
                    }
                }
                departmentBindingSource.EndEdit(); // завершение обработки
                departmentTableAdapter.Update(auroraDBDataSet.Department); // обновление таблицы
                depTable.Refresh();
            }
        }



        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auroraDBDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.auroraDBDataSet.Department);
            depTable.AllowUserToAddRows = false;

            int j=0;
            for (int i = 0; i < depTable.RowCount; i++)
            {
                if (bool.Parse(depTable.Rows[i].Cells[2].Value.ToString()) == true)
                {
                    depTable.Rows[i].DefaultCellStyle.ForeColor = Color.Gray; // закраска занятых строк серым цветом
                    label3.Text = "В данный момент некоторые записи редактируются другими пользователями";
                    j++;
                }
                else
                    depTable.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
            if (j == 0)
                label3.Text = "";

        }

        private void depAdd_Click(object sender, EventArgs e)
        {
            depTable.AllowUserToAddRows = true;
            DataRow nRow = auroraDBDataSet.Department.NewRow();

            //int rc = depTable.RowCount; //это вроде для задания id
            //nRow[0] = rc;

            nRow[0] = title.Text;
            nRow[1] = type.Text;

            auroraDBDataSet.Department.Rows.Add(nRow);
            depTable.AllowUserToAddRows = false;

            kontrol = false;
            FaktR = kontrol;

            this.departmentTableAdapter.Update(this.auroraDBDataSet.Department);

            auroraDBDataSet.Department.AcceptChanges();
            depTable.Refresh();

            int position = departmentBindingSource.Position;

            DepartmentForm_Load(null, null);   // перезагрузка формы при добавлении вызывается для обновления данных в DataGridView из первоисточника, т.е. DB.mdb

            departmentBindingSource.Position = position;

            title.Text = "";

            type.Text = "";
        }

        private void title_MouseClick(object sender, MouseEventArgs e)
        {
            kontrol = true;
            FaktR = kontrol;
        }

        private void type_MouseClick(object sender, MouseEventArgs e)
        {
            kontrol = true;
            FaktR = kontrol;

        }

        private void depTable_SelectionChanged(object sender, EventArgs e)
        {
            kontrol = false;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in depTable.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                depTable.Rows[cell.RowIndex].ReadOnly = false;
                title.Text = row.Cells[0].Value.ToString();
                type.Text = row.Cells[1].Value.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                int position = departmentBindingSource.Position;
                this.departmentTableAdapter.Update(this.auroraDBDataSet.Department);
                DepartmentForm_Load(null, null); // обновляет форму
                departmentBindingSource.Position = position; ; // возвращает выделение на исходную строку
            }

        }

        private void depRefresh_Click(object sender, EventArgs e)
        {
            departmentBindingSource.EndEdit();
            this.departmentTableAdapter.Update(this.auroraDBDataSet.Department);
            auroraDBDataSet.Department.AcceptChanges();
            depTable.Refresh();
            int position = departmentBindingSource.Position;
            DepartmentForm_Load(null, null);   // перезагрузка формы при добавлении вызывается для обновления данных в DataGridView из первоисточника, т.е. DB.mdb
            departmentBindingSource.Position = position;
        }

        private void depEndEdit_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in depTable.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                if (bool.Parse(row.Cells[2].Value.ToString()) == true)
                {
                    row.Cells[2].Value = false;
                }
            }
            departmentBindingSource.EndEdit();
            departmentTableAdapter.Update(auroraDBDataSet.Department);
            auroraDBDataSet.Department.AcceptChanges();
            depTable.Refresh();

        }

        private void depEdit_Click(object sender, EventArgs e)
        {
            string s1 = title.Text;
            string s2 = type.Text;
            
            int position = departmentBindingSource.Position;

            this.departmentTableAdapter.Update(this.auroraDBDataSet.Department);

            DepartmentForm_Load(null, null); // обновляет форму

            departmentBindingSource.Position = position;

            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in depTable.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                if (bool.Parse(row.Cells[2].Value.ToString()) == false)
                {
                    row.Cells[0].Value = s1;
                    row.Cells[1].Value = s2;

                    departmentBindingSource.EndEdit(); // завершение обработки
                    this.departmentTableAdapter.Update(this.auroraDBDataSet.Department);
                    auroraDBDataSet.Department.AcceptChanges();
                    depTable.Refresh();
                    position = departmentBindingSource.Position;
                    DepartmentForm_Load(null, null);
                    departmentBindingSource.Position = position; // возвращает выделение на исходную строку
                }
                else
                    MessageBox.Show("Запись редактируется другим пользователем!");
            }
            kontrol = false;
            FaktR = kontrol;
        }

        private void depDel_Click(object sender, EventArgs e)
        {
            int position = departmentBindingSource.Position;
            this.departmentTableAdapter.Update(this.auroraDBDataSet.Department);
            DepartmentForm_Load(null, null); // обновляет форму
            departmentBindingSource.Position = position;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in depTable.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                if (bool.Parse(row.Cells[2].Value.ToString()) == false)
                {
                    DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Cancel) //Если результат нажатие кнопки отмена, то применить событие отменить удаление.
                    {
                        return;
                    }
                    else
                    {
                        if (dr == DialogResult.OK)
                        {
                            depTable.AllowUserToDeleteRows = true;
                            int a = depTable.CurrentRow.Index;
                            depTable.Rows.Remove(depTable.Rows[a]);
                        }
                    }
                    departmentBindingSource.EndEdit();
                    this.departmentTableAdapter.Update(this.auroraDBDataSet.Department);
                    auroraDBDataSet.Department.AcceptChanges();
                    depTable.Refresh();
                    position = departmentBindingSource.Position;
                    DepartmentForm_Load(null, null);   // перезагрузка формы при добавлении вызывается для обновления данных в DataGridView из первоисточника, т.е. DB.mdb
                    departmentBindingSource.Position = position;
                }
                else
                    MessageBox.Show("Запись редактируется другим пользователем!");
            }
            kontrol = false;
            FaktR = kontrol;

        }
    }
}
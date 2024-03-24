using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opa
{
    public partial class DepBossForm : Form
    {
        public DepBossForm()
        {
            InitializeComponent();

        }



        private void DepBossForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auroraDBDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.auroraDBDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auroraDBDataSet.BossDep". При необходимости она может быть перемещена или удалена.
            this.bossDepTableAdapter.Fill(this.auroraDBDataSet.BossDep);
        }


    }
}

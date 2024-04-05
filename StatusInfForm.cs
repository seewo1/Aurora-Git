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
    public partial class StatusInfForm : Form
    {
        public StatusInfForm()
        {
            InitializeComponent();
        }

        private void StatusInfForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auroraDBDataSet.StatusInf". При необходимости она может быть перемещена или удалена.
            this.statusInfTableAdapter.Fill(this.auroraDBDataSet.StatusInf);

        }
    }
}

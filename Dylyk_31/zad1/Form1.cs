using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistyDataSet.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.turistyDataSet.Туры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistyDataSet.Информация_о_туристах". При необходимости она может быть перемещена или удалена.
            this.информация_о_туристахTableAdapter.Fill(this.turistyDataSet.Информация_о_туристах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistyDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.turistyDataSet.Туристы);

        }
    }
}

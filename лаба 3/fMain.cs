using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) ||
                string.IsNullOrEmpty(tbX2.Text))
            {
                tbY.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            tbM.Text = (x1 * x2 / 2).ToString();
            double Mx = double.Parse(tbM.Text);
            double y = ((Math.Sqrt(Math.Pow(x1, 3) + Math.Pow(x2, 5)) / (1000 * Math.Sqrt(x1 + Math.Pow(x2, 5))))) + 65;
            tbY.Text = y.ToString("0.####");
            this.chart1.Series[0].Points.AddXY(Mx, y);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbM.Text = string.Empty;
            this.chart1.Series[0].Points.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

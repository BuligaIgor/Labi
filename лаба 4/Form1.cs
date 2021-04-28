using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddCPU_Click(object sender, EventArgs e)
        {
            PC cmp = new PC();
            fPC fc = new fPC (cmp);
            if (fc.ShowDialog() == DialogResult.OK)
            {
                tbPCsInfo.Text +=
                    string.Format(
            "\r \n__________________________" +
            "\r \n  Дані про об’єкт" +
            "\r \n__________________________" +
            "\r \nНазва Корпусу: " + cmp.Case_name +
            "\r \nКількість оперативної памяті: " + cmp.Amount_of_RAM.ToString() +
            "\r \nНазва відеокарти: " + cmp.Video_card_name +
            "\r \nНазва процесора: " + cmp.Processor_name +
            "\r \nПотужність блока живлення: " + cmp.Power_supply.ToString("0.00") +
            "\r \nКількість портів: " + cmp.Number_of_ports.ToString() +
            "\r \nМатеринська плата: " + cmp.Motherboard_name +

            (cmp.Hard_drive_support ? "\r \nЄ підтримка Hard-drive-support" :
                             "\r \nНемає підтримки Hard-drive-support"));


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}

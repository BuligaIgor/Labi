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
    public partial class fPC : Form
    {
        public PC ThePC;
        public fPC(PC pc)
        {
            ThePC = pc;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePC.Case_name = tbCase_name.Text.Trim();
            ThePC.Video_card_name = tbVideo_card_name.Text.Trim();
            ThePC.Motherboard_name = tbMotherboard_name.Text.Trim();
            ThePC.Processor_name = tbProcessor_name.Text.Trim();
            ThePC.Number_of_ports = int.Parse(tbNumber_of_ports.Text.Trim());
            ThePC.Amount_of_RAM = int.Parse(tbAmount_of_RAM.Text.Trim());
            ThePC.Power_supply = double.Parse(tbPower_supply.Text.Trim());
            ThePC.Hard_drive_support = chbHard_drive_support.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fCPU_Load(object sender, EventArgs e)
        {
            if (ThePC != null)
            {
                tbCase_name.Text = ThePC.Case_name;
                tbVideo_card_name.Text = ThePC.Video_card_name;
                tbMotherboard_name.Text = ThePC.Motherboard_name;
                tbProcessor_name.Text = ThePC.Processor_name;
                tbAmount_of_RAM.Text = ThePC.Amount_of_RAM.ToString();
                tbNumber_of_ports.Text = ThePC.Number_of_ports.ToString();
                tbPower_supply.Text = ThePC.Power_supply.ToString("220");
                chbHard_drive_support.Checked = ThePC.Hard_drive_support;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

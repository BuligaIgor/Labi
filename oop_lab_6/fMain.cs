using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCPU.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Case_name";
            column.Name = "Корпус";
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Video_card_name";
            column.Name = "Відеокарта";
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Motherboard_name";
            column.Name = "Материнська плата";
            column.Width = 60;
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Processor_name";
            column.Name = "Процесор";
            column.Width = 60;
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Amount_of_RAM";
            column.Name = "Оперативна пам'ять";
            column.Width = 80;
            gvCPU.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Number_of_ports";
            column.Name = "Кількість портів";
            column.Width = 80;
            gvCPU.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Power_supply";
            column.Name = "Потужність блока живлення";
            gvCPU.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Hard_drive_support";
            column.Name = "Підтримка жосткого диска";
            gvCPU.Columns.Add(column);
            bindSrcCPU.Add(new PC("Fdragon", "Geforce 3080", "Asus GFD45", "AMD15", 1, 1, 1.0, true));
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PC pc = new PC();
            fPC ft = new fPC(pc);
            if (ft.ShowDialog() == DialogResult.OK)
                bindSrcCPU.Add(pc);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PC cpu = (PC)bindSrcCPU.List[bindSrcCPU.Position];
            fPC ft = new fPC(cpu);
            if (ft.ShowDialog() == DialogResult.OK)
                bindSrcCPU.List[bindSrcCPU.Position] = cpu;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
            "Видалення запису", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning) == DialogResult.OK)
                bindSrcCPU.RemoveCurrent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                bindSrcCPU.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}

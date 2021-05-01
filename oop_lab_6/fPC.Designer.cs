
namespace oop_lab_6
{
    partial class fPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCase_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chbHard_drive_support = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount_of_RAM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMotherboard_name = new System.Windows.Forms.TextBox();
            this.tbProcessor_name = new System.Windows.Forms.TextBox();
            this.tbVideo_card_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPower_supply = new System.Windows.Forms.TextBox();
            this.tbNumber_of_ports = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCase_name
            // 
            this.tbCase_name.Location = new System.Drawing.Point(220, 15);
            this.tbCase_name.Name = "tbCase_name";
            this.tbCase_name.Size = new System.Drawing.Size(150, 22);
            this.tbCase_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Корпус";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(318, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chbHard_drive_support
            // 
            this.chbHard_drive_support.AutoSize = true;
            this.chbHard_drive_support.Location = new System.Drawing.Point(9, 24);
            this.chbHard_drive_support.Name = "chbHard_drive_support";
            this.chbHard_drive_support.Size = new System.Drawing.Size(203, 21);
            this.chbHard_drive_support.TabIndex = 3;
            this.chbHard_drive_support.Text = "Підтримка жосткого диска";
            this.chbHard_drive_support.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbNumber_of_ports);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAmount_of_RAM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMotherboard_name);
            this.groupBox1.Controls.Add(this.tbCase_name);
            this.groupBox1.Controls.Add(this.tbProcessor_name);
            this.groupBox1.Controls.Add(this.tbVideo_card_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кількість оперативної пам\'яті";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Процесор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Материнська плата";
            // 
            // tbAmount_of_RAM
            // 
            this.tbAmount_of_RAM.Location = new System.Drawing.Point(220, 127);
            this.tbAmount_of_RAM.Name = "tbAmount_of_RAM";
            this.tbAmount_of_RAM.Size = new System.Drawing.Size(150, 22);
            this.tbAmount_of_RAM.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Відеокарта";
            // 
            // tbMotherboard_name
            // 
            this.tbMotherboard_name.Location = new System.Drawing.Point(220, 71);
            this.tbMotherboard_name.Name = "tbMotherboard_name";
            this.tbMotherboard_name.Size = new System.Drawing.Size(150, 22);
            this.tbMotherboard_name.TabIndex = 4;
            // 
            // tbProcessor_name
            // 
            this.tbProcessor_name.Location = new System.Drawing.Point(220, 99);
            this.tbProcessor_name.Name = "tbProcessor_name";
            this.tbProcessor_name.Size = new System.Drawing.Size(150, 22);
            this.tbProcessor_name.TabIndex = 6;
            // 
            // tbVideo_card_name
            // 
            this.tbVideo_card_name.Location = new System.Drawing.Point(220, 43);
            this.tbVideo_card_name.Name = "tbVideo_card_name";
            this.tbVideo_card_name.Size = new System.Drawing.Size(150, 22);
            this.tbVideo_card_name.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chbHard_drive_support);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додаткові дані";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Кількість портів";
            // 
            // tbPower_supply
            // 
            this.tbPower_supply.Location = new System.Drawing.Point(232, 187);
            this.tbPower_supply.Name = "tbPower_supply";
            this.tbPower_supply.Size = new System.Drawing.Size(150, 22);
            this.tbPower_supply.TabIndex = 10;
            // 
            // tbNumber_of_ports
            // 
            this.tbNumber_of_ports.Location = new System.Drawing.Point(220, 156);
            this.tbNumber_of_ports.Name = "tbNumber_of_ports";
            this.tbNumber_of_ports.Size = new System.Drawing.Size(150, 22);
            this.tbNumber_of_ports.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Потужність блока живлення";
            // 
            // fPC
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(422, 313);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPower_supply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fPC";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про комп\'ютер";
            this.Load += new System.EventHandler(this.fCPU_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCase_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chbHard_drive_support;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAmount_of_RAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProcessor_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMotherboard_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVideo_card_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPower_supply;
        private System.Windows.Forms.TextBox tbNumber_of_ports;
        private System.Windows.Forms.Label label8;
    }
}
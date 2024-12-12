namespace EnergyConsumption
{
    partial class apartmentRegisterForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Rooms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Residents = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Electricity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ElectricityCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Water = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Gas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.WaterCost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GasCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Heating = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HeatingCost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.FlatText = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.comboBoxHouseID = new System.Windows.Forms.ComboBox();
            this.changeDataButton = new System.Windows.Forms.Button();
            this.newDataButton = new System.Windows.Forms.Button();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.confirmDataButton = new System.Windows.Forms.Button();
            this.comboBoxFloor = new System.Windows.Forms.ComboBox();
            this.HeatingSystemType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(656, 161);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(656, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(683, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Apartment(FlatID)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(733, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose and click";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "HouseID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Floor";
            // 
            // Rooms
            // 
            this.Rooms.Enabled = false;
            this.Rooms.Location = new System.Drawing.Point(139, 220);
            this.Rooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(175, 22);
            this.Rooms.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(13, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rooms";
            // 
            // Area
            // 
            this.Area.Enabled = false;
            this.Area.Location = new System.Drawing.Point(139, 247);
            this.Area.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(175, 22);
            this.Area.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Area";
            // 
            // Residents
            // 
            this.Residents.Enabled = false;
            this.Residents.Location = new System.Drawing.Point(139, 277);
            this.Residents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Residents.Name = "Residents";
            this.Residents.Size = new System.Drawing.Size(175, 22);
            this.Residents.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Residents";
            // 
            // Electricity
            // 
            this.Electricity.Enabled = false;
            this.Electricity.Location = new System.Drawing.Point(139, 308);
            this.Electricity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Electricity.Name = "Electricity";
            this.Electricity.Size = new System.Drawing.Size(175, 22);
            this.Electricity.TabIndex = 15;
            this.Electricity.TextChanged += new System.EventHandler(this.Electricity_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Electricity";
            // 
            // ElectricityCost
            // 
            this.ElectricityCost.Enabled = false;
            this.ElectricityCost.Location = new System.Drawing.Point(139, 336);
            this.ElectricityCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ElectricityCost.Name = "ElectricityCost";
            this.ElectricityCost.Size = new System.Drawing.Size(175, 22);
            this.ElectricityCost.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(12, 338);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ElectricityCost";
            // 
            // Water
            // 
            this.Water.Enabled = false;
            this.Water.Location = new System.Drawing.Point(439, 162);
            this.Water.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(175, 22);
            this.Water.TabIndex = 19;
            this.Water.TextChanged += new System.EventHandler(this.Water_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(329, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Water";
            // 
            // Gas
            // 
            this.Gas.Enabled = false;
            this.Gas.Location = new System.Drawing.Point(439, 220);
            this.Gas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(175, 22);
            this.Gas.TabIndex = 21;
            this.Gas.TextChanged += new System.EventHandler(this.Gas_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(328, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gas";
            // 
            // WaterCost
            // 
            this.WaterCost.Enabled = false;
            this.WaterCost.Location = new System.Drawing.Point(439, 193);
            this.WaterCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WaterCost.Name = "WaterCost";
            this.WaterCost.Size = new System.Drawing.Size(175, 22);
            this.WaterCost.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(328, 193);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "WaterCost";
            // 
            // GasCost
            // 
            this.GasCost.Enabled = false;
            this.GasCost.Location = new System.Drawing.Point(439, 249);
            this.GasCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GasCost.Name = "GasCost";
            this.GasCost.Size = new System.Drawing.Size(175, 22);
            this.GasCost.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(329, 249);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "GasCost";
            // 
            // Heating
            // 
            this.Heating.Enabled = false;
            this.Heating.Location = new System.Drawing.Point(439, 279);
            this.Heating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Heating.Name = "Heating";
            this.Heating.Size = new System.Drawing.Size(175, 22);
            this.Heating.TabIndex = 27;
            this.Heating.TextChanged += new System.EventHandler(this.Heating_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(328, 279);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Heating";
            // 
            // HeatingCost
            // 
            this.HeatingCost.Enabled = false;
            this.HeatingCost.Location = new System.Drawing.Point(439, 308);
            this.HeatingCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeatingCost.Name = "HeatingCost";
            this.HeatingCost.Size = new System.Drawing.Size(175, 22);
            this.HeatingCost.TabIndex = 29;
            this.HeatingCost.TextChanged += new System.EventHandler(this.Heating_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(329, 308);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "HeatingCost";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(328, 336);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "HeatingType";
            // 
            // FlatText
            // 
            this.FlatText.AutoSize = true;
            this.FlatText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FlatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.FlatText.Location = new System.Drawing.Point(235, 58);
            this.FlatText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FlatText.Name = "FlatText";
            this.FlatText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlatText.Size = new System.Drawing.Size(160, 36);
            this.FlatText.TabIndex = 32;
            this.FlatText.Text = "Apartment";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.Control;
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.editButton.Location = new System.Drawing.Point(205, 406);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(219, 76);
            this.editButton.TabIndex = 33;
            this.editButton.Text = "Edit Data";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // comboBoxHouseID
            // 
            this.comboBoxHouseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHouseID.Enabled = false;
            this.comboBoxHouseID.FormattingEnabled = true;
            this.comboBoxHouseID.Location = new System.Drawing.Point(137, 161);
            this.comboBoxHouseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHouseID.Name = "comboBoxHouseID";
            this.comboBoxHouseID.Size = new System.Drawing.Size(175, 24);
            this.comboBoxHouseID.TabIndex = 34;
            this.comboBoxHouseID.SelectedIndexChanged += new System.EventHandler(this.comboBoxHouseID_SelectedIndexChanged);
            this.comboBoxHouseID.TextChanged += new System.EventHandler(this.comboBoxHouseID_TextChanged);
            // 
            // changeDataButton
            // 
            this.changeDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.changeDataButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.changeDataButton.FlatAppearance.BorderSize = 0;
            this.changeDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changeDataButton.Location = new System.Drawing.Point(43, 427);
            this.changeDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeDataButton.Name = "changeDataButton";
            this.changeDataButton.Size = new System.Drawing.Size(139, 46);
            this.changeDataButton.TabIndex = 36;
            this.changeDataButton.Text = "Change Data";
            this.changeDataButton.UseVisualStyleBackColor = false;
            this.changeDataButton.Visible = false;
            this.changeDataButton.Click += new System.EventHandler(this.changeDataButton_Click);
            // 
            // newDataButton
            // 
            this.newDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newDataButton.Location = new System.Drawing.Point(251, 425);
            this.newDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newDataButton.Name = "newDataButton";
            this.newDataButton.Size = new System.Drawing.Size(135, 46);
            this.newDataButton.TabIndex = 37;
            this.newDataButton.Text = "New Data";
            this.newDataButton.UseVisualStyleBackColor = false;
            this.newDataButton.Visible = false;
            this.newDataButton.Click += new System.EventHandler(this.newDataButton_Click);
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteDataButton.Location = new System.Drawing.Point(451, 425);
            this.deleteDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(139, 46);
            this.deleteDataButton.TabIndex = 38;
            this.deleteDataButton.Text = "Delete Data";
            this.deleteDataButton.UseVisualStyleBackColor = false;
            this.deleteDataButton.Visible = false;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // confirmDataButton
            // 
            this.confirmDataButton.BackColor = System.Drawing.Color.White;
            this.confirmDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confirmDataButton.Location = new System.Drawing.Point(251, 425);
            this.confirmDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmDataButton.Name = "confirmDataButton";
            this.confirmDataButton.Size = new System.Drawing.Size(135, 46);
            this.confirmDataButton.TabIndex = 39;
            this.confirmDataButton.Text = "Confirm";
            this.confirmDataButton.UseVisualStyleBackColor = false;
            this.confirmDataButton.Visible = false;
            this.confirmDataButton.Click += new System.EventHandler(this.confirmDataButton_Click);
            // 
            // comboBoxFloor
            // 
            this.comboBoxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFloor.Enabled = false;
            this.comboBoxFloor.FormattingEnabled = true;
            this.comboBoxFloor.Location = new System.Drawing.Point(139, 193);
            this.comboBoxFloor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFloor.Name = "comboBoxFloor";
            this.comboBoxFloor.Size = new System.Drawing.Size(175, 24);
            this.comboBoxFloor.TabIndex = 40;
            // 
            // HeatingSystemType
            // 
            this.HeatingSystemType.Enabled = false;
            this.HeatingSystemType.Location = new System.Drawing.Point(439, 334);
            this.HeatingSystemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeatingSystemType.Name = "HeatingSystemType";
            this.HeatingSystemType.Size = new System.Drawing.Size(175, 22);
            this.HeatingSystemType.TabIndex = 41;
            // 
            // apartmentRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 496);
            this.Controls.Add(this.HeatingSystemType);
            this.Controls.Add(this.comboBoxFloor);
            this.Controls.Add(this.confirmDataButton);
            this.Controls.Add(this.deleteDataButton);
            this.Controls.Add(this.newDataButton);
            this.Controls.Add(this.changeDataButton);
            this.Controls.Add(this.comboBoxHouseID);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.FlatText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.HeatingCost);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Heating);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GasCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WaterCost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Water);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ElectricityCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Electricity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Residents);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "apartmentRegisterForm";
            this.Text = "apartmentRegisterForm";
            this.Load += new System.EventHandler(this.apartmentRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Residents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Electricity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ElectricityCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Water;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Gas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox WaterCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GasCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Heating;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox HeatingCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label FlatText;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox comboBoxHouseID;
        private System.Windows.Forms.Button changeDataButton;
        private System.Windows.Forms.Button newDataButton;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.Button confirmDataButton;
        private System.Windows.Forms.ComboBox comboBoxFloor;
        private System.Windows.Forms.TextBox HeatingSystemType;
    }
}
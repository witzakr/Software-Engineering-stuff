namespace FinalAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            LoadCar = new Button();
            label9 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            CarSearch = new Button();
            LicensePlateSearch = new TextBox();
            BrandSearch = new TextBox();
            RemoveCar = new Button();
            ShowCarInfo = new Button();
            CarListBox = new ListBox();
            groupBox1 = new GroupBox();
            AddCar = new Button();
            MaintenanceIntervalNUD = new NumericUpDown();
            EndOfLifeMileageNUD = new NumericUpDown();
            CurrentMileageNUD = new NumericUpDown();
            LicensePlateNumberTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ModelTextBox = new TextBox();
            label2 = new Label();
            brandTextBox = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label18 = new Label();
            EmployeeRemove = new Button();
            ShowEmployeeInfo = new Button();
            LoadEmployee = new Button();
            EmployeeListBox = new ListBox();
            groupBox4 = new GroupBox();
            LastNameSearchTextBox = new TextBox();
            NameSearchTextBox = new TextBox();
            EmployeeSearch = new Button();
            label14 = new Label();
            label13 = new Label();
            groupBox3 = new GroupBox();
            AgeNUD = new NumericUpDown();
            EmployeeLastNameTextBox = new TextBox();
            EmployeeNameTextBox = new TextBox();
            EmployeeAdd = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tabPage3 = new TabPage();
            label19 = new Label();
            LoadTrip = new Button();
            RemoveTrip = new Button();
            ShowTripInfo = new Button();
            TripListBox = new ListBox();
            groupBox5 = new GroupBox();
            label17 = new Label();
            LenghtOfATripNUD = new NumericUpDown();
            AddTrip = new Button();
            EmployeesComboBox = new ComboBox();
            label16 = new Label();
            CarsComboBox = new ComboBox();
            label15 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaintenanceIntervalNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EndOfLifeMileageNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentMileageNUD).BeginInit();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgeNUD).BeginInit();
            tabPage3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LenghtOfATripNUD).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(850, 598);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LoadCar);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(RemoveCar);
            tabPage1.Controls.Add(ShowCarInfo);
            tabPage1.Controls.Add(CarListBox);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cars";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LoadCar
            // 
            LoadCar.Location = new Point(693, 68);
            LoadCar.Name = "LoadCar";
            LoadCar.Size = new Size(94, 140);
            LoadCar.TabIndex = 21;
            LoadCar.Text = "Load Data";
            LoadCar.UseVisualStyleBackColor = true;
            LoadCar.Click += LoadCar_Click;
            // 
            // label9
            // 
            label9.Location = new Point(436, 40);
            label9.Name = "label9";
            label9.Size = new Size(251, 25);
            label9.TabIndex = 19;
            label9.Text = "Car list";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(CarSearch);
            groupBox2.Controls.Add(LicensePlateSearch);
            groupBox2.Controls.Add(BrandSearch);
            groupBox2.Location = new Point(15, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 163);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search for car";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 4;
            label8.Text = "License plate number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 45);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 3;
            label7.Text = "Brand:";
            // 
            // CarSearch
            // 
            CarSearch.Location = new Point(6, 117);
            CarSearch.Name = "CarSearch";
            CarSearch.Size = new Size(278, 29);
            CarSearch.TabIndex = 2;
            CarSearch.Text = "Search";
            CarSearch.UseVisualStyleBackColor = true;
            CarSearch.Click += CarSearch_Click;
            // 
            // LicensePlateSearch
            // 
            LicensePlateSearch.Location = new Point(165, 75);
            LicensePlateSearch.Name = "LicensePlateSearch";
            LicensePlateSearch.Size = new Size(122, 27);
            LicensePlateSearch.TabIndex = 1;
            // 
            // BrandSearch
            // 
            BrandSearch.Location = new Point(61, 42);
            BrandSearch.Name = "BrandSearch";
            BrandSearch.Size = new Size(161, 27);
            BrandSearch.TabIndex = 0;
            // 
            // RemoveCar
            // 
            RemoveCar.Location = new Point(593, 502);
            RemoveCar.Name = "RemoveCar";
            RemoveCar.Size = new Size(94, 29);
            RemoveCar.TabIndex = 17;
            RemoveCar.Text = "Remove ";
            RemoveCar.UseVisualStyleBackColor = true;
            RemoveCar.Click += RemoveCar_Click;
            // 
            // ShowCarInfo
            // 
            ShowCarInfo.Location = new Point(436, 502);
            ShowCarInfo.Name = "ShowCarInfo";
            ShowCarInfo.Size = new Size(94, 29);
            ShowCarInfo.TabIndex = 16;
            ShowCarInfo.Text = "Show Info";
            ShowCarInfo.UseVisualStyleBackColor = true;
            ShowCarInfo.Click += ShowCarInfo_Click;
            // 
            // CarListBox
            // 
            CarListBox.FormattingEnabled = true;
            CarListBox.ItemHeight = 20;
            CarListBox.Location = new Point(436, 68);
            CarListBox.Name = "CarListBox";
            CarListBox.Size = new Size(251, 424);
            CarListBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddCar);
            groupBox1.Controls.Add(MaintenanceIntervalNUD);
            groupBox1.Controls.Add(EndOfLifeMileageNUD);
            groupBox1.Controls.Add(CurrentMileageNUD);
            groupBox1.Controls.Add(LicensePlateNumberTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ModelTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(brandTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 384);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car";
            // 
            // AddCar
            // 
            AddCar.Location = new Point(68, 294);
            AddCar.Name = "AddCar";
            AddCar.Size = new Size(181, 59);
            AddCar.TabIndex = 14;
            AddCar.Text = "Add car";
            AddCar.UseVisualStyleBackColor = true;
            AddCar.Click += AddCar_Click;
            // 
            // MaintenanceIntervalNUD
            // 
            MaintenanceIntervalNUD.Location = new Point(162, 156);
            MaintenanceIntervalNUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            MaintenanceIntervalNUD.Name = "MaintenanceIntervalNUD";
            MaintenanceIntervalNUD.Size = new Size(150, 27);
            MaintenanceIntervalNUD.TabIndex = 13;
            // 
            // EndOfLifeMileageNUD
            // 
            EndOfLifeMileageNUD.Location = new Point(162, 116);
            EndOfLifeMileageNUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            EndOfLifeMileageNUD.Name = "EndOfLifeMileageNUD";
            EndOfLifeMileageNUD.Size = new Size(150, 27);
            EndOfLifeMileageNUD.TabIndex = 12;
            // 
            // CurrentMileageNUD
            // 
            CurrentMileageNUD.Location = new Point(130, 198);
            CurrentMileageNUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            CurrentMileageNUD.Name = "CurrentMileageNUD";
            CurrentMileageNUD.Size = new Size(150, 27);
            CurrentMileageNUD.TabIndex = 11;
            // 
            // LicensePlateNumberTextBox
            // 
            LicensePlateNumberTextBox.Location = new Point(166, 235);
            LicensePlateNumberTextBox.Name = "LicensePlateNumberTextBox";
            LicensePlateNumberTextBox.Size = new Size(125, 27);
            LicensePlateNumberTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 238);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 9;
            label6.Text = "License plate number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 200);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 8;
            label5.Text = "Current Mileage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 158);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 6;
            label4.Text = "Maintenance Interval:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 118);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 4;
            label3.Text = "End of life mileage:";
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(68, 79);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(125, 27);
            ModelTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Model:";
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(68, 41);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(125, 27);
            brandTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Brand:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(EmployeeRemove);
            tabPage2.Controls.Add(ShowEmployeeInfo);
            tabPage2.Controls.Add(LoadEmployee);
            tabPage2.Controls.Add(EmployeeListBox);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Employees";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(432, 43);
            label18.Name = "label18";
            label18.Size = new Size(104, 20);
            label18.TabIndex = 25;
            label18.Text = "Employee List:";
            // 
            // EmployeeRemove
            // 
            EmployeeRemove.Location = new Point(520, 456);
            EmployeeRemove.Name = "EmployeeRemove";
            EmployeeRemove.Size = new Size(94, 29);
            EmployeeRemove.TabIndex = 24;
            EmployeeRemove.Text = "Remove ";
            EmployeeRemove.UseVisualStyleBackColor = true;
            EmployeeRemove.Click += EmployeeRemove_Click;
            // 
            // ShowEmployeeInfo
            // 
            ShowEmployeeInfo.Location = new Point(361, 456);
            ShowEmployeeInfo.Name = "ShowEmployeeInfo";
            ShowEmployeeInfo.Size = new Size(94, 29);
            ShowEmployeeInfo.TabIndex = 23;
            ShowEmployeeInfo.Text = "Show Info";
            ShowEmployeeInfo.UseVisualStyleBackColor = true;
            ShowEmployeeInfo.Click += ShowEmployeeInfo_Click;
            // 
            // LoadEmployee
            // 
            LoadEmployee.Location = new Point(620, 66);
            LoadEmployee.Name = "LoadEmployee";
            LoadEmployee.Size = new Size(94, 140);
            LoadEmployee.TabIndex = 22;
            LoadEmployee.Text = "Load Data";
            LoadEmployee.UseVisualStyleBackColor = true;
            LoadEmployee.Click += LoadEmployee_Click;
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 20;
            EmployeeListBox.Location = new Point(361, 66);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(253, 384);
            EmployeeListBox.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(LastNameSearchTextBox);
            groupBox4.Controls.Add(NameSearchTextBox);
            groupBox4.Controls.Add(EmployeeSearch);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(8, 297);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 153);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search for employee";
            // 
            // LastNameSearchTextBox
            // 
            LastNameSearchTextBox.Location = new Point(104, 65);
            LastNameSearchTextBox.Name = "LastNameSearchTextBox";
            LastNameSearchTextBox.Size = new Size(125, 27);
            LastNameSearchTextBox.TabIndex = 5;
            // 
            // NameSearchTextBox
            // 
            NameSearchTextBox.Location = new Point(72, 31);
            NameSearchTextBox.Name = "NameSearchTextBox";
            NameSearchTextBox.Size = new Size(125, 27);
            NameSearchTextBox.TabIndex = 4;
            // 
            // EmployeeSearch
            // 
            EmployeeSearch.Location = new Point(6, 105);
            EmployeeSearch.Name = "EmployeeSearch";
            EmployeeSearch.Size = new Size(238, 29);
            EmployeeSearch.TabIndex = 2;
            EmployeeSearch.Text = "Search";
            EmployeeSearch.UseVisualStyleBackColor = true;
            EmployeeSearch.Click += EmployeeSearch_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 68);
            label14.Name = "label14";
            label14.Size = new Size(82, 20);
            label14.TabIndex = 1;
            label14.Text = "Last Name:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 34);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 0;
            label13.Text = "Name:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(AgeNUD);
            groupBox3.Controls.Add(EmployeeLastNameTextBox);
            groupBox3.Controls.Add(EmployeeNameTextBox);
            groupBox3.Controls.Add(EmployeeAdd);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(6, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 252);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Employee";
            // 
            // AgeNUD
            // 
            AgeNUD.Location = new Point(59, 109);
            AgeNUD.Name = "AgeNUD";
            AgeNUD.Size = new Size(131, 27);
            AgeNUD.TabIndex = 17;
            // 
            // EmployeeLastNameTextBox
            // 
            EmployeeLastNameTextBox.Location = new Point(96, 64);
            EmployeeLastNameTextBox.Name = "EmployeeLastNameTextBox";
            EmployeeLastNameTextBox.Size = new Size(125, 27);
            EmployeeLastNameTextBox.TabIndex = 16;
            // 
            // EmployeeNameTextBox
            // 
            EmployeeNameTextBox.Location = new Point(74, 24);
            EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            EmployeeNameTextBox.Size = new Size(125, 27);
            EmployeeNameTextBox.TabIndex = 4;
            // 
            // EmployeeAdd
            // 
            EmployeeAdd.Location = new Point(28, 172);
            EmployeeAdd.Name = "EmployeeAdd";
            EmployeeAdd.Size = new Size(181, 59);
            EmployeeAdd.TabIndex = 15;
            EmployeeAdd.Text = "Add an employee";
            EmployeeAdd.UseVisualStyleBackColor = true;
            EmployeeAdd.Click += EmployeeAdd_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 109);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 2;
            label12.Text = "Age:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 67);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 1;
            label11.Text = "Last Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 27);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 0;
            label10.Text = "Name:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(LoadTrip);
            tabPage3.Controls.Add(RemoveTrip);
            tabPage3.Controls.Add(ShowTripInfo);
            tabPage3.Controls.Add(TripListBox);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(842, 565);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Trips";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(534, 52);
            label19.Name = "label19";
            label19.Size = new Size(63, 20);
            label19.TabIndex = 24;
            label19.Text = "Trip List:";
            // 
            // LoadTrip
            // 
            LoadTrip.Location = new Point(675, 75);
            LoadTrip.Name = "LoadTrip";
            LoadTrip.Size = new Size(94, 140);
            LoadTrip.TabIndex = 23;
            LoadTrip.Text = "Load Data";
            LoadTrip.UseVisualStyleBackColor = true;
            LoadTrip.Click += LoadTrip_Click;
            // 
            // RemoveTrip
            // 
            RemoveTrip.Location = new Point(575, 445);
            RemoveTrip.Name = "RemoveTrip";
            RemoveTrip.Size = new Size(94, 29);
            RemoveTrip.TabIndex = 7;
            RemoveTrip.Text = "Remove";
            RemoveTrip.UseVisualStyleBackColor = true;
            RemoveTrip.Click += RemoveTrip_Click;
            // 
            // ShowTripInfo
            // 
            ShowTripInfo.Location = new Point(462, 445);
            ShowTripInfo.Name = "ShowTripInfo";
            ShowTripInfo.Size = new Size(94, 29);
            ShowTripInfo.TabIndex = 6;
            ShowTripInfo.Text = "Show info";
            ShowTripInfo.UseVisualStyleBackColor = true;
            ShowTripInfo.Click += ShowTripInfo_Click;
            // 
            // TripListBox
            // 
            TripListBox.FormattingEnabled = true;
            TripListBox.ItemHeight = 20;
            TripListBox.Location = new Point(462, 75);
            TripListBox.Name = "TripListBox";
            TripListBox.Size = new Size(207, 364);
            TripListBox.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(LenghtOfATripNUD);
            groupBox5.Controls.Add(AddTrip);
            groupBox5.Controls.Add(EmployeesComboBox);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(CarsComboBox);
            groupBox5.Controls.Add(label15);
            groupBox5.Location = new Point(8, 75);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(320, 333);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Trip";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 146);
            label17.Name = "label17";
            label17.Size = new Size(114, 20);
            label17.TabIndex = 24;
            label17.Text = "Lenght of a trip:";
            // 
            // LenghtOfATripNUD
            // 
            LenghtOfATripNUD.Location = new Point(135, 144);
            LenghtOfATripNUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            LenghtOfATripNUD.Name = "LenghtOfATripNUD";
            LenghtOfATripNUD.Size = new Size(150, 27);
            LenghtOfATripNUD.TabIndex = 5;
            // 
            // AddTrip
            // 
            AddTrip.Location = new Point(105, 198);
            AddTrip.Name = "AddTrip";
            AddTrip.Size = new Size(107, 46);
            AddTrip.TabIndex = 4;
            AddTrip.Text = "Add trip";
            AddTrip.UseVisualStyleBackColor = true;
            AddTrip.Click += AddTrip_Click;
            // 
            // EmployeesComboBox
            // 
            EmployeesComboBox.FormattingEnabled = true;
            EmployeesComboBox.Location = new Point(105, 89);
            EmployeesComboBox.Name = "EmployeesComboBox";
            EmployeesComboBox.Size = new Size(151, 28);
            EmployeesComboBox.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 92);
            label16.Name = "label16";
            label16.Size = new Size(84, 20);
            label16.TabIndex = 2;
            label16.Text = "Employees:";
            // 
            // CarsComboBox
            // 
            CarsComboBox.FormattingEnabled = true;
            CarsComboBox.Location = new Point(61, 40);
            CarsComboBox.Name = "CarsComboBox";
            CarsComboBox.Size = new Size(151, 28);
            CarsComboBox.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 40);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 0;
            label15.Text = "Cars:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 596);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaintenanceIntervalNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)EndOfLifeMileageNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrentMileageNUD).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AgeNUD).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LenghtOfATripNUD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button RemoveCar;
        private Button ShowCarInfo;
        private ListBox CarListBox;
        private GroupBox groupBox1;
        private Button AddCar;
        private NumericUpDown MaintenanceIntervalNUD;
        private NumericUpDown EndOfLifeMileageNUD;
        private NumericUpDown CurrentMileageNUD;
        private TextBox LicensePlateNumberTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox ModelTextBox;
        private Label label2;
        private TextBox brandTextBox;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label9;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Button CarSearch;
        private TextBox LicensePlateSearch;
        private TextBox BrandSearch;
        private Button LoadCar;
        private ListBox EmployeeListBox;
        private GroupBox groupBox4;
        private Button EmployeeSearch;
        private Label label14;
        private Label label13;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox LastNameSearchTextBox;
        private TextBox NameSearchTextBox;
        private NumericUpDown AgeNUD;
        private TextBox EmployeeLastNameTextBox;
        private TextBox EmployeeNameTextBox;
        private Button EmployeeAdd;
        private Button EmployeeRemove;
        private Button ShowEmployeeInfo;
        private Button LoadEmployee;
        private Button LoadTrip;
        private Button RemoveTrip;
        private Button ShowTripInfo;
        private ListBox TripListBox;
        private GroupBox groupBox5;
        private Button AddTrip;
        private ComboBox EmployeesComboBox;
        private Label label16;
        private ComboBox CarsComboBox;
        private Label label15;
        private NumericUpDown LenghtOfATripNUD;
        private Label label17;
        private Label label18;
        private Label label19;
    }
}
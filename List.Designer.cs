
namespace RTiPPO
{
    partial class List
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OMSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaptDogs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaptCats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaptSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportExcel = new System.Windows.Forms.Button();
            this.OpenCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DateMinMK = new System.Windows.Forms.DateTimePicker();
            this.CheckDateMK = new System.Windows.Forms.CheckBox();
            this.DateMaxMK = new System.Windows.Forms.DateTimePicker();
            this.DateMaxCapt = new System.Windows.Forms.DateTimePicker();
            this.DateMinCapt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CaptMinDogs = new System.Windows.Forms.NumericUpDown();
            this.CaptMaxSum = new System.Windows.Forms.NumericUpDown();
            this.CaptMinSum = new System.Windows.Forms.NumericUpDown();
            this.CaptMaxCats = new System.Windows.Forms.NumericUpDown();
            this.CaptMinCats = new System.Windows.Forms.NumericUpDown();
            this.CaptMaxDogs = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CheckDateCapt = new System.Windows.Forms.CheckBox();
            this.DoFilter = new System.Windows.Forms.Button();
            this.ThrowOffFilter = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMinDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMaxSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMinSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMaxCats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMinCats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMaxDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumMK,
            this.DateMK,
            this.Municipality,
            this.OMSU,
            this.Executor,
            this.ActNum,
            this.CaptDogs,
            this.CaptCats,
            this.CaptSum,
            this.Locality,
            this.CaptDate,
            this.Purpose});
            this.dataGridView1.Location = new System.Drawing.Point(0, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumMK
            // 
            this.NumMK.Frozen = true;
            this.NumMK.HeaderText = "Номер МК";
            this.NumMK.Name = "NumMK";
            this.NumMK.ReadOnly = true;
            // 
            // DateMK
            // 
            this.DateMK.Frozen = true;
            this.DateMK.HeaderText = "Дата заключения МК";
            this.DateMK.Name = "DateMK";
            this.DateMK.ReadOnly = true;
            // 
            // Municipality
            // 
            this.Municipality.Frozen = true;
            this.Municipality.HeaderText = "Муниципальное образование";
            this.Municipality.Name = "Municipality";
            this.Municipality.ReadOnly = true;
            // 
            // OMSU
            // 
            this.OMSU.Frozen = true;
            this.OMSU.HeaderText = "ОМСУ";
            this.OMSU.Name = "OMSU";
            this.OMSU.ReadOnly = true;
            // 
            // Executor
            // 
            this.Executor.Frozen = true;
            this.Executor.HeaderText = "Исполнитель МК";
            this.Executor.Name = "Executor";
            this.Executor.ReadOnly = true;
            // 
            // ActNum
            // 
            this.ActNum.Frozen = true;
            this.ActNum.HeaderText = "Номер акта отлова";
            this.ActNum.Name = "ActNum";
            this.ActNum.ReadOnly = true;
            // 
            // CaptDogs
            // 
            this.CaptDogs.Frozen = true;
            this.CaptDogs.HeaderText = "Количество отловленных собак";
            this.CaptDogs.Name = "CaptDogs";
            this.CaptDogs.ReadOnly = true;
            // 
            // CaptCats
            // 
            this.CaptCats.Frozen = true;
            this.CaptCats.HeaderText = "Количество отловленных кошек";
            this.CaptCats.Name = "CaptCats";
            this.CaptCats.ReadOnly = true;
            // 
            // CaptSum
            // 
            this.CaptSum.Frozen = true;
            this.CaptSum.HeaderText = "Количество отловленных животных";
            this.CaptSum.Name = "CaptSum";
            this.CaptSum.ReadOnly = true;
            // 
            // Locality
            // 
            this.Locality.Frozen = true;
            this.Locality.HeaderText = "Населённый пункт";
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            // 
            // CaptDate
            // 
            this.CaptDate.Frozen = true;
            this.CaptDate.HeaderText = "Дата отлова";
            this.CaptDate.Name = "CaptDate";
            this.CaptDate.ReadOnly = true;
            // 
            // Purpose
            // 
            this.Purpose.Frozen = true;
            this.Purpose.HeaderText = "Цель отлова";
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            // 
            // ExportExcel
            // 
            this.ExportExcel.Location = new System.Drawing.Point(12, 960);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(143, 23);
            this.ExportExcel.TabIndex = 1;
            this.ExportExcel.Text = "Экспортировать в Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            // 
            // OpenCard
            // 
            this.OpenCard.Location = new System.Drawing.Point(1156, 960);
            this.OpenCard.Name = "OpenCard";
            this.OpenCard.Size = new System.Drawing.Size(75, 23);
            this.OpenCard.TabIndex = 2;
            this.OpenCard.Text = "Открыть";
            this.OpenCard.UseVisualStyleBackColor = true;
            this.OpenCard.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фильтры";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер МК";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Муниципальное образование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1034, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "ОМСУ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Исполнитель МК ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Номер акта отлова";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Количество отловленных собак";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Количество отловленных кошек";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Населённый пункт";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(821, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Количество отловленных животных";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "От";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "До";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(484, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "До";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(484, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "От";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(674, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "До";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(674, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "От";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(868, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 15);
            this.label19.TabIndex = 23;
            this.label19.Text = "До";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(868, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 15);
            this.label20.TabIndex = 22;
            this.label20.Text = "От";
            // 
            // DateMinMK
            // 
            this.DateMinMK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMinMK.Location = new System.Drawing.Point(182, 64);
            this.DateMinMK.Name = "DateMinMK";
            this.DateMinMK.Size = new System.Drawing.Size(98, 23);
            this.DateMinMK.TabIndex = 24;
            // 
            // CheckDateMK
            // 
            this.CheckDateMK.AutoSize = true;
            this.CheckDateMK.Location = new System.Drawing.Point(147, 33);
            this.CheckDateMK.Name = "CheckDateMK";
            this.CheckDateMK.Size = new System.Drawing.Size(142, 19);
            this.CheckDateMK.TabIndex = 25;
            this.CheckDateMK.Text = "Дата заключения МК";
            this.CheckDateMK.UseVisualStyleBackColor = true;
            // 
            // DateMaxMK
            // 
            this.DateMaxMK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMaxMK.Location = new System.Drawing.Point(182, 99);
            this.DateMaxMK.Name = "DateMaxMK";
            this.DateMaxMK.Size = new System.Drawing.Size(98, 23);
            this.DateMaxMK.TabIndex = 26;
            // 
            // DateMaxCapt
            // 
            this.DateMaxCapt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMaxCapt.Location = new System.Drawing.Point(1068, 97);
            this.DateMaxCapt.Name = "DateMaxCapt";
            this.DateMaxCapt.Size = new System.Drawing.Size(98, 23);
            this.DateMaxCapt.TabIndex = 30;
            // 
            // DateMinCapt
            // 
            this.DateMinCapt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMinCapt.Location = new System.Drawing.Point(1068, 62);
            this.DateMinCapt.Name = "DateMinCapt";
            this.DateMinCapt.Size = new System.Drawing.Size(98, 23);
            this.DateMinCapt.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1041, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "До";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1041, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 15);
            this.label21.TabIndex = 27;
            this.label21.Text = "От";
            // 
            // CaptMinDogs
            // 
            this.CaptMinDogs.Location = new System.Drawing.Point(511, 64);
            this.CaptMinDogs.Name = "CaptMinDogs";
            this.CaptMinDogs.Size = new System.Drawing.Size(54, 23);
            this.CaptMinDogs.TabIndex = 31;
            // 
            // CaptMaxSum
            // 
            this.CaptMaxSum.Location = new System.Drawing.Point(895, 99);
            this.CaptMaxSum.Name = "CaptMaxSum";
            this.CaptMaxSum.Size = new System.Drawing.Size(54, 23);
            this.CaptMaxSum.TabIndex = 32;
            // 
            // CaptMinSum
            // 
            this.CaptMinSum.Location = new System.Drawing.Point(895, 64);
            this.CaptMinSum.Name = "CaptMinSum";
            this.CaptMinSum.Size = new System.Drawing.Size(54, 23);
            this.CaptMinSum.TabIndex = 33;
            // 
            // CaptMaxCats
            // 
            this.CaptMaxCats.Location = new System.Drawing.Point(701, 99);
            this.CaptMaxCats.Name = "CaptMaxCats";
            this.CaptMaxCats.Size = new System.Drawing.Size(54, 23);
            this.CaptMaxCats.TabIndex = 34;
            // 
            // CaptMinCats
            // 
            this.CaptMinCats.Location = new System.Drawing.Point(701, 64);
            this.CaptMinCats.Name = "CaptMinCats";
            this.CaptMinCats.Size = new System.Drawing.Size(54, 23);
            this.CaptMinCats.TabIndex = 35;
            // 
            // CaptMaxDogs
            // 
            this.CaptMaxDogs.Location = new System.Drawing.Point(512, 99);
            this.CaptMaxDogs.Name = "CaptMaxDogs";
            this.CaptMaxDogs.Size = new System.Drawing.Size(54, 23);
            this.CaptMaxDogs.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(307, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 23);
            this.textBox2.TabIndex = 37;
            // 
            // CheckDateCapt
            // 
            this.CheckDateCapt.AutoSize = true;
            this.CheckDateCapt.Location = new System.Drawing.Point(1058, 33);
            this.CheckDateCapt.Name = "CheckDateCapt";
            this.CheckDateCapt.Size = new System.Drawing.Size(92, 19);
            this.CheckDateCapt.TabIndex = 38;
            this.CheckDateCapt.Text = "Дата отлова";
            this.CheckDateCapt.UseVisualStyleBackColor = true;
            // 
            // DoFilter
            // 
            this.DoFilter.Location = new System.Drawing.Point(93, 5);
            this.DoFilter.Name = "DoFilter";
            this.DoFilter.Size = new System.Drawing.Size(88, 23);
            this.DoFilter.TabIndex = 43;
            this.DoFilter.Text = "Применить";
            this.DoFilter.UseVisualStyleBackColor = true;
            // 
            // ThrowOffFilter
            // 
            this.ThrowOffFilter.Location = new System.Drawing.Point(201, 5);
            this.ThrowOffFilter.Name = "ThrowOffFilter";
            this.ThrowOffFilter.Size = new System.Drawing.Size(103, 23);
            this.ThrowOffFilter.TabIndex = 44;
            this.ThrowOffFilter.Text = "Сбросить всё";
            this.ThrowOffFilter.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1075, 960);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 45;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(994, 960);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 23);
            this.textBox3.TabIndex = 47;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(958, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(223, 23);
            this.textBox4.TabIndex = 48;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(642, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(223, 23);
            this.textBox5.TabIndex = 49;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(307, 180);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(223, 23);
            this.textBox6.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "Город1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(307, 243);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 15);
            this.label22.TabIndex = 52;
            this.label22.Text = "МО2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(307, 217);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 15);
            this.label23.TabIndex = 53;
            this.label23.Text = "МО1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 243);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 15);
            this.label24.TabIndex = 54;
            this.label24.Text = "Поселок2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(642, 269);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 15);
            this.label25.TabIndex = 55;
            this.label25.Text = "Аноним";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(642, 243);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 15);
            this.label26.TabIndex = 56;
            this.label26.Text = "Исполнитель";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(642, 217);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 15);
            this.label27.TabIndex = 57;
            this.label27.Text = "Иван Иванов";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(958, 217);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 15);
            this.label28.TabIndex = 58;
            this.label28.Text = "ОМСУ1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(207, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 59;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(207, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(511, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 61;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(511, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 62;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(837, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 23);
            this.button6.TabIndex = 63;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(837, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 23);
            this.button7.TabIndex = 64;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(837, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 23);
            this.button8.TabIndex = 65;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(1156, 213);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 23);
            this.button9.TabIndex = 66;
            this.button9.Text = "X";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 749);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ThrowOffFilter);
            this.Controls.Add(this.DoFilter);
            this.Controls.Add(this.CheckDateCapt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CaptMaxDogs);
            this.Controls.Add(this.CaptMinCats);
            this.Controls.Add(this.CaptMaxCats);
            this.Controls.Add(this.CaptMinSum);
            this.Controls.Add(this.CaptMaxSum);
            this.Controls.Add(this.CaptMinDogs);
            this.Controls.Add(this.DateMaxCapt);
            this.Controls.Add(this.DateMinCapt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.DateMaxMK);
            this.Controls.Add(this.CheckDateMK);
            this.Controls.Add(this.DateMinMK);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenCard);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMinDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMaxSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMinSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMaxCats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMinCats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptMaxDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipality;
        private System.Windows.Forms.DataGridViewTextBoxColumn OMSU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaptDogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaptCats;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaptSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locality;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.Button ExportExcel;
        private System.Windows.Forms.Button OpenCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker DateMinMK;
        private System.Windows.Forms.CheckBox CheckDateMK;
        private System.Windows.Forms.DateTimePicker DateMaxMK;
        private System.Windows.Forms.DateTimePicker DateMaxCapt;
        private System.Windows.Forms.DateTimePicker DateMinCapt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown CaptMinDogs;
        private System.Windows.Forms.NumericUpDown CaptMaxSum;
        private System.Windows.Forms.NumericUpDown CaptMinSum;
        private System.Windows.Forms.NumericUpDown CaptMaxCats;
        private System.Windows.Forms.NumericUpDown CaptMinCats;
        private System.Windows.Forms.NumericUpDown CaptMaxDogs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox CheckDateCapt;
        private System.Windows.Forms.CheckedListBox CheckLocality;
        private System.Windows.Forms.CheckedListBox CheckMunicipality;
        private System.Windows.Forms.CheckedListBox CheckExecutor;
        private System.Windows.Forms.CheckedListBox CheckOMSU;
        private System.Windows.Forms.Button DoFilter;
        private System.Windows.Forms.Button ThrowOffFilter;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}


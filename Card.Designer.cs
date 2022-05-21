namespace RTiPPO
{
    partial class card
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
            this.title = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DateCapt = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LocalityComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AnimalsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberActTextBox = new System.Windows.Forms.TextBox();
            this.ContractorMK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberMKTextBox = new System.Windows.Forms.TextBox();
            this.OMSUComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MunicipalityComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateMK = new System.Windows.Forms.DateTimePicker();
            this.CloseForm = new System.Windows.Forms.Button();
            this.ExportWord = new System.Windows.Forms.Button();
            this.CaptOfPurpose = new System.Windows.Forms.TextBox();
            this.DogsCount = new System.Windows.Forms.NumericUpDown();
            this.CatsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DogsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Location = new System.Drawing.Point(3, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(408, 45);
            this.title.TabIndex = 6;
            this.title.Text = "Карточка акта отлова";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(91, 540);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(125, 23);
            this.CreateButton.TabIndex = 57;
            this.CreateButton.Text = "Сохранить";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DateCapt
            // 
            this.DateCapt.Enabled = false;
            this.DateCapt.Location = new System.Drawing.Point(239, 145);
            this.DateCapt.Name = "DateCapt";
            this.DateCapt.Size = new System.Drawing.Size(172, 23);
            this.DateCapt.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 54;
            this.label14.Text = "Цель отлова";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 53;
            this.label13.Text = "Дата отлова";
            // 
            // LocalityComboBox
            // 
            this.LocalityComboBox.Enabled = false;
            this.LocalityComboBox.FormattingEnabled = true;
            this.LocalityComboBox.Location = new System.Drawing.Point(44, 444);
            this.LocalityComboBox.Name = "LocalityComboBox";
            this.LocalityComboBox.Size = new System.Drawing.Size(367, 23);
            this.LocalityComboBox.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 51;
            this.label12.Text = "Населенный пункт";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "Животные:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Кошки:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Собаки:";
            // 
            // AnimalsTextBox
            // 
            this.AnimalsTextBox.Location = new System.Drawing.Point(327, 390);
            this.AnimalsTextBox.Name = "AnimalsTextBox";
            this.AnimalsTextBox.ReadOnly = true;
            this.AnimalsTextBox.Size = new System.Drawing.Size(84, 23);
            this.AnimalsTextBox.TabIndex = 47;
            this.AnimalsTextBox.Text = "0";
            this.AnimalsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(158, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Количество отловленных:";
            // 
            // DogsTextBox
            // 
            this.DogsTextBox.Location = new System.Drawing.Point(44, 390);
            this.DogsTextBox.Name = "DogsTextBox";
            this.DogsTextBox.ReadOnly = true;
            this.DogsTextBox.Size = new System.Drawing.Size(84, 23);
            this.DogsTextBox.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Номер акта отлова";
            // 
            // NumberActTextBox
            // 
            this.NumberActTextBox.Location = new System.Drawing.Point(239, 93);
            this.NumberActTextBox.Name = "NumberActTextBox";
            this.NumberActTextBox.ReadOnly = true;
            this.NumberActTextBox.Size = new System.Drawing.Size(172, 23);
            this.NumberActTextBox.TabIndex = 42;
            this.NumberActTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberActTextBox_KeyPress);
            // 
            // ContractorMK
            // 
            this.ContractorMK.Enabled = false;
            this.ContractorMK.FormattingEnabled = true;
            this.ContractorMK.Location = new System.Drawing.Point(44, 306);
            this.ContractorMK.Name = "ContractorMK";
            this.ContractorMK.Size = new System.Drawing.Size(367, 23);
            this.ContractorMK.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Исполнитель МК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Номер МК";
            // 
            // NumberMKTextBox
            // 
            this.NumberMKTextBox.Location = new System.Drawing.Point(44, 93);
            this.NumberMKTextBox.Name = "NumberMKTextBox";
            this.NumberMKTextBox.ReadOnly = true;
            this.NumberMKTextBox.Size = new System.Drawing.Size(172, 23);
            this.NumberMKTextBox.TabIndex = 38;
            this.NumberMKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberMKTextBox_KeyPress);
            // 
            // OMSUComboBox
            // 
            this.OMSUComboBox.Enabled = false;
            this.OMSUComboBox.FormattingEnabled = true;
            this.OMSUComboBox.Location = new System.Drawing.Point(44, 254);
            this.OMSUComboBox.Name = "OMSUComboBox";
            this.OMSUComboBox.Size = new System.Drawing.Size(367, 23);
            this.OMSUComboBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "ОМСУ";
            // 
            // MunicipalityComboBox
            // 
            this.MunicipalityComboBox.Enabled = false;
            this.MunicipalityComboBox.FormattingEnabled = true;
            this.MunicipalityComboBox.Location = new System.Drawing.Point(44, 200);
            this.MunicipalityComboBox.Name = "MunicipalityComboBox";
            this.MunicipalityComboBox.Size = new System.Drawing.Size(367, 23);
            this.MunicipalityComboBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Муниципальное образование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Дата заключение МК";
            // 
            // DateMK
            // 
            this.DateMK.Enabled = false;
            this.DateMK.Location = new System.Drawing.Point(44, 145);
            this.DateMK.Name = "DateMK";
            this.DateMK.Size = new System.Drawing.Size(172, 23);
            this.DateMK.TabIndex = 32;
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.Color.IndianRed;
            this.CloseForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(417, 12);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(26, 27);
            this.CloseForm.TabIndex = 58;
            this.CloseForm.Text = "x";
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click_1);
            // 
            // ExportWord
            // 
            this.ExportWord.Location = new System.Drawing.Point(239, 540);
            this.ExportWord.Name = "ExportWord";
            this.ExportWord.Size = new System.Drawing.Size(125, 23);
            this.ExportWord.TabIndex = 59;
            this.ExportWord.Text = "Экспорт в Word";
            this.ExportWord.UseVisualStyleBackColor = true;
            this.ExportWord.Click += new System.EventHandler(this.ExportWord_Click);
            // 
            // CaptOfPurpose
            // 
            this.CaptOfPurpose.Location = new System.Drawing.Point(44, 488);
            this.CaptOfPurpose.Name = "CaptOfPurpose";
            this.CaptOfPurpose.Size = new System.Drawing.Size(367, 23);
            this.CaptOfPurpose.TabIndex = 60;
            // 
            // DogsCount
            // 
            this.DogsCount.Location = new System.Drawing.Point(44, 390);
            this.DogsCount.Name = "DogsCount";
            this.DogsCount.Size = new System.Drawing.Size(84, 23);
            this.DogsCount.TabIndex = 61;
            this.DogsCount.ValueChanged += new System.EventHandler(this.DogsCount_ValueChanged);
            this.DogsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DogsCount_KeyPress);
            // 
            // CatsCount
            // 
            this.CatsCount.Location = new System.Drawing.Point(192, 390);
            this.CatsCount.Name = "CatsCount";
            this.CatsCount.Size = new System.Drawing.Size(84, 23);
            this.CatsCount.TabIndex = 62;
            this.CatsCount.ValueChanged += new System.EventHandler(this.CatsCount_ValueChanged);
            this.CatsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CatsCount_KeyPress);
            // 
            // card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 586);
            this.Controls.Add(this.CatsCount);
            this.Controls.Add(this.DogsCount);
            this.Controls.Add(this.CaptOfPurpose);
            this.Controls.Add(this.ExportWord);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DateCapt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LocalityComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AnimalsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberActTextBox);
            this.Controls.Add(this.ContractorMK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberMKTextBox);
            this.Controls.Add(this.OMSUComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MunicipalityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateMK);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DogsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DateTimePicker DateCapt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox LocalityComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AnimalsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumberActTextBox;
        private System.Windows.Forms.ComboBox ContractorMK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumberMKTextBox;
        private System.Windows.Forms.ComboBox OMSUComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MunicipalityComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateMK;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button ExportWord;
        private System.Windows.Forms.TextBox CaptOfPurpose;
        private System.Windows.Forms.NumericUpDown DogsCount;
        private System.Windows.Forms.NumericUpDown CatsCount;
    }
}
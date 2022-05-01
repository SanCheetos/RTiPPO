namespace RTiPPO
{
    partial class AddForm
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
            this.DateMK = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MunicipalityComboBox = new System.Windows.Forms.ComboBox();
            this.OMSUComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberMKTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ContractorMKComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberActTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AnimalsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LocalityComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DateCapt = new System.Windows.Forms.DateTimePicker();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CaptOfPurposeTextBox = new System.Windows.Forms.TextBox();
            this.DogsCount = new System.Windows.Forms.NumericUpDown();
            this.CatsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DogsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // DateMK
            // 
            this.DateMK.Location = new System.Drawing.Point(24, 156);
            this.DateMK.Name = "DateMK";
            this.DateMK.Size = new System.Drawing.Size(172, 23);
            this.DateMK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата заключение МК";
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.Color.IndianRed;
            this.CloseForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseForm.Location = new System.Drawing.Point(376, 12);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(26, 27);
            this.CloseForm.TabIndex = 4;
            this.CloseForm.Text = "x";
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Новая запись";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Муниципальное образование";
            // 
            // MunicipalityComboBox
            // 
            this.MunicipalityComboBox.FormattingEnabled = true;
            this.MunicipalityComboBox.Location = new System.Drawing.Point(24, 211);
            this.MunicipalityComboBox.Name = "MunicipalityComboBox";
            this.MunicipalityComboBox.Size = new System.Drawing.Size(367, 23);
            this.MunicipalityComboBox.TabIndex = 8;
            this.MunicipalityComboBox.TextUpdate += new System.EventHandler(this.MunicipalityComboBox_TextUpdate);
            // 
            // OMSUComboBox
            // 
            this.OMSUComboBox.FormattingEnabled = true;
            this.OMSUComboBox.Location = new System.Drawing.Point(24, 265);
            this.OMSUComboBox.Name = "OMSUComboBox";
            this.OMSUComboBox.Size = new System.Drawing.Size(367, 23);
            this.OMSUComboBox.TabIndex = 10;
            this.OMSUComboBox.TextUpdate += new System.EventHandler(this.OMSUComboBox_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "ОМСУ";
            // 
            // NumberMKTextBox
            // 
            this.NumberMKTextBox.Location = new System.Drawing.Point(24, 104);
            this.NumberMKTextBox.Name = "NumberMKTextBox";
            this.NumberMKTextBox.PlaceholderText = "0000";
            this.NumberMKTextBox.Size = new System.Drawing.Size(172, 23);
            this.NumberMKTextBox.TabIndex = 11;
            this.NumberMKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberMKTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер МК";
            // 
            // ContractorMKComboBox
            // 
            this.ContractorMKComboBox.FormattingEnabled = true;
            this.ContractorMKComboBox.Location = new System.Drawing.Point(24, 317);
            this.ContractorMKComboBox.Name = "ContractorMKComboBox";
            this.ContractorMKComboBox.Size = new System.Drawing.Size(367, 23);
            this.ContractorMKComboBox.TabIndex = 14;
            this.ContractorMKComboBox.TextUpdate += new System.EventHandler(this.ContractorMKComboBox_TextUpdate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Исполнитель МК";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер акта отлова";
            // 
            // NumberActTextBox
            // 
            this.NumberActTextBox.Location = new System.Drawing.Point(219, 104);
            this.NumberActTextBox.Name = "NumberActTextBox";
            this.NumberActTextBox.PlaceholderText = "00-00-1";
            this.NumberActTextBox.Size = new System.Drawing.Size(172, 23);
            this.NumberActTextBox.TabIndex = 15;
            this.NumberActTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberActTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(138, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Количество отловленных:";
            // 
            // AnimalsTextBox
            // 
            this.AnimalsTextBox.Location = new System.Drawing.Point(307, 401);
            this.AnimalsTextBox.Name = "AnimalsTextBox";
            this.AnimalsTextBox.ReadOnly = true;
            this.AnimalsTextBox.Size = new System.Drawing.Size(84, 23);
            this.AnimalsTextBox.TabIndex = 20;
            this.AnimalsTextBox.Text = "0";
            this.AnimalsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Собаки:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Кошки:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Животные:";
            // 
            // LocalityComboBox
            // 
            this.LocalityComboBox.FormattingEnabled = true;
            this.LocalityComboBox.Location = new System.Drawing.Point(24, 455);
            this.LocalityComboBox.Name = "LocalityComboBox";
            this.LocalityComboBox.Size = new System.Drawing.Size(367, 23);
            this.LocalityComboBox.TabIndex = 25;
            this.LocalityComboBox.TextUpdate += new System.EventHandler(this.LocalityComboBox_TextUpdate);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Населенный пункт";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Дата отлова";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Цель отлова";
            // 
            // DateCapt
            // 
            this.DateCapt.Location = new System.Drawing.Point(219, 156);
            this.DateCapt.Name = "DateCapt";
            this.DateCapt.Size = new System.Drawing.Size(172, 23);
            this.DateCapt.TabIndex = 30;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(327, 551);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 31;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CaptOfPurposeTextBox
            // 
            this.CaptOfPurposeTextBox.Location = new System.Drawing.Point(24, 499);
            this.CaptOfPurposeTextBox.Name = "CaptOfPurposeTextBox";
            this.CaptOfPurposeTextBox.Size = new System.Drawing.Size(367, 23);
            this.CaptOfPurposeTextBox.TabIndex = 32;
            // 
            // DogsCount
            // 
            this.DogsCount.Location = new System.Drawing.Point(24, 402);
            this.DogsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DogsCount.Name = "DogsCount";
            this.DogsCount.Size = new System.Drawing.Size(84, 23);
            this.DogsCount.TabIndex = 33;
            this.DogsCount.ValueChanged += new System.EventHandler(this.DogsCount_ValueChanged);
            this.DogsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DogsCount_KeyPress);
            // 
            // CatsCount
            // 
            this.CatsCount.Location = new System.Drawing.Point(161, 402);
            this.CatsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CatsCount.Name = "CatsCount";
            this.CatsCount.Size = new System.Drawing.Size(84, 23);
            this.CatsCount.TabIndex = 34;
            this.CatsCount.ValueChanged += new System.EventHandler(this.CatsCount_ValueChanged);
            this.CatsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CatsCount_KeyPress);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 586);
            this.Controls.Add(this.CatsCount);
            this.Controls.Add(this.DogsCount);
            this.Controls.Add(this.CaptOfPurposeTextBox);
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
            this.Controls.Add(this.ContractorMKComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberMKTextBox);
            this.Controls.Add(this.OMSUComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MunicipalityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateMK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DogsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MunicipalityComboBox;
        private System.Windows.Forms.ComboBox OMSUComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberMKTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ContractorMKComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumberActTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AnimalsTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox LocalityComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DateCapt;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox CaptOfPurposeTextBox;
        private System.Windows.Forms.NumericUpDown DogsCount;
        private System.Windows.Forms.NumericUpDown CatsCount;
    }
}
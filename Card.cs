using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTiPPO
{
    public partial class card : Form
    {

        public card()
        {
            InitializeComponent();
            
        }

        private void card_Load(object sender, EventArgs e)
        {
            DateTime dateTime = new(2011, 6, 10);
            textBox1.Text = "0001";
            dateTimePicker1.Value = dateTime;
            comboBox1.Text = "А";
            comboBox2.Text = "А";
            comboBox3.Text = "А";
            textBox2.Text = "0001";
            textBox3.Text = "4";
            textBox4.Text = "5";
            textBox5.Text = "9";
            comboBox4.Text = "АA";
            dateTimePicker2.Value = dateTime;
            comboBox5.Text = "А";


            //List main = this.Owner as List;
            //if (main != null)
            //{
            //    object asd = main.dataGridView1.SelectedCells;
            //}
        }


        private void CloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

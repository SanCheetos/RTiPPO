using RTiPPO.Controllers;
using RTiPPO.SubjectArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTiPPO
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            Register register = ListController.GetActs(new User());
            //Вывод полученных записей

            DateTime dateTime = new(2011, 6, 10);
            dataGridView1.Rows.Add("0001", dateTime, "А", "А", "А", "0001", 4, 5, 9, "АА", dateTime, "А");
            dataGridView1.Rows.Add("0011", new DateTime(2012, 6, 10), "АА", "АА", "АБ", "0001", 6, 3, 9, "АА", new DateTime(2012, 6, 10), "АБ");
            dataGridView1.Rows.Add("0002", new DateTime(2011, 6, 12), "Б", "Б", "Б", "0001", 12, 10, 22, "АА", new DateTime(2011, 6, 12), "Б");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            card c = new card();
            c.Owner = this;
            c.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form Add = new AddForm();
            Add.Show();
        }

        private void OpenCard_Click(object sender, EventArgs e)
        {
            AccountCard accountCard = ListController.GetEntity(0);
            card c = new card();
            c.Owner = this;
            c.ShowDialog();
        }

        private void DoFilter_Click(object sender, EventArgs e)
        {
            //Сбор данных фильтра
            Register register = ListController.Filter(new User(), new Dictionary<string, string>());
            //Вывод полученных записей
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            GetExcelPath();
            string[,] data = new string[0,0];
            //Привязать к окну вызов метода ListController.SaveExcel(path, name, data)
        }

        private void GetExcelPath()
        {
            //открыыть выбор пути и имени сохранения
        }
    }
}

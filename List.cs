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

        List<Municipality> municipalitySearch = null;
        List<OMSU> omsuSearch = null;
        List<Contractor> contractorSearch = null;
        List<Locality> localitySearch = null; 

        private void List_Load(object sender, EventArgs e)
        {
            Register register = ListController.GetActs(new User());
            //Вывод полученных записей

            foreach (AccountCard card in register.AccountCards)
                dataGridView1.Rows.Add(
                    card.NumberMK,
                    card.DateOfConclusionMK, 
                    card.Municipality,
                    card.OMSU,
                    card.ContractorMK,
                    card.NumberActCatching,
                    card.CaugthDogs,
                    card.CaugthCats,
                    card.CaugthAnimals,
                    card.Locality,
                    card.DateCatch,
                    card.PurposeOfCatch.Trim());
            ShowHideFilter_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            //Привязать к окну вызов метода ListController.SaveExcel(file, data)
        }

        private void GetExcelPath()
        {
            //открыыть выбор пути и имени сохранения
        }

        private void DeleteCard_Click(object sender, EventArgs e)
        {

        }

        private void AddCard_Click(object sender, EventArgs e)
        {

        }

        //Показать/скрыть фильтр
        private void ShowHideFilter_Click(object sender, EventArgs e)
        {
            if (ShowHideFilter.Text == "Показать")
            {
                FilterLabel.Visible = false;
                filterBox.Visible = true;
                DoFilter.Visible = true;
                ThrowOffFilter.Visible = true;
                dataGridView1.Location = new Point(dataGridView1.Location.X, dataGridView1.Location.Y + 365);
                AddCard.Location = new Point(AddCard.Location.X, AddCard.Location.Y + 365);
                DeleteCard.Location = new Point(DeleteCard.Location.X, DeleteCard.Location.Y + 365);
                OpenCard.Location = new Point(OpenCard.Location.X, OpenCard.Location.Y + 365);
                ExportExcel.Location = new Point(ExportExcel.Location.X, ExportExcel.Location.Y + 365);
                this.Height += 365;
                ShowHideFilter.Text = "Скрыть";
            }
            else
            {
                FilterLabel.Visible = true;
                filterBox.Visible = false;
                DoFilter.Visible = false;
                ThrowOffFilter.Visible = false;
                dataGridView1.Location = new Point(dataGridView1.Location.X, dataGridView1.Location.Y - 365);
                AddCard.Location = new Point(AddCard.Location.X, AddCard.Location.Y - 365);
                DeleteCard.Location = new Point(DeleteCard.Location.X, DeleteCard.Location.Y - 365);
                OpenCard.Location = new Point(OpenCard.Location.X, OpenCard.Location.Y - 365);
                ExportExcel.Location = new Point(ExportExcel.Location.X, ExportExcel.Location.Y - 365);
                this.Height -= 365;
                ShowHideFilter.Text = "Показать";
            }
        }

        private void MunicipalitySearch(object sender, KeyEventArgs e)
        {
            if (municipalitySearch == null)
                municipalitySearch = ListController.GetMunicipality();
            ListSearch(MunicipalityTextBox, MunicipalityListHelp, municipalitySearch);
        }

        private void MunicipalityListHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListHelp_SelectedIndexChanged(MunicipalityList, MunicipalityListHelp);
        }

        private void DeleteMunicipality_Click(object sender, EventArgs e)
        {
            DeleteListItem_Click(MunicipalityList);
        }

        private void OMSUSearch(object sender, KeyEventArgs e)
        {
            if (omsuSearch == null)
                omsuSearch = ListController.GetOMSU();
            ListSearch(OMSUTextBox, OMSUListHelp, omsuSearch);
        }


        private void OMSUListHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListHelp_SelectedIndexChanged(OMSUList, OMSUListHelp);
        }

        private void DeleteOMSU_Click(object sender, EventArgs e)
        {
            DeleteListItem_Click(OMSUList);
        }

        private void ContractorSearch(object sender, KeyEventArgs e)
        {
            if (contractorSearch == null)
                contractorSearch = ListController.GetContractor();
            ListSearch(ContractorTextBox, ContractorListHelp, contractorSearch);
        }

        private void ContractorListHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListHelp_SelectedIndexChanged(ContractorList, ContractorListHelp);
        }

        private void DeleteContractor_Click(object sender, EventArgs e)
        {
            DeleteListItem_Click(ContractorList);
        }

        private void LocalitySearch(object sender, KeyEventArgs e)
        {
            if (localitySearch == null)
                localitySearch = ListController.GetLocality();
            ListSearch(LocalityTextBox, LocalityListHelp, localitySearch);
        }

        private void LocalityListHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListHelp_SelectedIndexChanged(LocalityList, LocalityListHelp);
        }

        private void DeleteLocality_Click(object sender, EventArgs e)
        {
            DeleteListItem_Click(LocalityList);
        }

        //Поиск совпадений в фильтре --Третьяк--
        private void ListSearch<TSearch>(TextBox textBox, ListBox listBox, List<TSearch> search)
        {
            string searchString = textBox.Text;
            if (searchString == "")
                listBox.Visible = false;
            else
            {
                listBox.Items.Clear();
                foreach (TSearch searchElem in search)
                {
                    string subString = searchElem.ToString().Substring(0, searchString.Length);
                    if (searchString == subString)
                    {
                        listBox.Items.Add(searchElem);
                    }
                }
                if (listBox.Items.Count > 0)
                    listBox.Visible = true;
                else
                    listBox.Visible = false;
            }
        }

        private void ListHelp_SelectedIndexChanged(ListBox listBox, ListBox listBoxHelp)
        {
            bool alreadyGot = false;
            object got = listBoxHelp.SelectedItem;
            foreach (object item in listBox.Items)
                if (item == got)
                    alreadyGot = true;
            if (!alreadyGot)
                listBox.Items.Add(listBoxHelp.SelectedItem);
            listBoxHelp.Visible = false;
        }

        private void DeleteListItem_Click(ListBox listBox)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        
    }
}

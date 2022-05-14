using RTiPPO.Controllers;
using RTiPPO.SubjectArea;
using System;
using Excel = Microsoft.Office.Interop.Excel;
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
        Register startRegister = null;
        

        private void List_Load(object sender, EventArgs e)
        {
            startRegister = ListController.GetActs();
            //Вывод полученных записей

            if (startRegister.AccountCards.Count == 0)
                MessageBox.Show("Вы не имеете доступ ни к одной из записей", "Ошибка");
            else
                DataGrid_LoadValue(startRegister);
            ShowHideFilter_Click(null, null);

            if (User.Role.Function.Name.ToString().Trim() == "ведение")
            {
                DeleteCard.Visible = true;
            }
            if (User.Role.Name.ToString().Trim() == "Оператор по отлову")
            {
                AddCard.Visible = true;
            }
        }

        private void DataGrid_LoadValue(Register register)
        {
            dataGridView1.Rows.Clear();
            foreach (AccountCard card in register.AccountCards)
                dataGridView1.Rows.Add(
                    card.ID,
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

        }

        private void OpenCard_Click(object sender, EventArgs e)
        {
            int idMK = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
            //AccountCard changeCard = ListController.GetEntity(new User(), numMK);
            AccountCard changeCard = ListController.GetEntity(idMK);
            card c = new card();
            c.ChangeCard = changeCard;
            c.Owner = this;
            c.ShowDialog();
            Hide();
        }

        private void DoFilter_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> filterData = new Dictionary<string, string>();
            //Сбор данных фильтра
            if (NumberMKTextBox.Text != "")
            {
                filterData.Add("NumberMK", NumberMKTextBox.Text);
            }
            else if (NumberActTextBox.Text != "")
            {
                filterData.Add("NumberAct", NumberActTextBox.Text);
            }
            else
            {
                if (CheckDateMK.Checked)
                    filterData.Add("DateMK", "'" + DateMinMK.Text + "' AND '" + DateMaxMK.Text + "'");
                if (CheckDateCapt.Checked)
                    filterData.Add("DateCapt", "'" + DateMinCapt.Text + "' AND '" + DateMaxCapt.Text + "'");
                if (!(CaptMinDogs.Value == 0 && CaptMaxDogs.Value == 0))
                    filterData.Add("CaptDogs", CaptMinDogs.Value.ToString() + " AND " + CaptMaxDogs.Value.ToString());
                if (!(CaptMinCats.Value == 0 && CaptMaxCats.Value == 0))
                    filterData.Add("CaptCats", CaptMinCats.Value.ToString() + " AND " + CaptMaxCats.Value.ToString());
                if (!(CaptMinSum.Value == 0 && CaptMaxSum.Value == 0))
                    filterData.Add("CaptSum", CaptMinSum.Value.ToString() + " AND " + CaptMaxSum.Value.ToString());
                if (MunicipalityList.Items.Count > 0)
                {
                    filterData.Add("Municipality", "");
                    foreach (Municipality municipaluty in MunicipalityList.Items)
                        filterData["Municipality"] += municipaluty.ID + ",";
                    filterData["Municipality"] = filterData["Municipality"].Substring(0, filterData["Municipality"].Length - 1);
                }
                if (OMSUList.Items.Count > 0)
                {
                    filterData.Add("OMSU", "");
                    foreach (OMSU omsu in OMSUList.Items)
                        filterData["OMSU"] += omsu.ID + ",";
                    filterData["OMSU"] = filterData["OMSU"].Substring(0, filterData["OMSU"].Length - 1);
                }
                if (ContractorList.Items.Count > 0)
                {
                    filterData.Add("Contractor", "");
                    foreach (Contractor contractor in ContractorList.Items)
                        filterData["Contractor"] += contractor.ID + ",";
                    filterData["Contractor"] = filterData["Contractor"].Substring(0, filterData["Contractor"].Length - 1);
                }
                if (LocalityList.Items.Count > 0)
                {
                    filterData.Add("Locality", "");
                    foreach (Locality locality in LocalityList.Items)
                        filterData["Locality"] += locality.ID + ",";
                    filterData["Locality"] = filterData["Locality"].Substring(0, filterData["Locality"].Length - 1);
                }

            }
            
            if (filterData.Count > 0)
            {
                //Register register = ListController.Filter(new User(), filterData);
                Register register = ListController.Filter(filterData);
                //Вывод полученных записей
                DataGrid_LoadValue(register);
            }

            //Если фильтр пустой, возвращаем старые значения
            else
            {
                DataGrid_LoadValue(startRegister);
                MessageBox.Show("По задааному фильтру нет ни одной записи", "Ошибка");
            }
        }

        //Экспорт в Excel
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            File file = GetExcelPath();
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                dt.Columns.Add(column.HeaderText);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dataRow = dt.NewRow();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                    dataRow[column.HeaderText] = row.Cells[column.Name].Value;
                dt.Rows.Add(dataRow);
            }
            string output = SaveExcel(file, dt);
            string[] isFail = output.Split(": ");
            if (isFail.Length > 1)
                MessageBox.Show(isFail[1], "Ошибка");
            else
                MessageBox.Show(output, "Успех!");
        }

        private File GetExcelPath()
        {
            SaveExcelPath.Filter = "Книга Excel (*.xlsx)|*.xlsx";
            SaveExcelPath.ShowDialog();
            string fullName = SaveExcelPath.FileName;
            int index = fullName.LastIndexOf('\\');
            string path = fullName.Substring(0, index + 1);
            string name = fullName.Substring(index + 1);
            name = name.Replace(".xlsx", "");
            return new File(name, path);
        }

        private static string SaveExcel(File file, DataTable dt)
        {
            //Объявляем приложение
            Excel.Application ex = new Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Реестр актов отлова";
            int j = 1;
            foreach (DataColumn column in dt.Columns)
            {
                sheet.Cells[1, j].Value = column.ColumnName;
                j++;
            }
            int i = 2;
            j = 1;
            foreach (DataRow row in dt.Rows)
            {
                foreach (var value in row.ItemArray)
                {
                    sheet.Cells[i, j].Value = value;
                    j++;
                }
                j = 1;
                i++;
            }
            Excel.Range left = sheet.Cells[1, 1];
            Excel.Range right = sheet.Cells[i - 1, dt.Columns.Count];
            Excel.Range range = sheet.get_Range(left, right);
            range.EntireColumn.AutoFit();
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            left = sheet.Cells[1, 7];
            right = sheet.Cells[i - 1, 9];
            range = sheet.get_Range(left, right);
            range.ColumnWidth = 13;
            range.WrapText = true;
            try
            {
                ex.Application.ActiveWorkbook.SaveAs(file.Path + file.Name);
                ex.Application.ActiveWorkbook.Close();
                return "Сохранение прошло успешно";
            }
            catch (Exception exep)
            {
                return "Ошибка: " + exep.Message;
            }

            //ex.Visible = true;
        }

        // Действия по кнопке Добавить / Удалить

        private void DeleteCard_Click(object sender, EventArgs e)
        {
            int idMK = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
            var deleteCard = ListController.GetEntity(idMK);
            DialogResult confirmDelete = MessageBox.Show("Вы точно хотите удалить данную запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmDelete == DialogResult.Yes)
            {
                ListController.DeleteAct(deleteCard);
                MessageBox.Show("Удаление прошло успешно.", "Статус", MessageBoxButtons.OK);
                DataGrid_LoadValue(ListController.GetActs());
            }
        }

        private void AddCard_Click(object sender, EventArgs e)
        {
            Form Add = new AddForm();
            Add.Show();
            Hide();
        }

        // Показать / скрыть фильтр - Третьяк
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

        // Поиск совпадений в фильтре - Третьяк
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
                    if (searchElem.ToString().Length >= searchString.Length)
                    {
                        string subString = searchElem.ToString().Substring(0, searchString.Length);
                        if (searchString == subString)
                        {
                            listBox.Items.Add(searchElem);
                        }
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
            if (!alreadyGot && listBoxHelp.SelectedItem != null)
                listBox.Items.Add(listBoxHelp.SelectedItem);
            listBoxHelp.Visible = false;
        }

        private void DeleteListItem_Click(ListBox listBox)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void ThrowOffFilter_Click(object sender, EventArgs e)
        {
            NumberMKTextBox.Clear();
            NumberActTextBox.Clear();
            CheckDateMK.Checked = false;
            CheckDateCapt.Checked = false;
            CaptMinCats.Value = 0;
            CaptMaxCats.Value = 0;
            CaptMinDogs.Value = 0;
            CaptMaxDogs.Value = 0;
            CaptMinSum.Value = 0;
            CaptMaxSum.Value = 0;
            ContractorTextBox.Clear();
            ContractorListHelp.Items.Clear();
            ContractorListHelp.Visible = false;
            ContractorList.Items.Clear();
            OMSUTextBox.Clear();
            OMSUListHelp.Items.Clear();
            OMSUListHelp.Visible = false;
            OMSUList.Items.Clear();
            MunicipalityTextBox.Clear();
            MunicipalityListHelp.Items.Clear();
            MunicipalityListHelp.Visible = false;
            MunicipalityList.Items.Clear();
            LocalityTextBox.Clear();
            LocalityListHelp.Items.Clear();
            LocalityListHelp.Visible = false;
            LocalityList.Items.Clear();
            //DataGrid_LoadValue(ListController.GetActs(new User(-1, null, null, null, null, null)));
            DataGrid_LoadValue(ListController.GetActs());
        }

        // Закрытие приложения по кнопке Х

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

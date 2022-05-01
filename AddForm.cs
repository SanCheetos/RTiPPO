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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        // Заполнение comboBox данными при загрузке формы

        private void AddForm_Load(object sender, EventArgs e)
        {
            MunicipalityComboBox.DataSource = ListController.GetMunicipality();
            OMSUComboBox.DataSource = ListController.GetOMSU();
            ContractorMKComboBox.DataSource = ListController.GetContractor();
            LocalityComboBox.DataSource = ListController.GetLocality();
            MunicipalityComboBox.DisplayMember = "Name";
            MunicipalityComboBox.ValueMember = "ID";
            OMSUComboBox.DisplayMember = "Name";
            OMSUComboBox.ValueMember = "ID";
            ContractorMKComboBox.DisplayMember = "Name";
            ContractorMKComboBox.ValueMember = "ID";
            LocalityComboBox.DisplayMember = "Name";
            LocalityComboBox.ValueMember = "ID";
        }

        // Закрытие формы добавления записи

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Form List = new List();
            List.Show();
            Hide();
        }

        // Динамическое изменение кол-ва животных

        private void DogsCount_ValueChanged(object sender, EventArgs e)
        {
            AnimalsTextBox.Text = (DogsCount.Value + CatsCount.Value).ToString();
        }

        private void CatsCount_ValueChanged(object sender, EventArgs e)
        {
            AnimalsTextBox.Text = (DogsCount.Value + CatsCount.Value).ToString();
        }

        // Запрет на ввод, кроме цифр и Backspace / '-'

        private void DogsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void CatsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NumberMKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NumberActTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        // Фильтрация выпадающего списка при изменении текста

        private void MunicipalityComboBox_TextUpdate(object sender, EventArgs e)
        {
            FilterMunicipalityComboBox(MunicipalityComboBox, ListController.GetMunicipality());
        }

        private void OMSUComboBox_TextUpdate(object sender, EventArgs e)
        {
            FilterOMSUComboBox(OMSUComboBox, ListController.GetOMSU());
        }

        private void ContractorMKComboBox_TextUpdate(object sender, EventArgs e)
        {
            FilterContractorMKComboBox(ContractorMKComboBox, ListController.GetContractor());
        }

        private void LocalityComboBox_TextUpdate(object sender, EventArgs e)
        {
            FilterLocalityComboBox(LocalityComboBox, ListController.GetLocality());
        }

        // Методы фильтрации для каждого comboBox

        private static void FilterMunicipalityComboBox(ComboBox comboBox, List<Municipality> dataComboBox)
        {
            var filter = comboBox.Text;
            if (!(String.IsNullOrWhiteSpace(filter)))
            {
                var filteredItems = dataComboBox.Where(kv => kv.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase)).ToDictionary(k => k.ID, k => k.Name);

                List<Municipality> filteredDataMunicipality = new List<Municipality>();

                foreach (var item in filteredItems)
                {
                    filteredDataMunicipality.Add(new Municipality(item.Value, item.Key));
                }

                comboBox.DataSource = filteredDataMunicipality;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "ID";
                comboBox.IntegralHeight = true;
                comboBox.DroppedDown = true;
                comboBox.SelectedIndex = -1;
                comboBox.Text = filter;
                comboBox.SelectionStart = filter.Length;
                comboBox.SelectionLength = 0;
            }
            else
            {
                comboBox.DataSource = ListController.GetMunicipality();
                comboBox.Text = filter;
                comboBox.SelectionStart = comboBox.Text.Length;
            }
        }

        private static void FilterOMSUComboBox(ComboBox comboBox, List<OMSU> dataComboBox)
        {
            var filter = comboBox.Text;
            if (!(String.IsNullOrWhiteSpace(filter)))
            {
                var filteredItems = dataComboBox.Where(kv => kv.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase)).ToDictionary(k => k.ID, k => k.Name);

                List<OMSU> filteredDataOMSU = new List<OMSU>();

                foreach (var item in filteredItems)
                {
                    filteredDataOMSU.Add(new OMSU(item.Value, item.Key));
                }

                comboBox.DataSource = filteredDataOMSU;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "ID";
                comboBox.IntegralHeight = true;
                comboBox.DroppedDown = true;
                comboBox.SelectedIndex = -1;
                comboBox.Text = filter;
                comboBox.SelectionStart = filter.Length;
                comboBox.SelectionLength = 0;
            }
            else
            {
                comboBox.DataSource = ListController.GetOMSU();
                comboBox.Text = filter;
                comboBox.SelectionStart = comboBox.Text.Length;
            }
        }

        private static void FilterContractorMKComboBox(ComboBox comboBox, List<Contractor> dataComboBox)
        {
            var filter = comboBox.Text;
            if (!(String.IsNullOrWhiteSpace(filter)))
            {
                var filteredItems = dataComboBox.Where(kv => kv.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase)).ToDictionary(k => k.ID, k => k.Name);

                List<Contractor> filteredDataContractor = new List<Contractor>();

                foreach (var item in filteredItems)
                {
                    filteredDataContractor.Add(new Contractor(item.Value, item.Key));
                }

                comboBox.DataSource = filteredDataContractor;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "ID";
                comboBox.IntegralHeight = true;
                comboBox.DroppedDown = true;
                comboBox.SelectedIndex = -1;
                comboBox.Text = filter;
                comboBox.SelectionStart = filter.Length;
                comboBox.SelectionLength = 0;
            }
            else
            {
                comboBox.DataSource = ListController.GetContractor();
                comboBox.Text = filter;
                comboBox.SelectionStart = comboBox.Text.Length;
            }
        }

        private static void FilterLocalityComboBox(ComboBox comboBox, List<Locality> dataComboBox)
        {
            var filter = comboBox.Text;
            if (!(String.IsNullOrWhiteSpace(filter)))
            {
                var filteredItems = dataComboBox.Where(kv => kv.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase)).ToDictionary(k => k.ID, k => k.Name);

                List<Locality> filteredDataLocality = new List<Locality>();

                foreach (var item in filteredItems)
                {
                    filteredDataLocality.Add(new Locality(item.Value, item.Key));
                }

                comboBox.DataSource = filteredDataLocality;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "ID";
                comboBox.IntegralHeight = true;
                comboBox.DroppedDown = true;
                comboBox.SelectedIndex = -1;
                comboBox.Text = filter;
                comboBox.SelectionStart = filter.Length;
                comboBox.SelectionLength = 0;
            }
            else
            {
                comboBox.DataSource = ListController.GetLocality();
                comboBox.Text = filter;
                comboBox.SelectionStart = comboBox.Text.Length;
            }
        }
        
        // Действие по кнопке создания

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (NumberMKTextBox.Text != string.Empty && NumberActTextBox.Text != string.Empty && CaptOfPurposeTextBox.Text != string.Empty)
            {
                if (DateMK.Value.CompareTo(DateCapt.Value) > 0)
                {
                    if (MunicipalityComboBox.SelectedValue != null && ListController.GetMunicipality().Any(item => item.ID == int.Parse(MunicipalityComboBox.SelectedValue.ToString())) &&
                        OMSUComboBox.SelectedValue != null && ListController.GetOMSU().Any(item => item.ID == int.Parse(OMSUComboBox.SelectedValue.ToString())) &&
                        ContractorMKComboBox.SelectedValue != null && ListController.GetContractor().Any(item => item.ID == int.Parse(ContractorMKComboBox.SelectedValue.ToString())) &&
                        LocalityComboBox.SelectedValue != null && ListController.GetLocality().Any(item => item.ID == int.Parse(LocalityComboBox.SelectedValue.ToString())))
                    {
                        var check = ListController.GetActs();
                        if (int.Parse(AnimalsTextBox.Text) > 0)
                        {
                            var addNewCard = new AccountCard(
                                -1, 
                                NumberMKTextBox.Text,
                                DateMK.Value,
                                new Municipality(MunicipalityComboBox.SelectedText.ToString(), int.Parse(MunicipalityComboBox.SelectedValue.ToString())),
                                new OMSU(OMSUComboBox.SelectedText.ToString(), int.Parse(OMSUComboBox.SelectedValue.ToString()), new Municipality(MunicipalityComboBox.SelectedText.ToString(), int.Parse(MunicipalityComboBox.SelectedValue.ToString()))),
                                new Contractor(ContractorMKComboBox.SelectedText.ToString(), int.Parse(ContractorMKComboBox.SelectedValue.ToString())),
                                NumberActTextBox.Text,
                                int.Parse(DogsCount.Value.ToString()),
                                int.Parse(CatsCount.Value.ToString()),
                                int.Parse(AnimalsTextBox.Text),
                                new Locality(LocalityComboBox.SelectedText.ToString(), int.Parse(LocalityComboBox.SelectedValue.ToString())),
                                null,
                                DateCapt.Value,
                                CaptOfPurposeTextBox.Text
                                );
                            ListController.AddAct(addNewCard);
                            MessageBox.Show("Добавление прошло успешно.", "Статус", MessageBoxButtons.OK);
                            Form List = new List();
                            List.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Количество отловленных животных не может быть 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните поля с выпадающим списком корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Дата отлова не может быть позже Даты заключения МК.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

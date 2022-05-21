using RTiPPO.SubjectArea;
using RTiPPO.Controllers;
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

        internal AccountCard ChangeCard { get; set; }

        private void card_Load(object sender, EventArgs e)
        {
            MunicipalityComboBox.DataSource = ListController.GetMunicipality();
            OMSUComboBox.DataSource = ListController.GetOMSU();
            ContractorMK.DataSource = ListController.GetContractor();
            LocalityComboBox.DataSource = ListController.GetLocality();

            NumberMKTextBox.Text = ChangeCard.NumberMK.ToString();
            NumberActTextBox.Text = ChangeCard.NumberActCatching.ToString();
            DateMK.Value = ChangeCard.DateOfConclusionMK;
            DateCapt.Value = ChangeCard.DateCatch;
            MunicipalityComboBox.Text = ChangeCard.OMSU.Municipality.ToString();
            OMSUComboBox.Text = ChangeCard.OMSU.ToString();
            ContractorMK.Text = ChangeCard.ContractorMK.ToString();
            DogsCount.Value = ChangeCard.CaugthDogs;
            CatsCount.Value = ChangeCard.CaugthCats;
            AnimalsTextBox.Text = ChangeCard.CaugthAnimals.ToString();
            LocalityComboBox.Text = ChangeCard.Locality.ToString();
            CaptOfPurpose.Text = ChangeCard.PurposeOfCatch.ToString();
        }


        private void CloseForm_Click_1(object sender, EventArgs e)
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

        //Экспорт в Word

        private void ExportWord_Click(object sender, EventArgs e)
        {

            CardController.WordExport(ChangeCard, "name");
        }

        //Изменение данных
        private void CreateButton_Click(object sender, EventArgs e)
        {
            var MunicipalityList = ListController.GetMunicipality();
            var OMSUList = ListController.GetOMSU();
            var ContractorMKList= ListController.GetContractor();
            var LocalityList = ListController.GetLocality();

            Municipality SelectedMunicipality = null;
            OMSU SelectedOMSU = null;
            Contractor SelectedContractor = null;
            Locality SelectedLocality = null;

            foreach (var item in MunicipalityList)
            {
                if(item.Name == MunicipalityComboBox.SelectedItem.ToString())
                {
                    SelectedMunicipality = item;
                    break;
                }
            }

            foreach (var item in OMSUList)
            {
                if (item.Name == OMSUComboBox.SelectedItem.ToString())
                {
                    SelectedOMSU = item;
                    break;
                }
            }

            foreach (var item in ContractorMKList)
            {
                if (item.Name == ContractorMK.SelectedItem.ToString())
                {
                    SelectedContractor = item;
                    break;
                }
            }

            foreach (var item in LocalityList)
            {
                if (item.Name == LocalityComboBox.SelectedItem.ToString())
                {
                    SelectedLocality = item;
                    break;
                }
            }


            if (NumberMKTextBox.Text != string.Empty && NumberActTextBox.Text != string.Empty && CaptOfPurpose.Text != string.Empty)
            {
                if (DateMK.Value.CompareTo(DateCapt.Value) > 0)
                {
                    if (MunicipalityComboBox.SelectedValue != null && OMSUComboBox.SelectedValue != null && ContractorMK.SelectedValue != null && LocalityComboBox.SelectedValue != null)
                    {
                        if (int.Parse(AnimalsTextBox.Text) > 0)
                        {
                            ChangeCard.NumberMK = NumberMKTextBox.Text;
                            ChangeCard.NumberActCatching = NumberActTextBox.Text;
                            ChangeCard.DateOfConclusionMK = DateMK.Value;
                            ChangeCard.DateCatch = DateCapt.Value;
                            ChangeCard.OMSU.Municipality = SelectedMunicipality;
                            ChangeCard.OMSU = SelectedOMSU;
                            ChangeCard.ContractorMK = SelectedContractor;
                            ChangeCard.CaugthDogs = Decimal.ToInt32(DogsCount.Value);
                            ChangeCard.CaugthCats = Decimal.ToInt32(CatsCount.Value);
                            ChangeCard.CaugthAnimals = Int32.Parse(AnimalsTextBox.Text);
                            ChangeCard.Locality = SelectedLocality;
                            ChangeCard.PurposeOfCatch = CaptOfPurpose.Text;

                            if (CardController.UpdateAct(ChangeCard))
                            {
                                MessageBox.Show("Изменение прошло успешно.", "Статус", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Произошла ошибка при подключении к БД.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

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

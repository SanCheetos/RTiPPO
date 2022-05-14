using RTiPPO.SubjectArea;
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
            //В начале все поля readonly и только если у пользователя есть функция ведения, поля открываются
            //158 239    81
            if (ChangeCard != null)
            {
                NumberMKTextBox.Text = ChangeCard.NumberMK;
                NumberActTextBox.Text = ChangeCard.NumberActCatching;
                DateMK.Value = ChangeCard.DateOfConclusionMK;
                DateCapt.Value = ChangeCard.DateCatch;
                MunicipalityComboBox.Text = ChangeCard.OMSU.Municipality.ToString();
                OMSUComboBox.Text = ChangeCard.OMSU.ToString();
                ContractorMK.Text = ChangeCard.ContractorMK.ToString();
                DogsTextBox.Text = ChangeCard.CaugthDogs.ToString();
                CatsTextBox.Text = ChangeCard.CaugthCats.ToString();
                AnimalsTextBox.Text = ChangeCard.CaugthAnimals.ToString();
                LocalityComboBox.Text = ChangeCard.Locality.ToString();

                CaptOfPurposeComboBox.Text = ChangeCard.PurposeOfCatch.ToString();
                CanChange();
            }
            //List main = this.Owner as List;
            //if (main != null)
            //{
            //    object asd = main.dataGridView1.SelectedCells;
            //}
        }


        private void CanChange()
        {
            if (User.Role.Function.Name.Trim() == "ведение")
            {
                NumberMKTextBox.ReadOnly = false;
                NumberActTextBox.ReadOnly = false;
                DateMK.Enabled = true;
                DateCapt.Enabled = true;
                MunicipalityComboBox.Enabled = true;
                OMSUComboBox.Enabled = true;
                ContractorMK.Enabled = true;
                DogsTextBox.ReadOnly = false;
                CatsTextBox.ReadOnly = false;
                AnimalsTextBox.ReadOnly = false;
                LocalityComboBox.Enabled = true;
                CaptOfPurposeComboBox.Enabled = true;

                CreateButton.Visible = true;
                ExportWordButton.Location = new Point(ExportWordButton.Location.X + 81, ExportWordButton.Location.Y);
            }
        }

        private void CloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

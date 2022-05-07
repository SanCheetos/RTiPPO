using System;
using RTiPPO.Controllers;
using RTiPPO.SubjectArea;
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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        // Действие по кнопке авторизации

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (LoginText.Text != string.Empty && PasswordText.Text != string.Empty)
            {
                string authResult = AuthController.Login(LoginText.Text, PasswordText.Text);
                if (authResult == "OK")
                {
                    Form Registry = new List();
                    Registry.Show();
                    Hide();
                }
                else if (authResult == "Error")
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Закрытие приложения по кнопке X

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

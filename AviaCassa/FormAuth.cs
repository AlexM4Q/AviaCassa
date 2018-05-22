using System;
using System.Windows.Forms;

namespace AviaCassa {

    public partial class FormAuth : Form {

        private const string Username = "admin";

        private const string Password = "admin";

        private readonly Form _formMain;

        private bool _simpleClose;

        public FormAuth(Form formMain) {
            InitializeComponent();

            _formMain = formMain;
            _formMain.Hide();
            Show();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            if (UsernameInput.Text == Username && PasswordInput.Text == Password) {
                _simpleClose = true;
                Close();
                _formMain.Show();
            } else {
                new FormWarning {
                    Owner = this,
                    Title = "Авторизация",
                    Message = "Неправильно введено имя пользователя и/или пароль! Повторите попытку позже."
                }.Show();
            }
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e) {
            if (!_simpleClose) _formMain.Close();
        }

    }

}
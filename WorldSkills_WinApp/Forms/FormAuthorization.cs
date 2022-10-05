using System;
using System.Windows.Forms;
using WorldSkills_WinApp.Forms;

namespace WorldSkills_WinApp
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (checkBoxKeep.Checked)
            {
                Properties.Settings.Default.login = textBoxLogin.Text;
                Properties.Settings.Default.password = textBoxPassword.Text;
                Properties.Settings.Default.Save();
            }

            DBEntities.User user = DBWorkers.UsersController.Get(login, password);

            if (user == null)
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }

            OpenNewForm(user);
        }

        private void OpenNewForm(DBEntities.User user)
        {
            if (user.Role == 1)
            {
                MessageBox.Show("У Вас недостаточно полномочий, чтобы войти в систему.");
                return;
            }

            if (user.Role == 6)
            {
                Program.OpenForm(new FormOrganizationMenu(user));
                return;
            }

            if (user.Competition == 0)
            {
                MessageBox.Show("Нет ближайших чемпионатов.");
                return;
            }

            Program.OpenForm(new FormExpertMenu(user));
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = Properties.Settings.Default.login;
            textBoxPassword.Text = Properties.Settings.Default.password;
        }
    }
}

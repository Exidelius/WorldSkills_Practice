using System;
using System.Windows.Forms;

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

            if (user.IsNull())
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }

            OpenNewForm(user);
        }

        private void OpenNewForm(DBEntities.User user)
        {
            // TODO возможно доделать выбор формы для разных степеней доступа

            Program.OpenForm(new FormOrganizationMenu(user));
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = Properties.Settings.Default.login;
            textBoxPassword.Text = Properties.Settings.Default.password;
        }
    }
}

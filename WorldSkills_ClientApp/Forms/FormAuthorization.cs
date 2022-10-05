using System;
using System.Windows.Forms;
using WorldSkills_ClientApp.DBEntities;
using WorldSkills_ClientApp.DBWorkers;
using WorldSkills_ClientApp.Forms;

namespace WorldSkills_ClientApp
{
    public partial class FormAuthorization : Form
    {
        private int count = 0;

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonAuthenticate_Click(object sender, EventArgs e)
        {
            string code = textBoxCode.Text;

            User currentUser = DBWorkers.UsersController.Get(code);

            if (currentUser == null)
            {
                if (++count == 3)
                {
                    MessageBox.Show("Превышено максимальное количество попыток для входа");
                    Application.Exit();
                }

                MessageBox.Show("Неправильный код");
                return;
            }

            OpenNewForm(currentUser);
        }

        private void OpenNewForm(DBEntities.User user)
        {
            // TODO возможно доделать выбор формы для разных степеней доступа

            Program.OpenForm(new FormParticipantMenu(user));
        }
    }
}

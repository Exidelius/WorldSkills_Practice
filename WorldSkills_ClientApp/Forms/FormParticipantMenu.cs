using System.Windows.Forms;
using WorldSkills_ClientApp.DBEntities;
using WorldSkills_ClientApp.DBWorkers;

namespace WorldSkills_ClientApp.Forms
{
    public partial class FormParticipantMenu : Form
    {
        User currentUser;

        public FormParticipantMenu()
        {
            InitializeComponent();
        }

        public FormParticipantMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
            FillGreetings();
        }

        private void FillGreetings()
        {
            labelGreetings.Text = $"{CompetitionsController.Get(currentUser.Competition)}\nКомпетенция: {SkillsController.Get(currentUser.Skill)}";
        }

        private void buttonParticipants_Click(object sender, System.EventArgs e)
        {
            OpenNewForm(currentUser);
        }

        private void buttonProtocols_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("В разработке..");
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            OpenNewForm();
        }

        private void OpenNewForm()
        {
            // TODO возможно доделать выбор формы для разных степеней доступа

            Program.OpenForm(new FormAuthorization());
        }

        private void OpenNewForm(User user)
        {
            Program.OpenForm(new FormParticipants(user));
        }
    }
}

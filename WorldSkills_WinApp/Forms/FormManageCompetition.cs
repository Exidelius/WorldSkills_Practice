using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WorldSkills_WinApp.DBEntities;
using WorldSkills_WinApp.UIScripts;
using WorldSkills_WinApp.UserControls;

namespace WorldSkills_WinApp
{
    public partial class FormManageCompetition : Form
    {
        private User currentUser;
        private Competition currentCompetition;


        UserControlManager userControl;

        public FormManageCompetition()
        {
            InitializeComponent();
        }

        public FormManageCompetition(User user, Competition competition)
        {
            InitializeComponent();
            currentUser = user;
            currentCompetition = competition;
        }

        private void FormManageCompetition_Load(object sender, EventArgs e)
        {
            labelGreetings.Text = string.Concat("ТЕХНИЧЕСКАЯ ДИРЕКЦИЯ\n",ChooseGreetings(), currentUser.FIO);
            labelCompetition.Text = currentCompetition.Title;
        }

        private string ChooseGreetings()
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour < 6)
                return "Доброй ночи, ";
            if (currentTime.Hour < 12)
                return "Доброе утро, ";
            if (currentTime.Hour < 18)
                return "Добрый день, ";
            return "Добрый вечер, ";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void OpenNewForm()
        {
            Program.OpenForm(new FormOrganizationMenu(currentUser, currentCompetition));
        }

        private void buttonMainExperts_Click(object sender, EventArgs e)
        {
            ChangeControl(new UserControlManageExperts(currentUser, currentCompetition, DBWorkers.RolesController.RoleToSelect.MainExperts));
        }

        private void ChangeControl(UserControlManager newUserControl)
        {
            if (userControl != null)
                userControl.DisposeControl();

            userControl = newUserControl;

            userControl.EnableControl(tableLayoutPanelDeployment);
        }

        private void buttonParticipants_Click(object sender, EventArgs e)
        {
            ChangeControl(new UserControlViewParticipants(currentUser, currentCompetition));
        }
    }
}

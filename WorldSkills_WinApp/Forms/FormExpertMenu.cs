using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSkills_WinApp.DBEntities;
using WorldSkills_WinApp.DBWorkers;
using WorldSkills_WinApp.UIScripts;
using WorldSkills_WinApp.UserControls;

namespace WorldSkills_WinApp.Forms
{
    public partial class FormExpertMenu : Form
    {
        User currentUser;
        Competition currentCompetition;

        UserControlManager userControl;

        public FormExpertMenu()
        {
            InitializeComponent();
        }

        public FormExpertMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
            currentCompetition = CompetitionsController.Get(user.Competition);

            FillLabels();
        }

        private void FillLabels()
        {
            labelGreetings.Text = string.Concat(ChooseGreetings(), currentUser.FIO);
            labelCompetition.Text = $"{currentCompetition.Title}\nКомпетенция: {SkillsController.GetTitle(currentUser.Skill)}";
        }

        private void buttonParticipants_Click(object sender, EventArgs e)
        {
            //ChangeControl(new UserControlViewParticipants(currentUser, currentCompetition));
            ChangeControl(new UserControlManageExperts(currentUser, currentCompetition, RolesController.RoleToSelect.All));
        }

        private void buttonExperts_Click(object sender, EventArgs e)
        {
            ChangeControl(new UserControlManageExperts(currentUser,currentCompetition, RolesController.RoleToSelect.Experts));
        }

        private void buttonProtocols_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            OpenNewForm();
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

        private void ChangeControl(UserControlManager newUserControl)
        {
            if (userControl != null)
                userControl.DisposeControl();

            userControl = newUserControl;

            userControl.EnableControl(tableLayoutPanelDeployment);
        }

        private void OpenNewForm()
        {
            Program.OpenForm(new FormAuthorization());
        }
    }
}

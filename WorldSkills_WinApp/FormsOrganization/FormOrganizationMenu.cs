using System;
using WorldSkills_WinApp.DBEntities;
using System.Collections.Generic;
using System.Windows.Forms;
using WorldSkills_WinApp.UIScripts;

namespace WorldSkills_WinApp
{
    public partial class FormOrganizationMenu : Form
    {
        private User currentUser;
        private Competition currentCompetition;

        private UserControlManager userControl;

        private Dictionary<string, int> competitions;

        public FormOrganizationMenu()
        {
            InitializeComponent();
        }

        public FormOrganizationMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        public FormOrganizationMenu(User user, Competition competition)
        {
            InitializeComponent();
            currentUser = user;
            currentCompetition = competition;

            //comboBoxCompetitions.SelectedIndex = comboBoxCompetitions.Items.IndexOf(currentCompetition.Title);
            //ChangeControl(new UserControlFullCompetitionInformation(currentUser, currentCompetition));
            ////Console.WriteLine("");
        }

        private void FormOrganizationMenu_Load(object sender, EventArgs e)
        {
            labelGreetings.Text = string.Concat(ChooseGreetings(), currentUser.FIO);

            competitions = GetCompetitionsNames();

            UpdateCompetitions();
            //Console.WriteLine("тутбыл");
            if (currentCompetition != null)
            {
                comboBoxCompetitions.SelectedIndex = comboBoxCompetitions.Items.IndexOf(currentCompetition.Title);
                ChangeControl(new UserControlFullCompetitionInformation(currentUser,currentCompetition));
            }
        }

        private Dictionary<string, int> GetCompetitionsNames()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (Tuple<int, string> entitie in DBWorkers.CompetitionsController.GetIDName())
            {
                result.Add(entitie.Item2, entitie.Item1);
            }

            return result;
        }

        private void UpdateCompetitions()
        {
            foreach (string item in competitions.Keys)
            {
                comboBoxCompetitions.Items.Add(item);
            }
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

        private void comboBoxCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCompetition = DBWorkers.CompetitionsController.Get(competitions[(string)comboBoxCompetitions.SelectedItem]);

            if (userControl != null)
                ((IUserControl)userControl).Update(currentUser, currentCompetition);
        }

        private void buttonCompetition_Click(object sender, EventArgs e)
        {
            if (comboBoxCompetitions.SelectedIndex == -1)
                return;
            ChangeControl(new UserControlCompetitionInformation(currentUser,currentCompetition));
        }

        private void ChangeControl(UserControlManager newUserControl)
        {
            if (userControl != null)
                userControl.DisposeControl();

            userControl = newUserControl;

            userControl.EnableControl(tableLayoutPanelDeployment);
        }

        private void buttonEditCompetition_Click(object sender, EventArgs e)
        {
            if (comboBoxCompetitions.SelectedIndex == -1)
            {
                ChangeControl(new UserControlFullCompetitionInformation());
                return;
            }

            ChangeControl(new UserControlFullCompetitionInformation(currentUser,currentCompetition));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void OpenNewForm()
        {
            // TODO возможно доделать выбор формы для разных степеней доступа

            Program.OpenForm(new FormAuthorization());
        }

        private void buttonExpersManagement_Click(object sender, EventArgs e)
        {
            if (comboBoxCompetitions.SelectedIndex == -1)
                return;
            ChangeControl(new UserControlManageExperts(currentUser,currentCompetition,DBWorkers.RolesController.RoleToSelect.Experts));
        }
    }
}

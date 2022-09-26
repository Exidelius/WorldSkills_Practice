using System;
using WorldSkills_WinApp.DBEntities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorldSkills_WinApp
{
    public partial class FormOrganizationMenu : Form
    {
        private User currentUser;
        private Competition currentCompetition;

        UserControlManager userControl;

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

        private void FormOrganizationMenu_Load(object sender, EventArgs e)
        {
            labelGreetings.Text = String.Concat(ChooseGreetings(), currentUser.GetFIO());

            competitions = GetCompetitionsNames();

            UpdateCompetitions();
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

            // TODO Попытаться сделать апдейт. Абстрактный класс работает, но компоненты не хотят открывать с ним дизайнер.


            if (userControl != null)
                ((IUserControl)userControl).Update(currentCompetition);
        }

        private void buttonCompetition_Click(object sender, EventArgs e)
        {
            if (comboBoxCompetitions.SelectedIndex == -1)
                return;

            ChangeControl(new UserControlCompetitionInformation(currentCompetition));
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

            ChangeControl(new UserControlFullCompetitionInformation(currentCompetition));
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
    }
}

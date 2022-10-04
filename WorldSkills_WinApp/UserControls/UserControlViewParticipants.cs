using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorldSkills_WinApp.DBEntities;
using WorldSkills_WinApp.UIScripts;
using WorldSkills_WinApp.DBWorkers;

namespace WorldSkills_WinApp.UserControls
{
    public partial class UserControlViewParticipants : UserControlManager
    {
        private User currentUser;
        private Competition currentCompetition;

        public UserControlViewParticipants()
        {
            InitializeComponent();
        }

        public UserControlViewParticipants(User user, Competition competition)
        {
            InitializeComponent();
            ChooseCompetition(user, competition);
            LoadFilters();
            RetrieveData();
        }

        private void LoadFilters()
        {
            comboBoxRole.Items.Add("Все");
            comboBoxRole.Items.AddRange(RolesController.GetTitles());

            comboBoxSkill.Items.Add("Все");
            comboBoxSkill.Items.AddRange(SkillsController.GetTitles());

            comboBoxRole.SelectedIndex = 0;
            comboBoxSkill.SelectedIndex = 0;
        }

        private void ChooseCompetition(User user, Competition competition)
        {
            currentUser = user;
            currentCompetition = competition;
        }

        private void RetrieveData()
        {
            dataGridViewParticipants.Rows.Clear();
            dataGridViewParticipants.Update();

            int id_role = RolesController.GetId((string)comboBoxRole.SelectedItem);
            int id_skill = SkillsController.GetId((string)comboBoxSkill.SelectedItem);

            List<User> users = new List<User>();
            users.AddRange(UsersController.Get(currentCompetition, id_role, id_skill));
            for (int i = 0; i < users.Count; i++)
            {
                AddRow(GetDataGridUserParams(users[i]));
            }
        }

        private Tuple<string, string, string, string, string> GetDataGridUserParams(User user)
        {
            string userID = user.Id.ToString();
            string userFIO = user.FIO.ToString();
            string userSkill = SkillsController.GetTitle(user.Skill);
            string userRole = RolesController.GetTitle(user.Role);
            string userIsAccepted = "Статус согласования отсутствует в базе данных"; ;

            return new Tuple<string, string, string, string, string>(userID, userFIO, userSkill, userRole, userIsAccepted);
        }

        private void AddRow(Tuple<string, string, string, string, string> userParams)
        {
            dataGridViewParticipants.Rows.Add(userParams.Item1, userParams.Item2, userParams.Item3, userParams.Item4, userParams.Item5, "Согласовать");
        }

        private void comboBoxSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveData();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveData();
        }
    }
}

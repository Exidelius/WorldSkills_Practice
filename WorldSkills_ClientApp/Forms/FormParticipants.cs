using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorldSkills_ClientApp.DBEntities;
using WorldSkills_ClientApp.DBWorkers;

namespace WorldSkills_ClientApp.Forms
{
    public partial class FormParticipants : Form
    {
        User currentUser;

        public FormParticipants()
        {
            InitializeComponent();
        }

        public FormParticipants(User user)
        {
            InitializeComponent();
            currentUser = user;
            FillGreetings();
            RetrieveData();
        }

        private void FillGreetings()
        {
            labelGreetings.Text = $"{CompetitionsController.Get(currentUser.Competition)}\nКомпетенция: {SkillsController.Get(currentUser.Skill)}";
        }

        private void RetrieveData()
        {
            dataGridViewParticipants.Rows.Clear();
            dataGridViewParticipants.Update();

            List<User> users = UsersController.Get(currentUser);

            for (int i = 0; i < users.Count; i++)
            {
                string fio = users[i].FIO;
                string skill = SkillsController.Get(users[i].Skill);
                string role = RolesController.Get(users[i].Role);

                dataGridViewParticipants.Rows.Add(fio, skill, role);
                dataGridViewParticipants.Update();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }
        
        // TODO ВЫНЕСТИ НОВУЮ ФОРМУ В НАСЛЕДОВАНИЕ
        private void OpenNewForm()
        {
            // TODO возможно доделать выбор формы для разных степеней доступа

            Program.OpenForm(new FormParticipantMenu(currentUser));
        }
    }
}

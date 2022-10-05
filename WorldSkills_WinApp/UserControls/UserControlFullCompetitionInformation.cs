using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WorldSkills_WinApp.DBEntities;
using WorldSkills_WinApp.UIScripts;

namespace WorldSkills_WinApp
{
    public partial class UserControlFullCompetitionInformation : UserControlManager, IUserControl
    {
        private Competition currentCompetition;
        private User currentUser;

        private List<ComboBox> skillsComboBox;

        public UserControlFullCompetitionInformation()
        {
            InitializeComponent();
        }

        public UserControlFullCompetitionInformation(User user, Competition сompetition)
        {
            InitializeComponent();
            Update(user, сompetition);
        }

        public void Update(User user, Competition competition)
        {
            currentUser = user;
            currentCompetition = competition;

            if (currentCompetition == null)
                return;

            dateTimePickerStart.Value = currentCompetition.DateOfStart;
            dateTimePickerEnd.Value = currentCompetition.DateOfEnd;
            textBoxTitle.Text = currentCompetition.Title;
            numericUpDownExpertsCount.Value = DBWorkers.UsersController.GetExpertsCount(currentCompetition.Id);
            numericUpDownParticipantsCount.Value = DBWorkers.UsersController.GetParticipantsCount(currentCompetition.Id);

            FillExperts();

            ClearSkills();
            FillSkills();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void ClearSkills()
        {
            if (skillsComboBox != null)
            {
                while (skillsComboBox.Count > 1)
                {
                    skillsComboBox[skillsComboBox.Count - 1].Dispose();
                    skillsComboBox.Remove(skillsComboBox.Last());
                }

                buttonAddSkill.Location = new Point(buttonAddSkill.Location.X, comboBoxSkills.Location.Y + comboBoxSkills.Height + 2);

                comboBoxSkills.SelectedIndex = -1;
                comboBoxSkills.Items.Clear();
            }
        }

        private void FillSkills()
        {
            string[] competitionSkills = DBWorkers.CompetitionSkillController.Get(currentCompetition.Id);
            string[] skills = DBWorkers.SkillsController.GetTitles();

            if (competitionSkills == null)
                return;
            
            comboBoxSkills.Items.AddRange(skills);
            comboBoxSkills.SelectedItem = competitionSkills[0];

            skillsComboBox = new List<ComboBox>(1);
            skillsComboBox.Add(comboBoxSkills);

            for (int i = 1; i < competitionSkills.Length; i++)
            {
                skillsComboBox.Add(CreateNewComboBoxSkills(skillsComboBox.Last(), skills, competitionSkills[i]));
                Console.WriteLine(competitionSkills[i]);
            }

            buttonAddSkill.Location = new Point(buttonAddSkill.Location.X, skillsComboBox.Last().Location.Y + skillsComboBox.Last().Height + 2);
        }

        private void FillExperts()
        {
            comboBoxExperts.Items.AddRange(DBWorkers.UsersController.GetExpertsNames(currentCompetition.Id));

            if (comboBoxExperts.Items.Count > 0)
            {
                comboBoxExperts.SelectedIndex = comboBoxExperts.Items.IndexOf(DBWorkers.UsersController.GetMainExpertName(currentCompetition.Id));
            }
        }

        private ComboBox CreateNewComboBoxSkills(ComboBox previous, string[] skillTitles, string currentTitle = "")
        {
            ComboBox result = new ComboBox();
            result.Show();
            result.Parent = previous.Parent;
            result.Location = new Point(previous.Location.X, previous.Location.Y + previous.Height + 5);

            //string[] items = previous.Items.Cast<Object>().Select(item => item.ToString()).ToArray();

            result.Items.AddRange(skillTitles);
            //result.Items.AddRange(items);

            if (currentTitle != "")
                result.SelectedIndex = result.Items.IndexOf(currentTitle);

            return result;
        }

        private void buttonAddSkill_Click(object sender, EventArgs e)
        {
            if (skillsComboBox == null)
            {
                skillsComboBox = new List<ComboBox>();
                skillsComboBox.Add(comboBoxSkills);
            }

            if (skillsComboBox[skillsComboBox.Count - 1].SelectedIndex != -1)
            {
                skillsComboBox.Add(CreateNewComboBoxSkills(skillsComboBox.Last(), DBWorkers.SkillsController.GetTitles()));
            }

            buttonAddSkill.Location = new Point(buttonAddSkill.Location.X, skillsComboBox.Last().Location.Y + skillsComboBox.Last().Height + 2);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (currentCompetition != null)
                OpenNewForm();
        }

        private void OpenNewForm()
        {
            // TODO возможно доделать выбор формы для разных степеней доступа

            Program.OpenForm(new FormManageCompetition(currentUser, currentCompetition));
        }
    }
}

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

            currentCompetition = competition;
            currentUser = user;

            comboBoxSkills.Items.AddRange(DBWorkers.SkillsController.GetTitles());

            if (currentCompetition == null)
                return;

            dateTimePickerStart.Value = currentCompetition.DateOfStart;
            dateTimePickerEnd.Value = currentCompetition.DateOfEnd;
            textBoxTitle.Text = currentCompetition.Title;

            string[] currentCompetitionSkills = DBWorkers.CompetitionSkillController.Get(currentCompetition.Id);

            if (currentCompetitionSkills != null)
            {
                comboBoxSkills.SelectedIndex = comboBoxSkills.Items.IndexOf(currentCompetitionSkills[0]);

                skillsComboBox = new List<ComboBox>(1);
                skillsComboBox.Add(comboBoxSkills);

                for (int i = 1; i < currentCompetitionSkills.Length; i++)
                {
                    skillsComboBox.Add(CreateNewComboBoxSkills(skillsComboBox.Last(), currentCompetitionSkills[i]));
                }

                buttonAddSkill.Location = new Point(buttonAddSkill.Location.X, skillsComboBox.Last().Location.Y + skillsComboBox.Last().Height + 2);
            }

            comboBoxExperts.Items.AddRange(DBWorkers.UsersController.GetExpertsNames(currentCompetition.Id));
            if (comboBoxExperts.Items.Count > 0)
            {
                comboBoxExperts.SelectedIndex = comboBoxExperts.Items.IndexOf(DBWorkers.UsersController.GetMainExpertName(currentCompetition.Id));
            }

            numericUpDownExpertsCount.Value = DBWorkers.UsersController.GetExpertsCount(currentCompetition.Id);
            numericUpDownParticipantsCount.Value = DBWorkers.UsersController.GetParticipantsCount(currentCompetition.Id);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private ComboBox CreateNewComboBoxSkills(ComboBox previous, string skillTitle = "")
        {
            ComboBox result = new ComboBox();
            result.Show();
            result.Parent = previous.Parent;
            result.Location = new Point(previous.Location.X, previous.Location.Y + previous.Height + 5);

            string[] items = previous.Items.Cast<Object>().Select(item => item.ToString()).ToArray();

            result.Items.AddRange(items);

            if (skillTitle != "")
                result.SelectedIndex = result.Items.IndexOf(skillTitle);

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
                skillsComboBox.Add(CreateNewComboBoxSkills(skillsComboBox.Last()));
            }

            buttonAddSkill.Location = new Point(buttonAddSkill.Location.X, skillsComboBox.Last().Location.Y + skillsComboBox.Last().Height + 2);
        }

        private void UserControlFullCompetitionInformation_Load(object sender, EventArgs e)
        {

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

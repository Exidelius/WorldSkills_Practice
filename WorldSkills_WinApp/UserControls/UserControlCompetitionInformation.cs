using System.Windows.Forms;
using WorldSkills_WinApp.DBEntities;
using WorldSkills_WinApp.UIScripts;

namespace WorldSkills_WinApp
{
    public partial class UserControlCompetitionInformation : UserControlManager, IUserControl
    {
        Competition currentCompetition;
        User currentUser;

        public UserControlCompetitionInformation()
        {
            InitializeComponent();
        }

        public UserControlCompetitionInformation(User user, Competition competition)
        {
            InitializeComponent();
            Update(user, competition);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Update(User user, Competition competition)
        {
            currentCompetition = competition;
            currentUser = user;

            labelTitle.Text = currentCompetition.Title;
            labelCity.Text = currentCompetition.City;
            richTextBoxDescription.Text = currentCompetition.Description;
            //webBrowserDescription.Text = currentCompetition.Description;
            textBoxDateStart.Text = currentCompetition.DateOfStart.ToString("dd.MM.yyyy");
            textBoxDateEnd.Text = currentCompetition.DateOfEnd.ToString("dd.MM.yyyy");
        }
    }
}

using System.Windows.Forms;
using WorldSkills_WinApp.DBEntities;

namespace WorldSkills_WinApp
{
    public partial class UserControlCompetitionInformation : UserControlManager, IUserControl
    {
        Competition currentCompetition;

        public UserControlCompetitionInformation()
        {
            InitializeComponent();
        }

        public UserControlCompetitionInformation(Competition competition)
        {
            InitializeComponent();
            Update(competition);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Update(Competition competition)
        {
            currentCompetition = competition;

            labelTitle.Text = currentCompetition.Title;
            labelCity.Text = currentCompetition.City;
            richTextBoxDescription.Text = currentCompetition.Description;
            //webBrowserDescription.Text = currentCompetition.Description;
            textBoxDateStart.Text = currentCompetition.DateOfStart.ToString("dd.MM.yyyy");
            textBoxDateEnd.Text = currentCompetition.DateOfEnd.ToString("dd.MM.yyyy");
        }
    }
}

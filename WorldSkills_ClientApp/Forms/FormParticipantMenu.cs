using System.Windows.Forms;
using WorldSkills_ClientApp.DBEntities;

namespace WorldSkills_ClientApp.Forms
{
    public partial class FormParticipantMenu : Form
    {
        User currentUser;

        public FormParticipantMenu()
        {
            InitializeComponent();
        }

        public FormParticipantMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
    }
}

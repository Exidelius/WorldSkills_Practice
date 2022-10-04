using WorldSkills_WinApp.UIScripts;

namespace WorldSkills_WinApp
{
    public partial class UserControlViewExpert : UserControlManager
    {
        public UserControlViewExpert()
        {
            InitializeComponent();
        }

        public UserControlViewExpert(DBEntities.User expert)
        {
            InitializeComponent();
            textBoxFIO.Text = expert.FIO;
            textBoxSkill.Text = DBWorkers.SkillsController.GetTitle(expert.Skill);
            textBoxRole.Text = DBWorkers.RolesController.GetTitle(expert.Role);
            //textBoxPhone.Text = expert.phone
            //TODO В базе отсутствуют телефон и почта. Надо будет их добавить, как и в энтити.
        }
    }
}

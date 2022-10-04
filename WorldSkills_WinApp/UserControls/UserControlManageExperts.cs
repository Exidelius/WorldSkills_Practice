using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WorldSkills_WinApp.DBEntities;
using WorldSkills_WinApp.UIScripts;

namespace WorldSkills_WinApp
{
    public partial class UserControlManageExperts : UserControlManager, IUserControl
    {
        User currentUser;

        List<User> experts;
        List<UserControlViewExpert> expertsView;

        private DBWorkers.RolesController.RoleToSelect currentRoles;

        public UserControlManageExperts()
        {
            InitializeComponent();
        }

        public UserControlManageExperts(User user, Competition competition, DBWorkers.RolesController.RoleToSelect role)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            currentRoles = role;
            Update(user, competition);
        }


        public void ClearOld()
        {
            if (experts != null)
            {
                experts = new List<User>();
                while (expertsView.Count > 0)
                {
                    expertsView.Last().DisposeControl();
                    expertsView.Remove(expertsView.Last());
                }
            }

            experts = new List<User>();
            expertsView = new List<UserControlViewExpert>();
        }

        public void FillData(User user)
        {
            currentUser = user;

            for (int i = 0; i < experts.Count; i++)
            {
                expertsView.Add(CreateExpertView(experts[i], i));
            }
        }

        public void Update(User user, Competition competition)
        {
            ClearOld();

            experts.AddRange(DBWorkers.UsersController.Get(competition, currentRoles));

            FillData(user);
        }

        private UserControlViewExpert CreateExpertView(User expert, int order)
        {
            UserControlViewExpert result = new UserControlViewExpert(expert);

            result.Show();
            result.Parent = tableLayoutPanelExperts;
            tableLayoutPanelExperts.RowCount += 1;
            //tableLayoutPanelExperts.GetRow(tableLayoutPanelExperts.)
            result.Location = new Point(0, order * (result.Height + 5));
            result.Anchor = (AnchorStyles.Left | AnchorStyles.Right);

            return result;
        }

        private void UserControlManageExperts_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelExperts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

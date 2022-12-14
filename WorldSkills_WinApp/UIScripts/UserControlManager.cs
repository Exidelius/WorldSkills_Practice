using System.Windows.Forms;

namespace WorldSkills_WinApp.UIScripts
{
    public class UserControlManager: UserControl
    {

        public void DisposeControl()
        {
            this.Dispose();
        }

        public void EnableControl(Panel parent)
        {
            Parent = parent;
            Show();
            Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        }
    }
}

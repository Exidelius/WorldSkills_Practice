using System;
using WorldSkills_WinApp.DBEntities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorldSkills_WinApp
{
    public partial class FormOrganizationMenu : Form
    {
        private User currentUser;

        private int selectedRowIndex;

        public FormOrganizationMenu()
        {
            InitializeComponent();
        }

        public FormOrganizationMenu(User user)
        {
            InitializeComponent();
            currentUser = user;  
        }

        private void FormOrganizationMenu_Load(object sender, EventArgs e)
        {
            labelGreetings.Text = String.Concat(ChooseGreetings(), currentUser.GetFIO());
            UpdateCompetitions();

            selectedRowIndex = dataGridViewCompetitions.RowCount + 1;
        }

        private void UpdateCompetitions()
        {
            List<Competition> competitions = DBControllers.DBWorker.GetCompetitions();
            if (competitions != null)
            {
                dataGridViewCompetitions.Rows.Clear();
                for (int i = 0; i < competitions.Count; i++)
                {
                    dataGridViewCompetitions.Rows.Add(competitions[i].GetAsStringArray());
                }
                dataGridViewCompetitions.Update();
            }
        }

        private string ChooseGreetings()
        {
            // TODO доделать время суток
            return "Привет, ";
        }

        private void dataGridViewCompetitions_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewCompetitions.Rows.Count == 0)
                return;

            if (selectedRowIndex < dataGridViewCompetitions.RowCount &&
                dataGridViewCompetitions.SelectedCells[0].RowIndex != selectedRowIndex)
                dataGridViewCompetitions.Rows[selectedRowIndex].Selected = false;

            selectedRowIndex = dataGridViewCompetitions.SelectedCells[0].RowIndex; 

            dataGridViewCompetitions.Rows[selectedRowIndex].Selected = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunaHouseGombazo
{
    public partial class BrowseForm : Form
    {
        DHSEntities db;
        public BrowseForm()
        {
            InitializeComponent();
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            db = new DHSEntities();
            houseBindingSource.DataSource = db.House;


        }

        private void BrowseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var dashboardForm = Application.OpenForms.OfType<DashboardForm>().FirstOrDefault();
            if (dashboardForm == null) Application.Exit();
            else dashboardForm.Show();
        }

        private void resultListViewSelectionChanged(object sender, EventArgs e)
        {
            resultListView.MultiSelect = false;
            if (resultListView.SelectedIndices.Count != 0)
            {
                // if the selection is not -1 then enable the buttons corresponding to the access rights of the user                
            }
            else
            {
                viewButton.Enabled = editButton.Enabled = deleteButton.Enabled = importButton.Enabled = exportButton.Enabled = false;
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            // view forms should be closed on closing so create a new instance every time
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // view forms should be closed on closing so create a new instance every time
        }

        private void importButton_Click(object sender, EventArgs e)
        {

        }

        private void exportButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}

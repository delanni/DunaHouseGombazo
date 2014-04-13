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
    public partial class DashboardForm : Form
    {
        public static User User { get; set; }
        Timer searchTimer = new Timer();

        public DashboardForm(User userIdentity)
        {
            InitializeComponent();
            User = userIdentity;

            
            searchTimer.Tick += searchTimer_Tick;
            searchTimer.Interval = 300;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            nameLabelX.Text = User.FullName;
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible) Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm == null) Application.Exit();
            else
            {
                loginForm.Show();
                this.Hide();
                this.Close();
            }
        }

        private void infoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new AboutDialogForm()).ShowDialog();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var browseForm = Application.OpenForms.OfType<BrowseForm>().FirstOrDefault();
            if (browseForm == null)
            {
                browseForm = new BrowseForm();
                browseForm.Show();
            }
            else
            {
                browseForm.Show();
            }
            this.Hide();

        }

        private void nameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openUser(DashboardForm.User.Id);
        }

        private void browseUsersButton_Click(object sender, EventArgs e)
        {
            if (!userSearchTextBox.Visible)
            {
                userSearchTextBox.Visible = true;
                usersListBox.Visible = true;
                userSearchLabel.Visible = true;
                listUsers();
            }
            else
            {
                userSearchTextBox.Visible = false;
                usersListBox.Visible = false;
                userSearchLabel.Visible = false;
                if (usersListBox.SelectedItem != null)
                {
                    searchUsersButton.Text = "Search users";
                    openUser((int)usersListBox.SelectedValue);
                }
            }
        }

        private void openUser(int id)
        {
            var result = (new UserViewForm(id)).ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK && DashboardForm.User.Id == id)
            {
                using (var db = new DHSEntities())
                {
                    DashboardForm.User = db.User.Single(x => x.Id == id);
                    nameLabelX.Text = User.FullName;
                }
            }
        }

        private void userSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
            searchTimer.Enabled = true;
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Enabled = false;

            listUsers();
        }

        private void listUsers()
        {
            var searchText = userSearchTextBox.Text;
            using (var db = new DHSEntities())
            {
                usersListBox.DataSource = db.User.Where(
                    x => x.FullName.Contains(searchText) ||
                        x.UserName.Contains(searchText)).Select(x => new { x.FullName, x.Id })
                        .ToList();
                usersListBox.DisplayMember = "FullName";
                usersListBox.ValueMember = "Id";
            }
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                searchUsersButton.Text = "View user";
            }
            else
            {
                searchUsersButton.Text = "Search users";
            }
        }

        private void usersListBox_DoubleClick(object sender, EventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                searchUsersButton.Text = "Search users";
                userSearchTextBox.Visible = false;
                usersListBox.Visible = false;
                userSearchLabel.Visible = false;
                openUser((int)usersListBox.SelectedValue);
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            openUser(-1);
        }

    }
}

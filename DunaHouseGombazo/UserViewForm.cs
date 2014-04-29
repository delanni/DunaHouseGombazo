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
    public partial class UserViewForm : Form
    {
        private DHSEntities dataset;
        private string originalPwHash;
        private User user;

        public UserViewForm(int userId)
        {
            InitializeComponent();

            // gotta reopen another session in case of save
            dataset = new DHSEntities();
            user = dataset.User.SingleOrDefault(x => x.Id == userId);
            if (user == null)
            {
                user = new User();
                dataset.User.Add(user);
            }

            if (DashboardForm.User.IsAdmin || user.Id == DashboardForm.User.Id)
            {
                if (!DashboardForm.User.IsAdmin)
                {
                    isAdminCheckBox.Enabled = false;
                    canEditCheckBox.Enabled = false;
                    canImportCheckBox.Enabled = false;
                    canExportCheckBox.Enabled = false;
                    canViewCheckBox.Enabled = false;
                    deleteButton.Enabled = false;
                }
                userNameTextBox.Enabled = string.IsNullOrEmpty(user.UserName);
                idTextBox.Enabled = false;
            }
            else
            {
                foreach (var control in this.Controls)
                {
                    if (!(control is Label)) ((Control)control).Enabled = false;
                }
            }
            passwordTextBox.UseSystemPasswordChar = true;

            userBindingSource.DataSource = user;
            originalPwHash = user.Password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateForm() == false) return;

            DialogResult = DialogResult.OK;

            if (user.Password != originalPwHash)
            {
                // if changed, we should rehash, and save that
                user.Password = User.HashAPassword(user.Password);
            } 
            dataset.SaveChanges();
            dataset.Dispose();

            this.Close();
        }

        private bool validateForm()
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordTextBox.BackColor = Color.LightSalmon;
                return false;
            }
            else
            {
                passwordTextBox.BackColor = DefaultBackColor;
            }

            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                userNameTextBox.BackColor = Color.LightSalmon;
                return false;
            }
            else
            {
                userNameTextBox.BackColor = DefaultBackColor;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailTextBox.BackColor = Color.LightSalmon;
                return false;
            }
            else
            {
                emailTextBox.BackColor = DefaultBackColor;
            }

            return true;
        }

        private void UserViewForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this user account?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                var u = dataset.User.SingleOrDefault(x => x.Id == user.Id);
                if (u != null)
                {
                    dataset.User.Remove(u);
                    dataset.SaveChanges();
                }
                dataset.Dispose();
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}

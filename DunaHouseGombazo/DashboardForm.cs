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
        internal UserIdentity User { get; set; }


        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(UserIdentity userIdentity)
        {
            InitializeComponent();
            this.User = userIdentity;

            this.nameLabel.Text = User.FullName;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm == null) Application.Exit();
            else
            {
                this.Hide();
                loginForm.Show();
            }
        }

        private void infoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new AboutDialogForm()).ShowDialog();
        }

    }
}

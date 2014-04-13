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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            using (var db = new DHSEntities())
            {
                if (!db.User.Any(x => x.UserName == "hailey"))
                {
                    db.User.Add(User.Create("hailey", "Hailey Kőbányai", "hailey", "hailey@dh.hu", "+707033373373"));
                    db.SaveChanges();
                    db.User.First().IsAdmin = true;
                    db.SaveChanges();
                }
            }

        }

        private void EscapeHandler(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                exitButton.Focus();
            }
            else if (e.KeyChar == 13)
            {
                signInButton_Click(sender, e);
            }
        }

        private void exitButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            nameTextBox.BackColor = DefaultBackColor;
            passwordTextBox.BackColor = DefaultBackColor;

            var userName = nameTextBox.Text;
            var password = passwordTextBox.Text;

            using (var db = new DHSEntities())
            {
                var matchedUser = (from u in db.User where u.UserName.ToUpper() == userName.ToUpper() select u).FirstOrDefault();

                if (matchedUser == null) // no such user
                {
                    // handle error and return
                    this.Size = this.MaximumSize;
                    errorLabel.Text = "There was an error with the username.";
                    nameTextBox.BackColor = Color.LightSalmon;

                    return;
                }
                else
                {
                    if (matchedUser.Password == User.HashAPassword(password))
                    {
                        //match and allow
                        errorLabel.Text = "";
                        this.Size = this.MinimumSize;

                        var dashBoard = new DashboardForm(matchedUser);
                        dashBoard.Show();
                        this.Hide();
                    }
                    else
                    {
                        // incorrect password, handle and return
                        this.Size = this.MaximumSize;
                        errorLabel.Text = "Incorrect password.";
                        passwordTextBox.BackColor = Color.LightSalmon;

                        return;
                    }
                }
            }
        }
    }
}

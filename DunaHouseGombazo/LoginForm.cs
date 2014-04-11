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
                if(!db.User.Any(x=>x.UserName=="hailey")){
                    db.User.Add((User)UserIdentity.Create("hailey","Hailey Kőbányai","hailey"));
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
            //UserIdentity userIdentity = new UserIdentity()
            //{
            //    UserName = "hailey",
            //    FullName = "Kőbányai Hailey",
                
            //}; // instead this we'll need to authorize and authenticate
            var userName = nameTextBox.Text;
            var password = passwordTextBox.Text;

            using (var db = new DHSEntities())
            {
                var matchedUser = (from u in db.User where u.UserName.ToUpper() == userName.ToUpper() select u).FirstOrDefault();

                if (matchedUser == null) // no such user
                {
                    // handle error and return
                    return;
                }
                else
                {
                    var sha1 = System.Security.Cryptography.SHA1.Create();
                    var pwBytes = Encoding.UTF8.GetBytes(password);
                    var hash = sha1.ComputeHash(pwBytes);

                    if (matchedUser.Password == Convert.ToBase64String(hash))
                    {
                        //match and allow
                        var dashBoard = new DashboardForm(UserIdentity.From(matchedUser));
                        dashBoard.Show();
                        this.Hide();
                    }
                    else
                    {
                        // incorrect password, handle and return
                        return;
                    }
                }
            }
        }
    }
}

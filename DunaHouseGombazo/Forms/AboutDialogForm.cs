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
    public partial class AboutDialogForm : Form
    {
        public AboutDialogForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100) return;
            if (progressBar1.Visible == false)
            {
                progressBar1.Visible = true;
            }
            progressBar1.Value += 1;
            var rnd = DateTime.Now.Millisecond % 5;
            if (rnd == 0) button1.Text = "Yes!4";
            else if (rnd == 1) button1.Text = "MOre!$";
            else if (rnd == 2) button1.Text = "Yes!";
            else if (rnd == 3) button1.Text = "ye$!!";
            else button1.Text = "COMEON!";
            if (progressBar1.Value == 100)
            {
                var result = MessageBox.Show("Oh my god you are so enthusiastic. Here you go. If you pick the right one, you might get the info you want.", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Ignore)
                {
                    infoPanel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Whoops, sorry. Not that one.");
                    progressBar1.Value -= DateTime.Now.Millisecond % 35;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

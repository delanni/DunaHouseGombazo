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
            if (progressBar1.Visible == false)
            {
                progressBar1.Visible = true;
            }
            progressBar1.Value += 50;
            if (progressBar1.Value ==99)
            {
                progressBar1.SetState(2);
                progressBar1.Value++;
            }
            if (progressBar1.Value == 100)
            {
                MessageBox.Show("Please stop it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

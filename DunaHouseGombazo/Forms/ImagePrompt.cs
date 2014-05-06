using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunaHouseGombazo
{
    public partial class ImagePrompt : Form
    {
        string urlRegex = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";

        public string ImageUrl { get; set; }

        public Bindable<bool> AllowOk = new Bindable<bool>(true);

        public ImagePrompt()
        {
            InitializeComponent();
            button2.Enabled = false;        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, urlRegex))
            {
                pictureBox1.ImageLocation = textBox1.Text;
                ImageUrl = textBox1.Text;
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

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
    public partial class HouseDetailsForm : Form
    {
        private House house;
        private bool editMode;
        DHSEntities db;

        private int imageIndexer = -1;

        public HouseDetailsForm(House selectedHouse, bool editMode = false, DHSEntities outerDataContext = null)
        {
            InitializeComponent();
            this.house = selectedHouse;
            this.editMode = editMode;
            if (outerDataContext == null)
            {
                db = new DHSEntities();
            }
            else db = outerDataContext;

            houseBindingSource.DataSource = selectedHouse;
            imageBindingSource.DataSource = selectedHouse.Image.FirstOrDefault() ?? new Image();
        }

        private bool validate(Control c)
        {
            var regex = (string)c.Tag;
            if (string.IsNullOrEmpty(regex)) return true;

            if (c is TextBox)
            {
                if (!Regex.IsMatch(c.Text, regex))
                {
                    c.BackColor = Color.LightSalmon ;
                    return false;
                }
                else
                {
                    c.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            return true;
        }


        private void HouseDetailsForm_Load(object sender, EventArgs e)
        {
            lastModifiedLinkLabel.Text = this.house.LastEditedByUser.FullName;
            createdByLinkLabel.Text = this.house.CreatedByUser.FullName;
            representativeLinkLabel.Text = this.house.RepresentedByUser.FullName;

            var repId = this.house.RepresentativeId != 0 ? this.house.RepresentativeId : DashboardForm.User.Id;
            representativeComboBox.ValueMember = "Id";
            representativeComboBox.DisplayMember = "FullName";
            representativeComboBox.DataSource = db.User.ToList();
            representativeComboBox.SelectedValue = repId;

            conditionComboBox.ValueMember = "Id";
            conditionComboBox.DisplayMember = "TextForm";
            conditionComboBox.DataSource = db.Conditioning.ToList();
            conditionComboBox.SelectedValue = this.house.Condition ?? 1;

            heatingComboBox.ValueMember = "Id";
            heatingComboBox.DisplayMember = "TextForm";
            heatingComboBox.DataSource = db.Heating.ToList();
            heatingComboBox.SelectedIndex = this.house.Heating ?? 1;

            renderExtras();

            if (editMode == false)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox || c is ComboBox || c is CheckBox)
                        c.Enabled = false;
                }
                saveButton.Text = "Close";
                editExtrasPanel.Visible = false;
            }
        }

        private void renderExtras()
        {
            extrasPanel.Controls.Clear();

            for (var i = 0; i < house.Extras.Count; i++)
            {
                var extra = house.Extras.ElementAt(i);

                var cName = new TextBox();
                cName.Text = extra.Name;
                cName.Width = extrasPanel.Width / 7 * 3;
                cName.Margin = new System.Windows.Forms.Padding(8, 6, 1, 6);
                cName.Enabled = false;
                cName.Tag = extra;

                var cValue = new TextBox();
                cValue.Text = extra.Value;
                cValue.Width = extrasPanel.Width / 7 * 3;
                cValue.Margin = new System.Windows.Forms.Padding(1, 6, 8, 6);
                cValue.Enabled = false;
                cValue.Tag = extra;

                var cDeleteButton = new Button();
                cDeleteButton.Text = "X";
                cDeleteButton.Width = 18;
                cDeleteButton.Tag = extra;
                cDeleteButton.Click += cDeleteButton_Click;
                cDeleteButton.Visible = editMode;

                extrasPanel.Controls.Add(cName);
                extrasPanel.Controls.Add(cValue);
                extrasPanel.Controls.Add(cDeleteButton);
            }
        }

        void cDeleteButton_Click(object sender, EventArgs e)
        {
            house.Extras.Remove((sender as Button).Tag as Extra);
            renderExtras();
        }

        void cValue_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            var extra = ( tb.Tag as Extra);
            extra.Value = tb.Text;
            renderExtras();
            //var newTb = extrasPanel.Controls.OfType<TextBox>().FirstOrDefault(x => x.Text == extra.Value);
            //newTb.Focus();
        }

        void cName_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            var extra = (tb.Tag as Extra);
            extra.Name = tb.Text;
            renderExtras();
            //var newTb = extrasPanel.Controls.OfType<TextBox>().FirstOrDefault(x => x.Text == extra.Name);
            //newTb.Focus();
        }

        private void representativeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.house.RepresentativeId = (int)this.representativeComboBox.SelectedValue;
            this.house.RepresentedByUser = db.User.SingleOrDefault(x => x.Id == house.RepresentativeId);
            if (this.house.LastEditedByUser == null) return;

            representativeLinkLabel.Text = this.house.RepresentedByUser.FullName;
        }

        private void representativeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openUser(house.RepresentativeId);
        }

        private void createdByLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openUser(house.CreatedBy);
        }

        private void lastModifiedLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openUser(house.LastEditedBy);
        }


        private void openUser(int id)
        {
            var result = (new UserViewForm(id)).ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK && DashboardForm.User.Id == id)
            {
                DashboardForm.User = db.User.Single(x => x.Id == id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var imagePrompt = new ImagePrompt();
            var result = imagePrompt.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var i = new Image();
                i.HouseId = this.house.Id;
                i.House = this.house;
                i.ImageUrl = imagePrompt.ImageUrl;
                house.Image.Add(i);
                nextImageButton_Click(sender, e);
            }
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {
            if (house.Image.Any())
            {
                imageIndexer++;
                if (imageIndexer >= house.Image.Count) imageIndexer = house.Image.Count - 1;
                imageBindingSource.DataSource = house.Image.ElementAt(imageIndexer);
            }
        }

        private void previousImageButton_Click(object sender, EventArgs e)
        {
            if (house.Image.Any())
            {
                imageIndexer--;
                if (imageIndexer <= 0) imageIndexer = 0;
                imageBindingSource.DataSource = house.Image.ElementAt(imageIndexer);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var toRemove = house.Image.ElementAt(imageIndexer);
            house.Image.Remove(toRemove);
            if (house.Image.Count <= imageIndexer)
            {
                imageIndexer = house.Image.Count - 1;
                if (imageIndexer >= 0)
                {
                    imageBindingSource.DataSource = house.Image.ElementAt(imageIndexer);
                }
                else
                {
                    imageBindingSource.DataSource = new Image();
                }
            }
            else
            {
                imageBindingSource.DataSource = house.Image.ElementAt(imageIndexer);
            }
        }

        private void addExtraButton_Click(object sender, EventArgs e)
        {
            if (extraNameTextbox.Text.Any())
            {
                var extra = new Extra();
                extra.Name = extraNameTextbox.Text;
                extra.Value = extraValueTextbox.Text;

                house.Extras.Add(extra);

                extraNameTextbox.Clear();
                extraValueTextbox.Clear();

                renderExtras();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                this.Close();
                return;
            }

            this.house.LastEditedByUser = db.User.SingleOrDefault(x => x.Id == DashboardForm.User.Id);
            this.house.LastEditedBy = DashboardForm.User.Id;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox || c is CheckBox)
                    if (!validate(c)) return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

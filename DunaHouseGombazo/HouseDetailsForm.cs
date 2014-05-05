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
    public partial class HouseDetailsForm : Form
    {
        private House house;
        private bool editMode;
        DHSEntities db;
        public HouseDetailsForm(House selectedHouse, bool editMode=false)
        {
            InitializeComponent();
            db = new DHSEntities();
            // TODO: Complete member initialization
            this.house = selectedHouse;
            this.editMode = editMode;

            houseBindingSource.DataSource = selectedHouse;
        }

        private void addnewbutton_Click(object sender, EventArgs e)
        {
            
            
            //return;
            //ellenőrzés
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void HouseDetailsForm_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = this.house.LastEditedByUser.FullName;
            linkLabel2.Text = this.house.CreatedByUser.FullName;

        }
    }
}

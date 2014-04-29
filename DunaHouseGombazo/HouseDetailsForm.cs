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

        public HouseDetailsForm(House selectedHouse, bool editMode=false)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            this.house = selectedHouse;
            this.editMode = editMode;

            houseBindingSource.DataSource = selectedHouse;
        }
    }
}

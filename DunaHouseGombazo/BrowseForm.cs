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
    public partial class BrowseForm : Form
    {
        DHSEntities db;

        private IEnumerable<string> keywords;

        public BrowseForm()
        {
            InitializeComponent();
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            db = new DHSEntities();

            cbConditioning.DisplayMember = "TextForm";
            cbConditioning.ValueMember = "Id";
            cbConditioning.DataSource = db.Conditioning.ToList();

            cbHeating.DisplayMember = "TextForm";
            cbHeating.ValueMember = "Id";
            cbHeating.DataSource = db.Heating.ToList();

            keywords = db.Extra.Select(x => x.Name).Distinct();
            tbKeyword.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void BrowseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var dashboardForm = Application.OpenForms.OfType<DashboardForm>().FirstOrDefault();
            if (dashboardForm == null) Application.Exit();
            else dashboardForm.Show();
        }

        private void resultListViewSelectionChanged(object sender, EventArgs e)
        {
            if (resultGridView.SelectedRows.Count != 0)
            {
                // if the selection is not -1 then enable the buttons corresponding to the access rights of the user                
            }
            else
            {
                viewButton.Enabled = editButton.Enabled = deleteButton.Enabled = importButton.Enabled = exportButton.Enabled = false;
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            // view forms should be closed on closing so create a new instance every time
            openSelectedHouse();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // view forms should be closed on closing so create a new instance every time
            openSelectedHouse(DashboardForm.User.CanEdit);
            House h = new House();
            var house = new HouseDetailsForm(h, true);
            var result = house.ShowDialog();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (DashboardForm.User.CanImport)
            {
                JSONImport.Dialogs.Import(db);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (DashboardForm.User.CanExport)
            {
                var selectedHouses = new List<House>();
                foreach (var selectedRow in resultGridView.SelectedRows)
                    selectedHouses.Add(((DataGridViewRow)selectedRow).DataBoundItem as House);

                JSONImport.Dialogs.Export(selectedHouses);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DashboardForm.User.CanEdit)
            {
                var housesToDelete = new List<House>();
                foreach (var selectedRow in resultGridView.SelectedRows)
                    housesToDelete.Add(((DataGridViewRow)selectedRow).DataBoundItem as House);

                if (MessageBox.Show("Are you sure you want to delete these " + housesToDelete.Count.ToString() + " nice houses?",
                    "Oh... come on?!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (var h in housesToDelete)
                    {
                        db.House.Remove(h);

                        foreach(var extra in db.Extra.Where(x=>x.HouseId == h.Id)){
                            db.Extra.Remove(extra);
                        }

                        foreach (var img in db.Image.Where(x => x.HouseId == h.Id))
                        {
                            db.Image.Remove(img);
                        }

                    }
                    db.SaveChanges();

                    MessageBox.Show(housesToDelete.Count.ToString() + " records successfully deleted");
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Összeállítani az érdekes kitöltött keresési mezőket, és ezek alapján megcsinálni a lekérdezést, majd betölteni a kapott adatot a listába
            searchGroupBox.Enabled = false;

            string refId = tbRefid.Text;
            string longName = tbLongName.Text;
            int? priceMin = tbPriceMin.Text.TryParseToInt() ?? int.MinValue;
            int? priceMax = tbPriceMax.Text.TryParseToInt() ?? int.MaxValue;
            int? sizeMin = tbSizeMin.Text.TryParseToInt() ?? int.MinValue;
            int? sizeMax = tbSizeMax.Text.TryParseToInt() ?? int.MaxValue;
            bool withBalcony = cbHasBalcony.Checked;
            bool withLift = cbHasLift.Checked;
            int roomsMin = (cbRoomsMin.SelectedValue == null ? null : cbRoomsMin.SelectedValue.ToString().TryParseToInt()) ?? int.MinValue;
            int roomsMax = (cbRoomsMax.SelectedValue == null ? null : cbRoomsMax.SelectedValue.ToString().TryParseToInt()) ?? int.MaxValue;

            string addressSnippet = tbAddress.Text;

            string extraKeyword = tbKeyword.Text;
            string extraValue = tbKeywordValue.Text;

            var startingSet = db.House.ToList();

            var filtered = startingSet.Where(x => x.ReferenceId.Contains(refId) && x.LongName.Contains(longName)
                && (!withBalcony || x.Balcony.Value) && (!withLift || x.Lift.Value)
                && x.Price <= priceMax && x.Price >= priceMin
                && x.Size <= sizeMax && x.Size >= sizeMin
                && x.NumberOfRooms >= roomsMin && x.NumberOfRooms <= roomsMax
                && (string.IsNullOrEmpty(addressSnippet) || (x.Address != null && x.Address.Contains(addressSnippet))));

            var specialFiltered = filtered.Where(
                x => (string.IsNullOrEmpty(extraKeyword) && string.IsNullOrEmpty(extraValue))  // vagy nincs kitöltve
                    || x.Extras.Any(y => y.Name.Contains(extraKeyword) && y.Value.Contains(extraValue))); //vagy ha ki van, akkor van ilyen extra

            houseBindingSource.DataSource = specialFiltered.ToList();

            searchGroupBox.Enabled = true;
        }

        private void tbKeywordValue_Leave(object sender, EventArgs e)
        {
            keywordHintLabel.Visible = false;
        }

        private void tbKeywordValue_Enter(object sender, EventArgs e)
        {
            keywordHintLabel.Visible = true;
        }

        private void resultGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openSelectedHouse(DashboardForm.User.CanEdit);
        }

        private void openSelectedHouse(bool edit = false)
        {
            if (resultGridView.SelectedRows.Count == 0) return;
            var selectedRow = resultGridView.SelectedRows[0];
            var selectedHouse = (House)selectedRow.DataBoundItem;

            (new HouseDetailsForm(selectedHouse, edit)).Show();
        }

        private void tbKeyword_TextChanged(object sender, EventArgs e)
        {
            tbKeyword.AutoCompleteCustomSource.Clear();
            tbKeyword.AutoCompleteCustomSource.AddRange(keywords.Where(x => x.Contains(tbKeyword.Text)).ToArray());
        }

    }
}

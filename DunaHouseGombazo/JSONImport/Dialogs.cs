using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunaHouseGombazo.JSONImport
{
    public class Dialogs
    {
        public static void Export(IEnumerable<House> housesToExport)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Exporting " + housesToExport.Count() + " records";
            dialog.DefaultExt = ".json";
            dialog.AddExtension = true;
            dialog.Filter = "JSON file (*.json)|*.json|Text file(*.txt)|*.txt|Any file|*.*";
            var dialogResult = dialog.ShowDialog();
            if (dialogResult != System.Windows.Forms.DialogResult.OK && dialogResult != System.Windows.Forms.DialogResult.Yes) return;

            new JSONImport.JSONMaster().Export(housesToExport, dialog.FileName);

            MessageBox.Show("Exporting " + housesToExport.Count().ToString() + " successfully into: " + dialog.FileName, "Export successful");
        }

        public static void Import(DHSEntities db)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON file (*.json)|*.json|Text file(*.txt)|*.txt|Any file|*.*";

            var dialogResult = dialog.ShowDialog();
            if (dialogResult != System.Windows.Forms.DialogResult.OK && dialogResult != System.Windows.Forms.DialogResult.Yes) return;


            var houses = (new JSONImport.JSONMaster()).Import(dialog.FileName);
            var users = db.User.ToList();
            if (houses.Any())
            {
                foreach (var h in houses)
                {
                    h.CreatedByUser = users.SingleOrDefault(x => x.Id == h.CreatedBy)??users.FirstOrDefault();
                    h.LastEditedByUser = users.SingleOrDefault(x => x.Id == h.LastEditedBy) ?? users.FirstOrDefault();
                    h.RepresentedByUser = users.SingleOrDefault(x => x.Id == h.RepresentativeId) ?? users.FirstOrDefault();
                    db.House.Add(h);
                }
                db.SaveChanges();
                MessageBox.Show(houses.Count().ToString() + " records imported successfuly, new queries may include new results.", "Import successful");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunaHouseGombazo.JSONImport
{
    public class HouseJson
    {
        public HouseJson() { }

        public HouseJson(House h)
        {
            this.Balcony = h.Balcony;
            this.Condition = h.Condition;
            this.CreatedBy = h.CreatedBy;
            this.Currency = h.Currency;
            this.Description = h.Description;
            this.Floor = h.Floor;
            this.FullUrl = h.FullUrl;
            this.Heating = h.Heating;
            this.Id = h.Id;
            this.LastEditedBy = h.LastEditedBy;
            this.Lift = h.Lift;
            this.LongName = h.LongName;
            this.NumberOfRooms = h.NumberOfRooms;
            this.Price = h.Price;
            this.ReferenceId = h.ReferenceId;
            this.RepresentativeId = h.RepresentativeId;
            this.Size = h.Size;
            this.Address = h.Address;
            this.Images = h.Image.Select(x=>new ImageJson(x));
        }

        public House ToHouse()
        {
            var h = this;
            var t = new House();
            t.Balcony = h.Balcony;
            t.Condition = h.Condition;
            t.CreatedBy = h.CreatedBy;
            t.Currency = h.Currency;
            t.Description = h.Description;
            t.Floor = h.Floor;
            t.FullUrl = h.FullUrl;
            t.Heating = h.Heating;
            t.Id = h.Id;
            t.LastEditedBy = h.LastEditedBy;
            t.Lift = h.Lift;
            t.LongName = h.LongName;
            t.NumberOfRooms = h.NumberOfRooms;
            t.Price = h.Price;
            t.ReferenceId = h.ReferenceId;
            t.RepresentativeId = h.RepresentativeId;
            t.Size = h.Size;
            t.Address = h.Address;
            t.Image = h.Images.Select(x=>x.ToImage()).ToList();
            return t;
        }

        public int CreatedBy { get; set; }

        public bool? Balcony { get; set; }

        public int? Condition { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public int? Floor { get; set; }

        public string FullUrl { get; set; }

        public int? Heating { get; set; }

        public int Id { get; set; }

        public int LastEditedBy { get; set; }

        public bool? Lift { get; set; }

        public string LongName { get; set; }

        public int? NumberOfRooms { get; set; }

        public long Price { get; set; }

        public string ReferenceId { get; set; }

        public int RepresentativeId { get; set; }

        public int? Size { get; set; }

        public string Address { get; set; }

        public IEnumerable<ImageJson> Images { get; set; }
    }

}

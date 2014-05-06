using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DunaHouseGombazo.JSONImport
{
    public class ImageJson
    {
        public ImageJson() { }

        public ImageJson(Image i) {
            this.Id = i.Id;
            this.ImageUrl = i.ImageUrl;
            this.HouseId = i.HouseId;
        }

        public Image ToImage()
        {
            var i = new Image();
            i.Id = this.Id;
            i.HouseId = this.HouseId;
            i.ImageUrl = this.ImageUrl;
            return i;
        }


        public int HouseId { get; set; }

        public string ImageUrl { get; set; }

        public int Id { get; set; }
    }
}

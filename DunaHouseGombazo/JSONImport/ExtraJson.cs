using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DunaHouseGombazo.JSONImport
{
    public class ExtraJson
    {
        public ExtraJson() { }

        public ExtraJson(Extra x)
        {
            this.Id = x.Id;
            this.Name = x.Name;
            this.Value = x.Value;
            this.HouseId = x.HouseId;
            this.Type = x.Type;
        }

        internal Extra ToExtra()
        {
            var e = new Extra();
            e.Id = this.Id;
            e.HouseId = this.HouseId;
            e.Name = this.Name;
            e.Value = this.Value;
            e.Type = this.Type;

            return e;
        }

        public string Value { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        public int HouseId { get; set; }

        public string Type { get; set; }
    }
}

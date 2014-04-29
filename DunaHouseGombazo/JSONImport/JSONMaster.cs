using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;

namespace DunaHouseGombazo.JSONImport
{

    public class JSONMaster
    {
        JavaScriptSerializer serializer;
        public JSONMaster()
        {
            serializer = new JavaScriptSerializer();
        }


        public string Export(IEnumerable<House> houses, string fileName = null)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                var date = DateTime.Now.ToString("mmm-dd-hh-MM");
                fileName = "JSON_EXPORT_" + date + ".json";
            }

            
            var file=File.CreateText(fileName);

            var x = serializer.Serialize(houses.Select(o=>new HouseJson(o)));
            //serializer.WriteObject(xmlWriter, houses);
            file.Write(x);
            file.Close();
            return fileName;
        }

        public string Export(House house, string fileName = null)
        {
            return Export(new List<House>() { house }, fileName);
        }

        public IEnumerable<House> Import(string fileName)
        {
            var f = File.OpenText(fileName);
            var jsonText = f.ReadToEnd();

            var houses = serializer.Deserialize<IEnumerable<HouseJson>>(jsonText);

            return houses.Select(x => x.ToHouse()) ;
        }
    }

}

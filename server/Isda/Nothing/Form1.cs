using Isda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nothing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vesselType = new[] {
                        "canoe",
                        "skiff",
                        "flatboat",
                        "jetski",
                        "innertube",
                        "yacht",
                        "trawler",
                        "pontoon",
                        "cigarette"
                    };
            var engine = new[] {
                "briggs",
                "dana",
                "human power",
                "na",
                "paddle",
                "alligator"
            };
            var r = new Random();
            var blah = new HackathonEntities();
            foreach (var i in Enumerable.Repeat(1,500))
            {
                var hp = r.Next(0,40)*25 + "";
                hp = hp == "0" ? null : hp;
                var v = new Vessel()
                {
                    VesselType = vesselType[r.Next(0, vesselType.Length - 1)],
                    Engine = engine[r.Next(0, engine.Length - 1)],
                    Horsepower = hp,
                    BoatHeight = (decimal)(r.Next(1, 220) * .5),
                    BoatLength = (decimal)(r.Next(36, 256) * .5),
                    BoatWidth = (decimal)(r.Next(8, 400) * .25)
                };
                blah.Vessels.Add(v);
            }
            blah.SaveChanges();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var fishTypes = new [] {
                "Agoot","Alakaak","Alumahan","Alumahang bato ","Apahap","Asohos","Ayungin","Babansi ",
                " bagaong","Bakoko","Banak"," asubi "," talilong","Bangus","Bidbid","Biloan","Bisugo",
                "Bitilya","Biya","Buan-buan","Burara","Chabeta","hiwas","Dalag","Dalag-dagat ","Dalagang  bukid"
                ,"Danggit","Dapa","Dilat","Dilis","Twakang","Dorado","Dulong","Espada","Galunggong","Gulyasan ",
                "Hasa-hasa","kabalyas / kabayas","Hito","Igat","palos","Isu","Kabasi","Kalaso ","Kanduli","Kitang",
                "Labahita","Lao-lao","lawlaw","Lapu-lapu","Lohoran ","Loro","Ludong","Malaga","Malakapas","Malasugi",
                "Mamali ","Liwalo "," Martiniko","Matangbaka","Maya-maya","bambangin","pargo","Pampano","Sagisi / tikwi",
                "Samaral","Salay-salay","Salay-salay aso / salingga","Salay batang","kalapato","Sapsap","Silinyasi","tunsoy",
                "Sinarapan","Taksay","Talakitok","maliputo","Talimusak","Tambakol ","Tamban","Tanigue","tangigue",
                "Tawilis","Tilapia","pla pla","Torsilyo","Tulingan"
            };
            var r = new Random();
            var now = DateTime.Now;
            var blah = new HackathonEntities();
            var vesselIds = blah.Vessels.Select(a => a.VesselId).Distinct().ToArray();
            var landingSiteIds = blah.LandingSites.Select(a => a.LandingSiteId).Distinct().ToArray();
            
            foreach (var i in Enumerable.Repeat(1,1000)) {
                var h = new Haul() {
                    FishType = fishTypes[r.Next(0, fishTypes.Length - 1)],
                    HaulDateTime = now - new TimeSpan(r.Next(1, 120), r.Next(0,23), r.Next(0,60), 0),
                    HaulWeight = r.Next(3,100),
                    LandingSiteId = landingSiteIds[r.Next(0, landingSiteIds.Length - 1)],
                    Latitude = (decimal)r.Next(8439382, 15915121) / (decimal)1000000,
                    Longitude = (decimal)r.Next(121619926, 124650688) / (decimal)1000000,
                    Notes = null,
                    NumberOfFisherman = r.Next(1, 10),
                    SampleWeight = r.Next(1, 40)/4,
                    VesselId = vesselIds[r.Next(0, vesselIds.Length - 1)]
                };
                h.TrapSetDateTime = h.HaulDateTime - new TimeSpan(r.Next(0, 2), r.Next(0, 23), r.Next(0, 60), 0);
                blah.Hauls.Add(h);
            }

            blah.SaveChanges();
        }
    }
}

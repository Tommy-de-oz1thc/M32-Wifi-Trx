using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSO_Trainer.Lister
{
 public   class States
    {
        public static List<string> State = new List<string>(new string[] {
            "california",
            "california",
            "california",
            "louisiana",
            "louisiana",//5
            "louisiana",
            "colorado",
            "colorado",
            "colorado",
            "maine",//10
            "maine",
            "maine",
            "kentucky",
            "kentucky",
            "kentucky",//15
            "tennessee",
            "tennessee",
            "tennessee",
            "florida",
            "florida",//20
            "florida",
            "kansas",
            "kansas",
            "kansas",
            "maryland",//25
            "maryland",
            "maryland",
            "south dakota",
            "south dakota",
            "south dakota",//30
            "michigan",
            "michigan",
            "michigan",
            "illinois",
            "illinois",//35
            "illinois",
            "hawaii",
            "hawaii",
            "hawaii",
            "florida",//40
            "florida",
            "florida",
            "south dakota",
            "south dakota",
            "south dakota",//45
            "south carolina",
            "south carolina",
            "south carolina",
            "idaho",
            "idaho",//50
            "idaho",
            "kentucky",
            "kentucky",
            "kentucky",
            "alabama",//55
            "alabama",
            "alabama",
            "new mexico",
            "new mexico",
            "new mexico",//60
            "utah",
            "utah",
            "utah",
            "minnesota",
            "minnesota",//65
            "minnesota",
            "massachusetts",
            "massachusetts",
            "massachusetts",
            "vermont",//70
            "vermont",
            "vermont",
            "alaska",
            "alaska",
            "alaska",//75
            "oklahoma",
            "oklahoma",
            "oklahoma",
            "washington",
            "washington",//80
            "washington",
            "south carolina",
            "south carolina",
            "south carolina",
            "indiana",//85
            "indiana",
            "indiana",
            "rhode island",
            "rhode island",
            "rhode island",//90
            "ohio",
            "ohio",
            "ohio",
            "alabama",
            "alabama",//95
            "alabama",
            "massachusetts",
            "massachusetts",
            "massachusetts",
            "new mexico",//100
            "new mexico",
            "new mexico",
            "north dakota",
            "north dakota",
            "north dakota",//105
            "michigan",
            "michigan",
            "michigan",
            "kentucky",
            "kentucky",//110
            "kentucky",
            "minnesota",
            "minnesota",
            "minnesota",
            "missouri",//115
            "missouri",
            "missouri",
            "indiana",
            "indiana",
            "indiana",//120
            "massachusetts",
            "massachusetts",
            "massachusetts",
            "texas",
            "texas",//125
            "texas",
            "alaska",
            "alaska",
            "alaska",
            "mississippi",//130
            "mississippi",
            "mississippi",
            "texas",
            "texas",
            "texas",//135
            "missouri",
            "missouri",
            "missouri",
            "michigan",
            "michigan",//140
            "michigan",
            "virginia",
            "virginia",
            "virginia",
            "wyoming",//145
            "wyoming",
            "wyoming",
            "georgia",
            "georgia",
            "georgia",//150
            "utah",
            "utah",
            "utah",
            "wyoming",
            "wyoming",//155
            "wyoming",
            "new mexico",
            "new mexico",
            "new mexico",
            "louisiana",//160
            "louisiana",
            "louisiana",
            "iowa",
            "iowa",
            "iowa",//165
            "tennessee",
            "tennessee",
            "tennessee",
            "alaska",
            "alaska",//170
            "alaska",
            "mississippi",
            "mississippi",
            "mississippi",
            "pennsylvania",//175
            "pennsylvania",
            "pennsylvania",
            "illinois",
            "illinois",
            "illinois",//180
            "tennessee",
            "tennessee",
            "tennessee",
            "new york",
            "new york",//185
            "new york",
            "illinois",
            "illinois",
            "illinois",
            "nevada",//190
            "nevada",
            "nevada",
            "rhode island",
            "rhode island",
            "rhode island",//195
            "colorado",
            "colorado",
            "colorado",
            "tennessee",
            "tennessee",//200
            "tennessee",
            "maine",
            "maine",
            "maine",
            "vermont",//205
            "vermont",
            "vermont",
            "wisconsin",
            "wisconsin",
            "wisconsin",//210
            "pennsylvania",
            "pennsylvania",
            "pennsylvania",
            "pennsylvania",
            "pennsylvania",//215
            "pennsylvania",
            "new york",
            "new york",
            "new york",
            "wyoming",//220
            "wyoming",
            "wyoming",
            "illinois",
            "illinois",
            "illinois",//225
            "west virginia",
            "west virginia",
            "west virginia",
            "deleware",
            "deleware",//230
            "deleware",
            "wyoming",
            "wyoming",
            "wyoming",
            "rhode island",//235
            "rhode island",
            "rhode island",
            "connecticut",
            "connecticut",
            "connecticut",//240
            "mississippi",
            "mississippi",
            "mississippi",
            "maine",
            "maine",//245
            "maine",
            "arkansas",
            "arkansas",
            "arkansas",
            "south dakota",//250
            "south dakota",
            "south dakota",
            "utah",
            "utah",
            "utah",//255
            "colorado",
            "colorado",
            "colorado",
            "arkansas",
            "arkansas",//260
            "arkansas",
            "michigan",
            "michigan",
            "michigan",
            "missouri",//265
            "missouri",
            "missouri",
            "washington",
            "washington",
            "washington",//270
            "oregon",
            "oregon",
            "oregon",
            "utah",
            "utah",//275
            "utah",
            "louisiana",
            "louisiana",
            "louisiana",
            "louisiana",//280
            "louisiana",
            "louisiana",
            "west virginia",
            "west virginia",
            "west virginia",//285
            "north carolina",
            "north carolina",
            "north carolina",
            "illinois",
            "illinois",//290
            "illinois",
            "ohio",
            "ohio",
            "ohio",
            "utah",//295
            "utah",
            "utah",
            "arizona",
            "arizona",
            "arizona",//300
            "alaska",
            "alaska",
            "alaska",
            "minnesota",
            "minnesota",//305
            "minnesota",
            "new mexico",
            "new mexico",
            "new mexico",
            "arkansas",//310
            "arkansas",
            "arkansas",
            "south dakota",
            "south dakota",
            "south dakota",//315
            "north carolina",
            "north carolina",
            "north carolina",
            "idaho",
            "idaho",//320
            "idaho",
            "arkansas",
            "arkansas",
            "arkansas",
            "utah",//325
            "utah",
            "utah",
            "new mexico",
            "new mexico",
            "new mexico",//330
            "georgia",
            "georgia",
            "georgia",
            "new mexico",
            "new mexico",//335
            "new mexico",
            "north dakota",
            "north dakota",
            "north dakota",
            "hawaii",//340
            "hawaii",
            "hawaii",
            "maine",
            "maine",
            "maine",//345
            "new jersey",
            "new jersey",
            "new jersey",
            "massachusetts",
            "massachusetts",//350
            "massachusetts",
            "hawaii",
            "hawaii",
            "hawaii",
            "nevada",//355
            "nevada",
            "nevada",
            "ohio",
            "ohio",
            "ohio",//360
            "mississippi",
            "mississippi",
            "mississippi",
            "new york",
            "new york",//365
            "new york",
            "maryland",
            "maryland",
            "maryland",
            "iowa",//370
            "iowa",
            "iowa",
            "wyoming",
            "wyoming",
            "wyoming",//375
            "washington",
            "washington",
            "washington",
            "texas",
            "texas",//380
            "texas",
            "minnesota",
            "minnesota",
            "minnesota",
            "new mexico",//385
            "new mexico",
            "new mexico",
            "alaska",
            "alaska",
            "alaska",//390
            "idaho",
            "idaho",
            "idaho",
            "arizona",
            "arizona",//395
            "arizona",
            "kansas",
            "kansas",
            "kansas",
            "alabama",//400
            "alabama",
            "alabama",
            "nevada",
            "nevada",
            "nevada",//405
            "california",
            "california",
            "california",
            "colorado",
            "colorado",//410
            "colorado",
            "georgia",
            "georgia",
            "georgia",
            "iowa",//415
            "iowa",
            "iowa",
            "oregon",
            "oregon",
            "oregon",//420
            "south carolina",
            "south carolina",
            "south carolina",
            "oregon",
            "oregon",//425
            "oregon",
            "tennessee",
            "tennessee",
            "tennessee",
            "utah",//430
            "utah",
            "utah",
            "minnesota",
            "minnesota",
            "minnesota",//435
            "michigan",
            "michigan",
            "michigan",
            "washington",
            "washington",//440
            "washington",
            "north dakota",
            "north dakota",
            "north dakota",
            "north carolina",//445
            "north carolina",
            "north carolina",
            "missouri",
            "missouri",
            "missouri",//450
            "new york",
            "new york",
            "new york",
            "south carolina",
            "south carolina",//455
            "south carolina",
            "georgia",
            "georgia",
            "georgia",
            "new mexico",//460
            "new mexico",
            "new mexico",
            "minnesota",
            "minnesota",
            "minnesota",//465
            "vermont",
            "vermont",
            "vermont",
            "new jersey",
            "new jersey",//470
            "new jersey",
            "pennsylvania",
            "pennsylvania",
            "pennsylvania",
            "kansas",//475
            "kansas",
            "kansas",
            "nebraska",
            "nebraska",
            "nebraska",//480
            "massachusetts",
            "massachusetts",
            "massachusetts",
            "washington",
            "washington",//485
            "washington",
            "new hampshire",
            "new hampshire",
            "new hampshire",
            "south dakota",//490
            "south dakota",
            "south dakota",
            "texas",
            "texas",
            "texas",//495
            "montana",
            "montana",
            "montana",
            "kansas",
            "kansas",//500
            "kansas",
            "florida",
            "florida",
            "florida",
            "wyoming",//505
            "wyoming",
            "wyoming",
            "new hampshire",
            "new hampshire",
            "new hampshire",//510
            "virginia",
            "virginia",
            "virginia",
            "michigan",
            "michigan",//515
            "michigan",
            "new hampshire",
            "new hampshire",
            "new hampshire",
            "north dakota",//520
            "north dakota",
            "north dakota",
            "iowa",
            "iowa",
            "iowa",//525
            "utah",
            "utah",
            "utah",
            "maryland",
            "maryland",//530
            "maryland",
            "new hampshire",
            "new hampshire",
            "new hampshire",
            "south dakota",//535
            "south dakota",
            "south dakota",
            "deleware",
            "deleware",
            "deleware",//540
            "alabama",
            "alabama",
            "alabama",
            "montana",
            "montana",//545
            "montana",
            "washington",
            "washington",
            "washington",
            "tennessee",//550
            "tennessee",
            "tennessee",
            "georgia",
            "georgia",
            "georgia",//555
            "deleware",
            "deleware",
            "deleware",
            "new york",
            "new york",//560
            "new york",
            "minnesota",
            "minnesota",
            "minnesota",
            "massachusetts",//565
            "massachusetts",
            "massachusetts",
            "new hampshire",
            "new hampshire",
            "new hampshire",//570
            "utah",
            "utah",
            "utah",
            "new jersey",
            "new jersey",//575
            "new jersey",
            "mississippi",
            "mississippi",
            "mississippi",
            "virginia",//580
            "virginia",
            "virginia",
            "maryland",
            "maryland",
            "maryland",//585
            "nebraska",
            "nebraska",
            "nebraska",
            "connecticut",
            "connecticut",//590
            "connecticut",
            "wisconsin",
            "wisconsin",
            "wisconsin",
            "california",//595
            "california",
            "california",
            "minnesota",
            "minnesota",
            "minnesota",//600
            "washington",
            "washington",
            "washington",
            "utah",
            "utah",//605
            "utah",
            "north carolina",
            "north carolina",
            "north carolina",
            "wisconsin",//610
            "wisconsin",
            "wisconsin",
            "louisiana",
            "louisiana",
            "louisiana",//615
            "washington",
            "washington",
            "washington",
            "louisiana",
            "louisiana",//620
            "louisiana",
            "connecticut",
            "connecticut",
            "connecticut",
            "south dakota",//625
            "south dakota",
            "south dakota",
            "south carolina",
            "south carolina",
            "south carolina",//630
            "new mexico",
            "new mexico",
            "new mexico",
            "tennessee",
            "tennessee",//635
            "tennessee",
            "virginia",
            "virginia",
            "virginia",
            "colorado",//640
            "colorado",
            "colorado",
            "michigan",
            "michigan",
            "michigan",//645
            "tennessee",
            "tennessee",
            "tennessee",
            "new jersey",
            "new jersey",//650
            "new jersey",
            "texas",
            "texas",
            "texas",
            "maine",//655
            "maine",
            "maine",
            "montana",
            "montana",
            "montana",//660
            "kentucky",
            "kentucky",
            "kentucky",
            "massachusetts",
            "massachusetts",//665
            "massachusetts",
            "georgia",
            "georgia",
            "georgia",
            "alabama",//670
            "alabama",
            "alabama",
            "new york",
            "new york",
            "new york",//675
            "washington",
            "washington",
            "washington",
            "new york",
            "new york",//680
            "new york",
            "alabama",
            "alabama",
            "alabama",
            "hawaii",//685
            "hawaii",
            "hawaii",
            "illinois",
            "illinois",
            "illinois",//690
            "nevada",
            "nevada",
            "nevada",
            "arkansas",
            "arkansas",//695
            "arkansas",
            "idaho",
            "idaho",
            "idaho",
            "minnesota",//700
            "minnesota",
            "minnesota",
            "arizona",
            "arizona",
            "arizona",//705
            "colorado",
            "colorado",
            "colorado",
            "mississippi",
            "mississippi",//710
            "mississippi",
            "nevada",
            "nevada",
            "nevada",
            "new york",//715
            "new york",
            "new york",
            "iowa",
            "iowa",
            "iowa",//720
            "maryland",
            "maryland",
            "maryland",
            "new hampshire",
            "new hampshire",//725
            "new hampshire",
            "iowa",
            "iowa",
            "iowa",
            "louisiana",//730
            "louisiana",
            "louisiana",
            "new hampshire",
            "new hampshire",
            "new hampshire",//735
            "iowa",
            "iowa",
            "iowa",
            "west virginia",
            "west virginia",//740
            "west virginia",
            "louisiana",
            "louisiana",
            "louisiana",
            "new hampshire",//745
            "new hampshire",
            "new hampshire",
            "michigan",
            "michigan",
            "michigan",//750
            "deleware",
            "deleware",
            "deleware",
            "kansas",
            "kansas",//755
            "kansas",
            "missouri",
            "missouri",
            "missouri",
            "new hampshire",//760
            "new hampshire",
            "new hampshire",
            "virginia",
            "virginia",
            "virginia",//765
            "montana",
            "montana",
            "montana",
            "north carolina",
            "north carolina",//770
            "north carolina",
            "rhode island",
            "rhode island",
            "rhode island",
            "iowa",//775
            "iowa",
            "iowa",
            "maryland",
            "maryland",
            "maryland",//780
            "oregon",
            "oregon",
            "oregon",
            "texas",
            "texas",//785
            "texas",
            "new jersey",
            "new jersey",
            "new jersey",
            "michigan",//790
            "michigan",
            "michigan",
            "iowa",
            "iowa",
            "iowa",//795
            "washington",
            "washington",
            "washington",
            "new jersey",
            "new jersey",//800
            "new jersey",
            "alaska",
            "alaska",
            "alaska",
            "maryland",//805
            "maryland",
            "maryland",
            "south carolina",
            "south carolina",
            "south carolina",//810
            "south carolina",
            "south carolina",
            "south carolina",
            "iowa",
            "iowa",//815
            "iowa",
            "west virginia",
            "west virginia",
            "west virginia",
            "nevada",//820
            "nevada",
            "nevada",
            "georgia",
            "georgia",
            "georgia",//825
            "wyoming",
            "wyoming",
            "wyoming",
            "arizona",
            "arizona",//830
            "arizona",
            "arizona",
            "arizona",
            "arizona",
            "kentucky",//835
            "kentucky",
            "kentucky",
            "missouri",
            "missouri",
            "missouri",//840
            "georgia",
            "georgia",
            "georgia",
            "hawaii",
            "hawaii",//845
            "hawaii",
            "north carolina",
            "north carolina",
            "north carolina",
            "deleware",//850
            "deleware",
            "deleware",
            "north dakota",
            "north dakota",
            "north dakota",//855
            "west virginia",
            "west virginia",
            "west virginia",
            "illinois",
            "illinois",//860
            "illinois",
            "north carolina",
            "north carolina",
            "north carolina",
            "arkansas",//865
            "arkansas",
            "arkansas",
            "florida",
            "florida",
            "florida",//870
            "connecticut",
            "connecticut",
            "connecticut",
            "south dakota",
            "south dakota",//875
            "south dakota",
            "washington",
            "washington",
            "washington",
            "mississippi",//880
            "mississippi",
            "mississippi",
            "south dakota",
            "south dakota",
            "south dakota",//885
            "nevada",
            "nevada",
            "nevada",
            "alaska",
            "alaska",//890
            "alaska",
            "kentucky",
            "kentucky",
            "kentucky",
            "arkansas",//895
            "arkansas",
            "arkansas",
            "michigan",
            "michigan",
            "michigan"//900
        });
    }
}

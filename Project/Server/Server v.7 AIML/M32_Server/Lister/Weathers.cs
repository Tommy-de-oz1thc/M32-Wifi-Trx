using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSO_Trainer.Lister
{
 public   class Weathers
    {
        public static List<string> Weather = new List<string>(new string[] {
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "rainy and warm",
            "rainy and warm",//5
            "rainy and warm",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "rainy and cold",//10
            "rainy and cold",
            "rainy and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//15
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "hot and dry",
            "hot and dry",//20
            "hot and dry",
            "foggy",
            "foggy",
            "foggy",
            "hot and muggy",//25
            "hot and muggy",
            "hot and muggy",
            "hot and dry",
            "hot and dry",
            "hot and dry",//30
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//35
            "rainy and warm",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "rainy and warm",//40
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//45
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and cold",
            "overcast and cold",//50
            "overcast and cold",
            "snow and cold",
            "snow and cold",
            "snow and cold",
            "overcast and warm",//55
            "overcast and warm",
            "overcast and warm",
            "foggy",
            "foggy",
            "foggy",//60
            "rainy and cold ",
            "rainy and cold ",
            "rainy and cold ",
            "foggy",
            "foggy",//65
            "foggy",
            "foggy",
            "foggy",
            "foggy",
            "sunny and cold",//70
            "sunny and cold",
            "sunny and cold",
            "foggy",
            "foggy",
            "foggy",//75
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "rainy and cold",
            "rainy and cold",//80
            "rainy and cold",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "overcast and cold",//85
            "overcast and cold",
            "overcast and cold",
            "foggy",
            "foggy",
            "foggy",//90
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "foggy",
            "foggy",//95
            "foggy",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "foggy",//100
            "foggy",
            "foggy",
            "foggy",
            "foggy",
            "foggy",//105
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "rainy and warm",
            "rainy and warm",//110
            "rainy and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "snow and cold",//115
            "snow and cold",
            "snow and cold",
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",//120
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "overcast and warm",
            "overcast and warm",//125
            "overcast and warm",
            "foggy",
            "foggy",
            "foggy",
            "rainy and cold",//130
            "rainy and cold",
            "rainy and cold",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",//135
            "foggy",
            "foggy",
            "foggy",
            "sunny and warm",
            "sunny and warm",//140
            "sunny and warm",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "snow and cold",//145
            "snow and cold",
            "snow and cold",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//150
            "snow and cold",
            "snow and cold",
            "snow and cold",
            "overcast and warm",
            "overcast and warm",//155
            "overcast and warm",
            "snow and cold",
            "snow and cold",
            "snow and cold",
            "rainy and cold",//160
            "rainy and cold",
            "rainy and cold",
            "snow and cold",
            "snow and cold",
            "snow and cold",//165
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "hot and muggy",
            "hot and muggy",//170
            "hot and muggy",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "rainy and cold",//175
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",//180
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "hot and dry",
            "hot and dry",//185
            "hot and dry",
            "foggy",
            "foggy",
            "foggy",
            "sunny and warm",//190
            "sunny and warm",
            "sunny and warm",
            "snow and cold",
            "snow and cold",
            "snow and cold",//195
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "rainy and warm",
            "rainy and warm",//200
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "overcast and cold",//205
            "overcast and cold",
            "overcast and cold",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",//210
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "overcast and cold",
            "overcast and cold",//215
            "overcast and cold",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "sunny and cold",//220
            "sunny and cold",
            "sunny and cold",
            "foggy",
            "foggy",
            "foggy",//225
            "foggy",
            "foggy",
            "foggy",
            "overcast and cold",
            "overcast and cold",//230
            "overcast and cold",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "hot and muggy",//235
            "hot and muggy",
            "hot and muggy",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",//240
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "thunderstorm",
            "thunderstorm",//245
            "thunderstorm",
            "foggy",
            "foggy",
            "foggy",
            "snow and cold",//250
            "snow and cold",
            "snow and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//255
            "snow and cold",
            "snow and cold",
            "snow and cold",
            "hot and dry",
            "hot and dry",//260
            "hot and dry",
            "foggy",
            "foggy",
            "foggy",
            "thunderstorm",//265
            "thunderstorm",
            "thunderstorm",
            "snow and cold",
            "snow and cold",
            "snow and cold",//270
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "snow and cold",
            "snow and cold",//275
            "snow and cold",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "foggy",//280
            "foggy",
            "foggy",
            "foggy",
            "foggy",
            "foggy",//285
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "thunderstorm",
            "thunderstorm",//290
            "thunderstorm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//295
            "overcast and warm",
            "overcast and warm",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",//300
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "snow and cold",
            "snow and cold",//305
            "snow and cold",
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "overcast and cold",//310
            "overcast and cold",
            "overcast and cold",
            "foggy",
            "foggy",
            "foggy",//315
            "foggy",
            "foggy",
            "foggy",
            "thunderstorm",
            "thunderstorm",//320
            "thunderstorm",
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "rainy and cold",//325
            "rainy and cold",
            "rainy and cold",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",//330
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "rainy and cold",
            "rainy and cold",//335
            "rainy and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//340
            "overcast and cold",
            "overcast and cold",
            "snow and cold",
            "snow and cold",
            "snow and cold",//345
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "overcast and warm",
            "overcast and warm",//350
            "overcast and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and cold",//355
            "sunny and cold",
            "sunny and cold",
            "hot and dry",
            "hot and dry",
            "hot and dry",//360
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "overcast and warm",
            "overcast and warm",//365
            "overcast and warm",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "overcast and cold",//370
            "overcast and cold",
            "overcast and cold",
            "foggy",
            "foggy",
            "foggy",//375
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "sunny and cold",
            "sunny and cold",//380
            "sunny and cold",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "rainy and warm",//385
            "rainy and warm",
            "rainy and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//390
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "sunny and warm",
            "sunny and warm",//395
            "sunny and warm",
            "foggy",
            "foggy",
            "foggy",
            "foggy",//400
            "foggy",
            "foggy",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//405
            "foggy",
            "foggy",
            "foggy",
            "rainy and cold",
            "rainy and cold",//410
            "rainy and cold",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "thunderstorm",//415
            "thunderstorm",
            "thunderstorm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//420
            "foggy",
            "foggy",
            "foggy",
            "sunny and warm",
            "sunny and warm",//425
            "sunny and warm",
            "foggy",
            "foggy",
            "foggy",
            "hot and muggy",//430
            "hot and muggy",
            "hot and muggy",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//435
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "overcast and warm",
            "overcast and warm",//440
            "overcast and warm",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "sunny and warm",//445
            "sunny and warm",
            "sunny and warm",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",//450
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "sunny and cold",
            "sunny and cold",//455
            "sunny and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "rainy and warm",//460
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//465
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "hot and dry",
            "hot and dry",//470
            "hot and dry",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "thunderstorm",//475
            "thunderstorm",
            "thunderstorm",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",//480
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "foggy",
            "foggy",//485
            "foggy",
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "hot and muggy",//490
            "hot and muggy",
            "hot and muggy",
            "snow and cold",
            "snow and cold",
            "snow and cold",//495
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "snow and cold",
            "snow and cold",//500
            "snow and cold",
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "overcast and cold",//505
            "overcast and cold",
            "overcast and cold",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",//510
            "foggy",
            "foggy",
            "foggy",
            "thunderstorm",
            "thunderstorm",//515
            "thunderstorm",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "snow and cold",//520
            "snow and cold",
            "snow and cold",
            "foggy",
            "foggy",
            "foggy",//525
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "rainy and warm",
            "rainy and warm",//530
            "rainy and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//535
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//540
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "foggy",
            "foggy",//545
            "foggy",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "snow and cold",//550
            "snow and cold",
            "snow and cold",
            "hot and dry",
            "hot and dry",
            "hot and dry",//555
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "overcast and warm",
            "overcast and warm",//560
            "overcast and warm",
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "rainy and cold",//565
            "rainy and cold",
            "rainy and cold",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//570
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and cold",
            "sunny and cold",//575
            "sunny and cold",
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "sunny and warm",//580
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",//585
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "thunderstorm",
            "thunderstorm",//590
            "thunderstorm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "overcast and cold",//595
            "overcast and cold",
            "overcast and cold",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",//600
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "overcast and warm",
            "overcast and warm",//605
            "overcast and warm",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//610
            "overcast and cold",
            "overcast and cold",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",//615
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "thunderstorm",
            "thunderstorm",//620
            "thunderstorm",
            "foggy",
            "foggy",
            "foggy",
            "sunny and warm",//625
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",//630
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//635
            "rainy and warm",
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "hot and dry",//640
            "hot and dry",
            "hot and dry",
            "foggy",
            "foggy",
            "foggy",//645
            "foggy",
            "foggy",
            "foggy",
            "sunny and warm",
            "sunny and warm",//650
            "sunny and warm",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "overcast and warm",//655
            "overcast and warm",
            "overcast and warm",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",//660
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "overcast and warm",
            "overcast and warm",//665
            "overcast and warm",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "thunderstorm",//670
            "thunderstorm",
            "thunderstorm",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",//675
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//680
            "overcast and cold",
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "rainy and cold",//685
            "rainy and cold",
            "rainy and cold",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//690
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "hot and muggy",
            "hot and muggy",//695
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "sunny and warm",//700
            "sunny and warm",
            "sunny and warm",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//705
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "hot and muggy",
            "hot and muggy",//710
            "hot and muggy",
            "snow and cold",
            "snow and cold",
            "snow and cold",
            "snow and cold",//715
            "snow and cold",
            "snow and cold",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//720
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "rainy and cold",
            "rainy and cold",//725
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "hot and muggy",//730
            "hot and muggy",
            "hot and muggy",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",//735
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "sunny and cold",
            "sunny and cold",//740
            "sunny and cold",
            "foggy",
            "foggy",
            "foggy",
            "foggy",//745
            "foggy",
            "foggy",
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",//750
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "overcast and warm",
            "overcast and warm",//755
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "foggy",//760
            "foggy",
            "foggy",
            "foggy",
            "foggy",
            "foggy",//765
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "hot and muggy",
            "hot and muggy",//770
            "hot and muggy",
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "rainy and warm",//775
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//780
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "thunderstorm",
            "thunderstorm",//785
            "thunderstorm",
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "rainy and cold",//790
            "rainy and cold",
            "rainy and cold",
            "hot and dry",
            "hot and dry",
            "hot and dry",//795
            "sunny and cold",
            "sunny and cold",
            "sunny and cold",
            "sunny and warm",
            "sunny and warm",//800
            "sunny and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "overcast and cold",//805
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//810
            "thunderstorm",
            "thunderstorm",
            "thunderstorm",
            "overcast and cold",
            "overcast and cold",//815
            "overcast and cold",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",
            "foggy",//820
            "foggy",
            "foggy",
            "foggy",
            "foggy",
            "foggy",//825
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "hot and muggy",
            "hot and muggy",//830
            "hot and muggy",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and warm",//835
            "overcast and warm",
            "overcast and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",//840
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "sunny and warm",
            "sunny and warm",//845
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "sunny and warm",
            "overcast and warm",//850
            "overcast and warm",
            "overcast and warm",
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",//855
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "rainy and warm",
            "rainy and warm",//860
            "rainy and warm",
            "hot and dry",
            "hot and dry",
            "hot and dry",
            "rainy and cold",//865
            "rainy and cold",
            "rainy and cold",
            "overcast and cold",
            "overcast and cold",
            "overcast and cold",//870
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "snow and cold",
            "snow and cold",//875
            "snow and cold",
            "hot and muggy",
            "hot and muggy",
            "hot and muggy",
            "foggy",//880
            "foggy",
            "foggy",
            "overcast and warm",
            "overcast and warm",
            "overcast and warm",//885
            "rainy and warm",
            "rainy and warm",
            "rainy and warm",
            "sunny and cold",
            "sunny and cold",//890
            "sunny and cold",
            "rainy and cold",
            "rainy and cold",
            "rainy and cold",
            "sunny and cold",//895
            "sunny and cold",
            "sunny and cold",
            "hot and dry",
            "hot and dry",
            "hot and dry"//900
        });
    }
}

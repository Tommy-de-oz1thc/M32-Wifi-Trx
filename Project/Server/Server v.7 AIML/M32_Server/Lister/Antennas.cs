using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSO_Trainer.Lister
{
 public   class Antennas
    {
        public static List<string> Antenna = new List<string>(new string[] {
            "dipole",
            "dipole",
            "dipole",
            "inverted v",
            "inverted v",//5
            "inverted v",
            "yagi",
            "yagi",
            "yagi",
            "yagi",//10
            "yagi",
            "yagi",
            "inverted v",
            "inverted v",
            "inverted v",//15
            "inverted v",
            "inverted v",
            "inverted v",
            "monobander",
            "monobander",//20
            "monobander",
            "dipole",
            "dipole",
            "dipole",
            "inverted v",//25
            "inverted v",
            "inverted v",
            "zepp",
            "zepp",
            "zepp",//30
            "yagi",
            "yagi",
            "yagi",
            "colinear",
            "colinear",//35
            "colinear",
            "loop",
            "loop",
            "loop",
            "periodic",//40
            "periodic",
            "periodic",
            "vertical",
            "vertical",
            "vertical",//45
            "dipole",
            "dipole",
            "dipole",
            "yagi",
            "yagi",//50
            "yagi",
            "dipole",
            "dipole",
            "dipole",
            "yagi",//55
            "yagi",
            "yagi",
            "inverted v",
            "inverted v",
            "inverted v",//60
            "yagi",
            "yagi",
            "yagi",
            "vertical",
            "vertical",//65
            "vertical",
            "tribander",
            "tribander",
            "tribander",
            "colinear",//70
            "colinear",
            "colinear",
            "inverted v",
            "inverted v",
            "inverted v",//75
            "yagi",
            "yagi",
            "yagi",
            "yagi",
            "yagi",//80
            "yagi",
            "dipole",
            "dipole",
            "dipole",
            "dipole",//85
            "dipole",
            "dipole",
            "dipole",
            "dipole",
            "dipole",//90
            "monobander",
            "monobander",
            "monobander",
            "monobander",
            "monobander",//95
            "monobander",
            "monobander",
            "monobander",
            "monobander",
            "dipole",//100
            "dipole",
            "dipole",
            "tribander",
            "tribander",
            "tribander",//105
            "monobander",
            "monobander",
            "monobander",
            "delta loop",
            "delta loop",//110
            "delta loop",
            "dipole",
            "dipole",
            "dipole",
            "yagi",//115
            "yagi",
            "yagi",
            "yagi",
            "yagi",
            "yagi",//120
            "dipole",
            "dipole",
            "dipole",
            "tribander",
            "tribander",//125
            "tribander",
            "zepp",
            "zepp",
            "zepp",
            "dipole",//130
            "dipole",
            "dipole",
            "inverted v",
            "inverted v",
            "inverted v",//135
            "yagi",
            "yagi",
            "yagi",
            "vertical",
            "vertical",//140
            "vertical",
            "log periodic",
            "log periodic",
            "log periodic",
            "dipole",//145
            "dipole",
            "dipole",
            "v beam",
            "v beam",
            "v beam",//150
            "colinear",
            "colinear",
            "colinear",
            "dipole",
            "dipole",//155
            "dipole",
            "log periodic",
            "log periodic",
            "log periodic",
            "monobander",//160
            "monobander",
            "monobander",
            "yagi",
            "yagi",
            "yagi",//165
            "yagi",
            "yagi",
            "yagi",
            "inverted v",
            "inverted v",//170
            "inverted v",
            "zepp",
            "zepp",
            "zepp",
            "tribander",//175
            "tribander",
            "tribander",
            "tribander",
            "tribander",
            "tribander",//180
            "dipole",
            "dipole",
            "dipole",
            "dipole",
            "dipole",//185
            "dipole",
            "yagi",
            "yagi",
            "yagi",
            "dipole",//190
            "dipole",
            "dipole",
            "vertical",
            "vertical",
            "vertical",//195
            "dipole",
            "dipole",
            "dipole",
            "yagi",
            "yagi",//200
            "yagi",
            "log periodic",
            "log periodic",
            "log periodic",
            "dipole",//205
            "dipole",
            "dipole",
            "yagi",
            "yagi",
            "yagi",//210
            "zepp",
            "zepp",
            "zepp",
            "dipole",
            "dipole",//215
            "dipole",
            "delta loop",
            "delta loop",
            "delta loop",
            "zepp",//220
            "zepp",
            "zepp",
            "v beam",
            "v beam",
            "v beam",//225
            "v beam",
            "v beam",
            "v beam",
            "yagi",
            "yagi",//230
            "yagi",
            "vertical",
            "vertical",
            "vertical",
            "vertical",//235
            "vertical",
            "vertical",
            "dipole",
            "dipole",
            "dipole",//240
            "yagi",
            "yagi",
            "yagi",
            "dipole",
            "dipole",//245
            "dipole",
            "log periodic",
            "log periodic",
            "log periodic",
            "dipole",//250
            "dipole",
            "dipole",
            "log periodic",
            "log periodic",
            "log periodic",//255
            "yagi",
            "yagi",
            "yagi",
            "v beam",
            "v beam",//260
            "v beam",
            "yagi",
            "yagi",
            "yagi",
            "delta loop",//265
            "delta loop",
            "delta loop",
            "tribander",
            "tribander",
            "tribander",//270
            "dipole",
            "dipole",
            "dipole",
            "yagi",
            "yagi",//275
            "yagi",
            "log periodic",
            "log periodic",
            "log periodic",
            "inverted v",//280
            "inverted v",
            "inverted v",
            "dipole",
            "dipole",
            "dipole",//285
            "yagi",
            "yagi",
            "yagi",
            "dipole",
            "dipole",//290
            "dipole",
            "zepp",
            "zepp",
            "zepp",
            "yagi",//295
            "yagi",
            "yagi",
            "tribander",
            "tribander",
            "tribander",//300
            "dipole",
            "dipole",
            "dipole",
            "zepp",
            "zepp",//305
            "zepp",
            "inverted v",
            "inverted v",
            "inverted v",
            "monobander",//310
            "monobander",
            "monobander",
            "dipole",
            "dipole",
            "dipole",//315
            "log periodic",
            "log periodic",
            "log periodic",
            "monobander",
            "monobander",//320
            "monobander",
            "yagi",
            "yagi",
            "yagi",
            "vertical",//325
            "vertical",
            "vertical",
            "colinear",
            "colinear",
            "colinear",//330
            "dipole",
            "dipole",
            "dipole",
            "colinear",
            "colinear",//335
            "colinear",
            "monobander",
            "monobander",
            "monobander",
            "yagi",//340
            "yagi",
            "yagi",
            "monobander",
            "monobander",
            "monobander",//345
            "monobander",
            "monobander",
            "monobander",
            "colinear",
            "colinear",//350
            "colinear",
            "zepp",
            "zepp",
            "zepp",
            "dipole",//355
            "dipole",
            "dipole",
            "dipole",
            "dipole",
            "dipole",//360
            "colinear",
            "colinear",
            "colinear",
            "log periodic",
            "log periodic",//365
            "log periodic",
            "yagi",
            "yagi",
            "yagi",
            "colinear",//370
            "colinear",
            "colinear",
            "dipole",
            "dipole",
            "dipole",//375
            "tribander",
            "tribander",
            "tribander",
            "dipole",
            "dipole",//380
            "dipole",
            "colinear",
            "colinear",
            "colinear",
            "inverted v",//385
            "inverted v",
            "inverted v",
            "yagi",
            "yagi",
            "yagi",//390
            "dipole",
            "dipole",
            "dipole",
            "tribander",
            "tribander",//395
            "tribander",
            "vertical",
            "vertical",
            "vertical",
            "delta loop",//400
            "delta loop",
            "delta loop",
            "monobander",
            "monobander",
            "monobander",//405
            "v beam",
            "v beam",
            "v beam",
            "dipole",
            "dipole",//410
            "dipole",
            "yagi",
            "yagi",
            "yagi",
            "log periodic",//415
            "log periodic",
            "log periodic",
            "tribander",
            "tribander",
            "tribander",//420
            "monobander",
            "monobander",
            "monobander",
            "inverted v",
            "inverted v",//425
            "inverted v",
            "log periodic",
            "log periodic",
            "log periodic",
            "zepp",//430
            "zepp",
            "zepp",
            "inverted v",
            "inverted v",
            "inverted v",//435
            "dipole",
            "dipole",
            "dipole",
            "delta loop",
            "delta loop",//440
            "delta loop",
            "delta loop",
            "delta loop",
            "delta loop",
            "inverted v",//445
            "inverted v",
            "inverted v",
            "yagi",
            "yagi",
            "yagi",//450
            "yagi",
            "yagi",
            "yagi",
            "colinear",
            "colinear",//455
            "colinear",
            "log periodic",
            "log periodic",
            "log periodic",
            "dipole",//460
            "dipole",
            "dipole",
            "colinear",
            "colinear",
            "colinear",//465
            "yagi",
            "yagi",
            "yagi",
            "monobander",
            "monobander",//470
            "monobander",
            "monobander",
            "monobander",
            "monobander",
            "inverted v",//475
            "inverted v",
            "inverted v",
            "dipole",
            "dipole",
            "dipole",//480
            "dipole",
            "dipole",
            "dipole",
            "v beam",
            "v beam",//485
            "v beam",
            "zepp",
            "zepp",
            "zepp",
            "delta loop",//490
            "delta loop",
            "delta loop",
            "dipole",
            "dipole",
            "dipole",//495
            "log periodic",
            "log periodic",
            "log periodic",
            "v beam",
            "v beam",//500
            "v beam",
            "tribander",
            "tribander",
            "tribander",
            "delta loop",//505
            "delta loop",
            "delta loop",
            "inverted v",
            "inverted v",
            "inverted v",//510
            "dipole",
            "dipole",
            "dipole",
            "tribander",
            "tribander",//515
            "tribander",
            "v beam",
            "v beam",
            "v beam",
            "inverted v",//520
            "inverted v",
            "inverted v",
            "log periodic",
            "log periodic",
            "log periodic",//525
            "inverted v",
            "inverted v",
            "inverted v",
            "v beam",
            "v beam",//530
            "v beam",
            "yagi",
            "yagi",
            "yagi",
            "log periodic",//535
            "log periodic",
            "log periodic",
            "inverted v",
            "inverted v",
            "inverted v",//540
            "vertical",
            "vertical",
            "vertical",
            "dipole",
            "dipole",//545
            "dipole",
            "vertical",
            "vertical",
            "vertical",
            "v beam",//550
            "v beam",
            "v beam",
            "colinear",
            "colinear",
            "colinear",//555
            "dipole",
            "dipole",
            "dipole",
            "dipole",
            "dipole",//560
            "dipole",
            "dipole",
            "dipole",
            "dipole",
            "colinear",//565
            "colinear",
            "colinear",
            "inverted v",
            "inverted v",
            "inverted v",//570
            "zepp",
            "zepp",
            "zepp",
            "v beam",
            "v beam",//575
            "v beam",
            "v beam",
            "v beam",
            "v beam",
            "yagi",//580
            "yagi",
            "yagi",
            "delta loop",
            "delta loop",
            "delta loop",//585
            "log periodic",
            "log periodic",
            "log periodic",
            "v beam",
            "v beam",//590
            "v beam",
            "dipole",
            "dipole",
            "dipole",
            "dipole",//595
            "dipole",
            "dipole",
            "dipole",
            "dipole",
            "dipole",//600
            "yagi",
            "yagi",
            "yagi",
            "dipole",
            "dipole",//605
            "dipole",
            "yagi",
            "yagi",
            "yagi",
            "dipole",//610
            "dipole",
            "dipole",
            "inverted v",
            "inverted v",
            "inverted v",//615
            "yagi",
            "yagi",
            "yagi",
            "dipole",
            "dipole",//620
            "dipole",
            "inverted v",
            "inverted v",
            "inverted v",
            "vertical",//625
            "vertical",
            "vertical",
            "yagi",
            "yagi",
            "yagi",//630
            "zepp",
            "zepp",
            "zepp",
            "log periodic",
            "log periodic",//635
            "log periodic",
            "yagi",
            "yagi",
            "yagi",
            "monobander",//640
            "monobander",
            "monobander",
            "log periodic",
            "log periodic",
            "log periodic",//645
            "vertical",
            "vertical",
            "vertical",
            "tribander",
            "tribander",//650
            "tribander",
            "dipole",
            "dipole",
            "dipole",
            "monobander",//655
            "monobander",
            "monobander",
            "dipole",
            "dipole",
            "dipole",//660
            "tribander",
            "tribander",
            "tribander",
            "dipole",
            "dipole",//665
            "dipole",
            "colinear",
            "colinear",
            "colinear",
            "zepp",//670
            "zepp",
            "zepp",
            "dipole",
            "dipole",
            "dipole",//675
            "tribander",
            "tribander",
            "tribander",
            "log periodic",
            "log periodic",//680
            "log periodic",
            "yagi",
            "yagi",
            "yagi",
            "zepp",//685
            "zepp",
            "zepp",
            "inverted v",
            "inverted v",
            "inverted v",//690
            "colinear",
            "colinear",
            "colinear",
            "monobander",
            "monobander",//695
            "monobander",
            "log periodic",
            "log periodic",
            "log periodic",
            "tribander",//700
            "tribander",
            "tribander",
            "dipole",
            "dipole",
            "dipole",//705
            "vertical",
            "vertical",
            "vertical",
            "tribander",
            "tribander",//710
            "tribander",
            "yagi",
            "yagi",
            "yagi",
            "v beam",//715
            "v beam",
            "v beam",
            "delta loop",
            "delta loop",
            "delta loop",//720
            "yagi",
            "yagi",
            "yagi",
            "monobander",
            "monobander",//725
            "monobander",
            "tribander",
            "tribander",
            "tribander",
            "log periodic",//730
            "log periodic",
            "log periodic",
            "yagi",
            "yagi",
            "yagi",//735
            "dipole",
            "dipole",
            "dipole",
            "inverted v",
            "inverted v",//740
            "inverted v",
            "v beam",
            "v beam",
            "v beam",
            "vertical",//745
            "vertical",
            "vertical",
            "colinear",
            "colinear",
            "colinear",//750
            "colinear",
            "colinear",
            "colinear",
            "v beam",
            "v beam",//755
            "v beam",
            "monobander",
            "monobander",
            "monobander",
            "yagi",//760
            "yagi",
            "yagi",
            "monobander",
            "monobander",
            "monobander",//765
            "yagi",
            "yagi",
            "yagi",
            "log periodic",
            "log periodic",//770
            "log periodic",
            "dipole",
            "dipole",
            "dipole",
            "yagi",//775
            "yagi",
            "yagi",
            "v beam",
            "v beam",
            "v beam",//780
            "yagi",
            "yagi",
            "yagi",
            "yagi",
            "yagi",//785
            "yagi",
            "inverted v",
            "inverted v",
            "inverted v",
            "tribander",//790
            "tribander",
            "tribander",
            "v beam",
            "v beam",
            "v beam",//795
            "colinear",
            "colinear",
            "colinear",
            "log periodic",
            "log periodic",//800
            "log periodic",
            "colinear",
            "colinear",
            "colinear",
            "dipole",//805
            "dipole",
            "dipole",
            "log periodic",
            "log periodic",
            "log periodic",//810
            "tribander",
            "tribander",
            "tribander",
            "zepp",
            "zepp",//815
            "zepp",
            "colinear",
            "colinear",
            "colinear",
            "monobander",//820
            "monobander",
            "monobander",
            "v beam",
            "v beam",
            "v beam",//825
            "log periodic",
            "log periodic",
            "log periodic",
            "yagi",
            "yagi",//830
            "yagi",
            "log periodic",
            "log periodic",
            "log periodic",
            "monobander",//835
            "monobander",
            "monobander",
            "yagi",
            "yagi",
            "yagi",//840
            "log periodic",
            "log periodic",
            "log periodic",
            "dipole",
            "dipole",//845
            "dipole",
            "log periodic",
            "log periodic",
            "log periodic",
            "dipole",//850
            "dipole",
            "dipole",
            "monobander",
            "monobander",
            "monobander",//855
            "dipole",
            "dipole",
            "dipole",
            "inverted v",
            "inverted v",//860
            "inverted v",
            "inverted v",
            "inverted v",
            "inverted v",
            "dipole",//865
            "dipole",
            "dipole",
            "yagi",
            "yagi",
            "yagi",//870
            "vertical",
            "vertical",
            "vertical",
            "monobander",
            "monobander",//875
            "monobander",
            "tribander",
            "tribander",
            "tribander",
            "tribander",//880
            "tribander",
            "tribander",
            "yagi",
            "yagi",
            "yagi",//885
            "yagi",
            "yagi",
            "yagi",
            "inverted v",
            "inverted v",//890
            "inverted v",
            "vertical",
            "vertical",
            "vertical",
            "dipole",//895
            "dipole",
            "dipole",
            "vertical",
            "vertical",
            "vertical"//900
        });
    }
}

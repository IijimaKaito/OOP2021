using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    //インチとメートルの単位変換クラス（静的クラス）
    class InchConverter {
        private const double ratio = 0.0254;
       
        public static double FromMeter(int meter) {
            return meter / ratio ;
        }
        
        public static double ToMeter(int inch) {
            return inch * ratio;
        }
    }
}

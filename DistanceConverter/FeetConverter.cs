﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class FeetConverter {
        //フィートからメートルを求める
        public static double FeetToMeter(int feet) {
            return feet * 0.3048;
        }
        //メートルからフィートを求める
        public static double MeterToFeet(int meter) {
            return meter / 0.3048;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1,10);
            } else {
                PrintMeterToFeatList(1,10);
            }
        }
        private static void PrintMeterToFeatList(int stat,int stop) {
            FeetConverter converter = new FeetConverter();
            for (int meter = 1; meter <= 10; meter++) {
                    double feet = converter.MeterToFeet(meter);
        Console.WriteLine("{0} m = {1:0.0000}ft", meter, feet);
    }
}
        private static void PrintFeetToMeterList(int stat, int stop) {
            FeetConverter converter = new FeetConverter();
            for (int feet = 1; feet <= 10; feet++) {
                double meter = converter.FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000}m", feet, meter);
            }
        }
      
    }
}

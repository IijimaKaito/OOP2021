using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            //文字列が等しいか等しくないか比較する
            if (String.Compare(s1, s2, true) == 0) {
                Console.WriteLine("一致しています");
            } else {
                Console.WriteLine("一致していません");
            }

        }
    }
}

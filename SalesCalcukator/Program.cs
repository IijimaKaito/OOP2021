using System;
using System.Collections.Generic;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter("Sales.csv");
            
            var amountPerStore = sales.GetPerStoreSales();
            foreach(var obj in amountPerStore) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}

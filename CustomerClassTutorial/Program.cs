using System;

namespace CustomerClassTutorial {
    class Program {
        static void Main(string[] args) {

            var ord1 = new Order();
            var n = ord1.Add1(5);
            Console.WriteLine($"Add1 evaluates to {ord1.Add1(5)}");

            //var cust1 = new Customer("TQL", "Cincinnati", "OH");
            //cust1.AddSales(1000);
            //cust1.AddSales(4000.50m);
            //Console.WriteLine($"Customer {cust1.Name} sales is {cust1.Sales}");
        }
    }
}

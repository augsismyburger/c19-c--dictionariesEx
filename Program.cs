using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("IBM", "Internation Business Machines");
            stocks.Add("GOOG", "Alphabet Inc.");
            stocks.Add("AMZN", "Amazon.com");
            stocks.Add("PEP", "Pepsico");
            stocks.Add("SAM", "The Boston Beer Company");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add(("IBM", 20, 152.94));
            purchases.Add(("IBM", 50, 142.43));

            purchases.Add(("GOOG", 5, 918.59));
            purchases.Add(("GOOG", 7, 852.94));

            purchases.Add(("AMZN", 10, 978.76));
            purchases.Add(("AMZN", 22, 900.56));

            purchases.Add(("PEP", 70, 115.94));
            purchases.Add(("PEP", 45, 140.94));

            purchases.Add(("SAM", 89, 131.75));
            purchases.Add(("SAM", 120, 112.64));

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (stockReport.ContainsKey(stocks[purchase.ticker])) 
                {
                   stockReport[stocks[purchase.ticker]] += purchase.price * purchase.shares;
                }
                else 
                {
                   stockReport.Add(stocks[purchase.ticker], purchase.price * purchase.shares);
                }
            }

            foreach(KeyValuePair<string, double> kvp in stockReport)
            {
                Console.WriteLine($"{kvp.Key} : ${kvp.Value.ToString("0.00")}");
            }
        }
    }
}

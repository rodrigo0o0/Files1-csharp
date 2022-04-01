using File1CSharp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace File1CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string path = @"C:\temp\items.csv";
            string outFile = @"C:\temp\items_out.csv";
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double value = double.Parse(line[1],CultureInfo.InvariantCulture);
                        int amount = int.Parse(line[2]);
                        products.Add(new Product(name, value, amount));

                    }
                }
                foreach(Product product in products)
                {
                    using(StreamWriter sw =  File.AppendText(outFile))
                    {
                        sw.WriteLine(product.Name + "," + product.CalculateTotalValue().ToString("F2",CultureInfo.InvariantCulture));
                    } 
                }
                Console.ReadKey();
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}

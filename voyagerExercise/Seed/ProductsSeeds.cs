using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using voyagerExercise.Model;

namespace voyagerExercise.Seed
{
    class ProductsSeeds
    {

        public List<Product> products;

        public ProductsSeeds()
        {
            string filename = "Seed/products.json";
            this.products = new List<Product>();
            var testProduct = getList(filename).Result;
            this.products = testProduct;

            // //create product A 
            // var productA = new Product();
            // productA.code = "A";
            // productA.unitPrice = 1.25;

            // //create bulk price
            // var bulkpriceA = new BulkPrice();
            // bulkpriceA.code = productA.code;
            // bulkpriceA.qty = 3;
            // bulkpriceA.price = 3;
            // productA.bulkPrice = bulkpriceA;

            // //push product 1 to the list

            // //create product B 
            // var productB = new Product();
            // productB.code = "B";
            // productB.unitPrice = 4.25;

            // //create product C 
            // var productC = new Product();
            // productC.code = "C";
            // productC.unitPrice = 1.00;

            // var bulkpriceC = new BulkPrice();
            // bulkpriceC.code = productC.code;
            // bulkpriceC.qty = 6;
            // bulkpriceC.price = 5;
            // productC.bulkPrice = bulkpriceC;

            // //create product D 
            // var productD = new Product();
            // productD.code = "D";
            // productD.unitPrice = 0.75;

            // this.products.Add(productA);
            // this.products.Add(productB);
            // this.products.Add(productC);
            // this.products.Add(productD);



        }

        public async Task<List<Product>> getList(string filename)
        {
            try
            {
                FileStream fs = File.OpenRead(filename);
                var products = await JsonSerializer.DeserializeAsync<List<Product>>(fs);
                return products;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

                return null;
            }
        }
    }
}

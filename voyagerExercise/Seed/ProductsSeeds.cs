using System;
using System.Collections.Generic;
using System.Text;
using voyagerExercise.Model;

namespace voyagerExercise.Seed
{
    class ProductsSeeds
    {

        public List<Product> products;

        public ProductsSeeds()
        {
            this.products = new List<Product>();

            //create product A 
            var productA = new Product();
            productA.Code = "A";
            productA.unitPrice = 1.25;

            //create bulk price
            var bulkpriceA = new BulkPrice();
            bulkpriceA.code = productA.Code;
            bulkpriceA.qty = 3;
            bulkpriceA.price = 3;
            productA.bulkPrice = bulkpriceA;

            //push product 1 to the list

            //create product B 
            var productB = new Product();
            productB.Code = "B";
            productB.unitPrice = 4.25;

            //create product C 
            var productC = new Product();
            productC.Code = "C";
            productC.unitPrice = 1.00;

            var bulkpriceC = new BulkPrice();
            bulkpriceC.code = productC.Code;
            bulkpriceC.qty = 6;
            bulkpriceC.price = 5;
            productC.bulkPrice = bulkpriceC;

            //create product D 
            var productD = new Product();
            productD.Code = "D";
            productD.unitPrice = 0.75;

            this.products.Add(productA);
            this.products.Add(productB);
            this.products.Add(productC);
            this.products.Add(productD);



        }
    }
}

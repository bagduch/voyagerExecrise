using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using voyagerExercise.Model;
using voyagerExercise.Seed;


namespace voyagerExercise.Services
{
    class ProductServices
    {
        private readonly ProductsSeeds _seed;

        public ProductServices()
        {
            _seed = new ProductsSeeds();
        }
        /**
        * get product by code, this should be extend 
        */
        public Product GetProductByCode(char code)
        {
            var products = _seed.products.ToImmutableList();
            var index = products.FindIndex(product => product.code == code.ToString());
            if (index >= 0)
            {
                return products[index];
            }
            return null;
        }

        /*
        / find product that have Bulk Price Options 
        */
        public List<BulkPrice> getAllBuikList()
        {
            List<BulkPrice> buikList = new List<BulkPrice>();
            var products = _seed.products.ToImmutableList();
            foreach (Product p in products)
            {
                if (p.bulkPrice != null)
                {
                    if (p.bulkPrice.code == null)
                    {
                        p.bulkPrice.code = p.code;
                    }
                    buikList.Add(p.bulkPrice);
                }
            }

            return buikList;

        }
    }
}

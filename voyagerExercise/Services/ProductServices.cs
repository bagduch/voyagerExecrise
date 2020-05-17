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

        public Product GetProductByCode(char code)
        {
            var products = _seed.products.ToImmutableList();
            var index = products.FindIndex(product => product.Code == code.ToString());
            if (index >= 0)
            {
                return products[index];
            }
            return null;
        }

        public List<BulkPrice> getAllBuikList()
        {
            List<BulkPrice> buikList = new List<BulkPrice>();
            var products = _seed.products.ToImmutableList();
            foreach (Product p in products)
            {
                if (p.bulkPrice != null)
                {
                    buikList.Add(p.bulkPrice);
                }
            }

            return buikList;

        }
    }
}

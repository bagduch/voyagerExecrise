using System;
using System.Collections.Generic;
using System.Text;
using voyagerExercise.Seed;
using voyagerExercise.Model;

namespace voyagerExercise.Services
{
    class PointOfSaleTerminal
    {

        protected List<Cart> cart;
        private ProductServices _productServices;
        public PointOfSaleTerminal()
        {
            cart = new List<Cart>();
            _productServices = new ProductServices();
        }

        public void ScanProduct(string code)
        {
            char[] charArr = code.ToCharArray();
            foreach (char ch in charArr)
            {
                var product = _productServices.GetProductByCode(ch);
                if (product != null)
                {
                    addToCart(product);
                }
                else
                {
                    Console.WriteLine("Product Not exist");
                }
            }

        }

        public double CaculateTotal()
        {
            double currentTotal = 0;
            var buiklist = _productServices.getAllBuikList();
            foreach (Cart c in cart)
            {
                int index = buiklist.FindIndex(item => item.code == c.code && item.qty <= c.qty);
                if (index >= 0)
                {
                    int bulkTimes = c.qty / buiklist[index].qty;
                    int itemLeftAfterBulk = c.qty % buiklist[index].qty;
                    currentTotal += bulkTimes * buiklist[index].price + itemLeftAfterBulk * c.Pricing;
                }
                else
                {
                    currentTotal += c.qty * c.Pricing;
                }
            }
            return currentTotal;
        }
        public void addToCart(Product product)
        {
            var item = new Cart();
            item.code = product.Code;
            item.Pricing = product.unitPrice;
            item.qty = 1;

            int index = this.cart.FindIndex(item => item.code == product.Code);
            if (index >= 0)
            {
                this.cart[index].qty++;
            }
            else
            {
                this.cart.Add(item);
            }
        }
    }
}

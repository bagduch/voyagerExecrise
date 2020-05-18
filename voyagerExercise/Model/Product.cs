using System;
using System.Collections.Generic;
using System.Text;

namespace voyagerExercise.Model
{
    class Product
    {
        public string code { set; get; }


        public double unitPrice { set; get; }

        public BulkPrice bulkPrice { set; get; }

        public static implicit operator List<object>(Product v)
        {
            throw new NotImplementedException();
        }
    }

}

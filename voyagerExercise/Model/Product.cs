using System;
using System.Collections.Generic;
using System.Text;

namespace voyagerExercise.Model
{
    class Product
    {
        public string Code { set; get; }

        public double unitPrice { set; get; }

        public BulkPrice bulkPrice { set; get; }

    }
}

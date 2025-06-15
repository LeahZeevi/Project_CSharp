using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLApi;

namespace BIImplementation
{
    internal class BI : IBI
    {
        public Icustomer customer => new CustomerImplementation();

        public Iproducts products => new ProductImplementation();

        public Isale sale => new SaleImplementation();

        public Iorder order => new OrderImplementation();
    }
}

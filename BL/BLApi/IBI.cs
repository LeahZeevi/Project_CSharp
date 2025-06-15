using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLApi
{
    public interface IBI
    {
        Icustomer customer { get; }
        Iproducts products { get; }
        Isale sale { get; }
        Iorder order { get; }
    }
}

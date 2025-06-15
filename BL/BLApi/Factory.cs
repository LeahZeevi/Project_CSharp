using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIImplementation;

namespace BLApi
{
    public static class Factory
    {
        public static IBI Get()
        {
            IBI bi = new BI();
            return bi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPlusParser
{
    class SmartPlusOrder
    {
        public string station;
        public string vendor_code;
        public List<SmartPlusItem> items { get; set; }

        public SmartPlusOrder()
        {
            items = new List<SmartPlusItem>();
        }

    }
}

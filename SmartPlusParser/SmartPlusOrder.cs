using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPlusParser
{
    class SmartPlusOrder
    {
        public string station { get; set; }
        public string vendor_code { get; set; }
        public int acctg_number { get; set; }
        public int order_number { get; set; }
        public int order_revision { get; set; }
        public string campaign { get; set; }

        public List<SmartPlusItem> items { get; set; }

        public SmartPlusOrder()
        {
            items = new List<SmartPlusItem>();
        }

    }
}

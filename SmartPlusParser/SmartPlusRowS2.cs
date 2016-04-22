using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowS2
    {
        [FieldFixedLength(2)]
        public string row_type; // S2     Summary 2

        [FieldFixedLength(120)]
        public string dollars_per_mo; // 12 @ 10 characters each

        [FieldFixedLength(48)]
        public string units_per_mo; // 12 @ #### each

        [FieldFixedLength(10)]
        public string total_internal_dollars; // 

        [FieldFixedLength(10)]
        public string vendor_number; // 

        [FieldFixedLength(8)]
        public string user_id; // 

        [FieldFixedLength(58)]
        public string not_used; // 
        
    }
}

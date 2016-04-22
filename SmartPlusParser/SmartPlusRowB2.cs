using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowB2
    {
        [FieldFixedLength(2)]
        public string row_type; // B2     Buy Record 2

        [FieldFixedLength(36)]
        public string demo_estimates; // 6 @ 6 characters each

        [FieldFixedLength(48)]
        public string num_units_per_mo; // 12 @ #### each

        [FieldFixedLength(70)]
        public string remarks; // item number if “DEL”

        [FieldFixedLength(3)]
        public string prev_units; // 

        [FieldFixedLength(10)]
        public string prev_rate_per_spot; // 

        [FieldFixedLength(10)]
        public string prev_internal_dollars; // 

        [FieldFixedLength(48)]
        public string prev_units_per_mo; // 12 @ #### each

        [FieldFixedLength(29)]
        public string not_used; // 
    }
}

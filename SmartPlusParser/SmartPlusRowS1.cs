using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowS1
    {
        [FieldFixedLength(2)]
        public string row_type; // S1     Summary 1

        [FieldFixedLength(4)]
        public string total_units; // 

        [FieldFixedLength(10)]
        public string total_dollars; // 

        [FieldFixedLength(8)]
        public string total_grp; // 

        [FieldFixedLength(12)]
        public string budget_dollars; // 

        [FieldFixedLength(8)]
        public string budget_grp; // 

        [FieldFixedLength(208)]
        public string units_per_period; // 52 @ #### each

        [FieldFixedLength(4)]
        public string not_used; // 

    }
}

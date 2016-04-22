using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowS3
    {
        [FieldFixedLength(2)]
        public string row_type; // S3     

        [FieldFixedLength(4)]
        public string num_spots_in_sched; // 

        [FieldFixedLength(4)]
        public string num_spots_in_invoice; // 

        [FieldFixedLength(12)]
        public string dollars_in_sched; // 

        [FieldFixedLength(12)]
        public string dollars_billed_gross; // 

        [FieldFixedLength(12)]
        public string dollars_approved_gross; // 

        [FieldFixedLength(12)]
        public string dollars_approved_net; // 

        [FieldFixedLength(12)]
        public string budget_dollars; // 

        [FieldFixedLength(10)]
        public string vendor_num; // 

        [FieldFixedLength(8)]
        public string user_id; // 

        [FieldFixedLength(168)]
        public string not_used; // 


    }
}

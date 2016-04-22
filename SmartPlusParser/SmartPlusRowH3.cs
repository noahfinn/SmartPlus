using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowH3
    {
        [FieldFixedLength(2)]
        public string row_type; // H3     Header 3

        [FieldFixedLength(6)]
        public string vendor_num; // 

        [FieldFixedLength(12)]
        public string media_group; // UCASE

        [FieldFixedLength(5)]
        public string acctg_num; // Use this to track orders and invoices.

        [FieldFixedLength(4)]
        public string last_rev_to_finance; // 

        [FieldFixedLength(3)]
        public string flight_type; // Flight Type has the following codes: 0=tv long, 1=tv short, 100=radio long, 101=radio short. Cable buys will be associated with the TV flight types.

        [FieldFixedLength(8)]
        public string brand_code; // 

        [FieldFixedLength(1)]
        public string rating_source; // 

        [FieldFixedLength(3)]
        public string market_code; // 

        [FieldFixedLength(3)]
        public string detail_row_count; // 

        [FieldFixedLength(6)]
        public string hut_sweep; // 

        [FieldFixedLength(12)]
        public string total_budget; // 

        [FieldFixedLength(2)]
        public string dat_version_num; //  initiated by finmake

        [FieldFixedLength(5)]
        public string ncc_ams_syscode; // 

        [FieldFixedLength(8)]
        public string demo1_grp; // 

        [FieldFixedLength(8)]
        public string demo2_grp; // 

        [FieldFixedLength(32)]
        public string campaign; // Full field length

        [FieldFixedLength(18)]
        public string station_id; // Full field length

        [FieldFixedLength(10)]
        public string vendor_code; // Full field length

        [FieldFixedLength(9)]
        public string order_num; // Orders only; not invoices

        [FieldFixedLength(6)]
        public string campaign_code; // N’Fusion

        [FieldFixedLength(6)]
        public string product_code; // N’Fusion

        [FieldFixedLength(87)]
        public string not_used;


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowH2
    {
        [FieldFixedLength(2)]
        public string row_type; // H2     Header 2

        [FieldFixedLength(2)]
        public string num_periods; // weeks or days in flight

        [FieldFixedLength(72)]
        public string bill_end_dates; // Mmddyy - zero filled

        [FieldFixedLength(24)]
        public string station_rep; // 

        [FieldFixedLength(48)]
        public string demos; // 6 @ xxxxxxxx each

        [FieldFixedLength(12)]
        public string num_weeks_per_mo; // 12 @ # each - zero filled

        [FieldFixedLength(6)]
        public string tax_rate; // 

        [FieldFixedLength(6)]
        public string client_discount_rate; // 

        [FieldFixedLength(6)]
        public string agency_net_rate; // 

        [FieldFixedLength(24)]
        public string invoice_rev_num; // 12 @ ## each - zero filled

        [FieldFixedLength(10)]
        public string invoice_num; // 

        [FieldFixedLength(10)]
        public string invoice_date; // 

        [FieldFixedLength(10)]
        public string fiscal_date; // 

        [FieldFixedLength(6)]
        public string invoice_mo_yr; // mmm’yy

        [FieldFixedLength(6)]
        public string estimated_share_sweep; // 

        [FieldFixedLength(6)]
        public string actual_share_sweep; // 

        [FieldFixedLength(2)]
        public string network_user_num; // 

        [FieldFixedLength(1)]
        public string cash_trade; // C or T

        [FieldFixedLength(3)]
        public string media_type; // TV or RD or CA

    }
}

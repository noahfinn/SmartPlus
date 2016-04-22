using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowH1
    {
        [FieldFixedLength(2)]
        public string row_type;

        [FieldFixedLength(36)]
        public string market_name;

        [FieldFixedLength(3)]
        public int market_sequence_number;

        [FieldFixedLength(1)]
        public string rating_source;

        [FieldFixedLength(30)]
        public string advertiser;

        [FieldFixedLength(10)]
        public string advertiser_code;

        [FieldFixedLength(20)]
        public string product;

        [FieldFixedLength(5)]
        public string product_code;

        [FieldFixedLength(20)]
        public string campaign;

        [FieldFixedLength(8)]
        public string station;

        [FieldFixedLength(5)]
        public string start_date; // mmddy

        [FieldFixedLength(5)]
        public string end_date; // mmddy

        [FieldFixedLength(2)]
        public string start_year; // yy

        [FieldFixedLength(1)]
        public string type; // Long or Short (Long means weekly buy; short means daily buy)

        [FieldFixedLength(16)]
        public string estimate_num;

        [FieldFixedLength(16)]
        public string contract_num; // only 10 used

        [FieldFixedLength(16)]
        public string job_order_num;

        [FieldFixedLength(4)]
        public string file_ref_num;

        [FieldFixedLength(2)]
        public string deleted_flag; // 99 if deleted

        [FieldFixedLength(2)]
        public string revision_num;

        [FieldFixedLength(1)]
        public string record_type_following; // B or I for buy/invoice

        [FieldFixedLength(25)]
        public string agency_name;

        [FieldFixedLength(25)]
        public string buyer;

        [FieldFixedLength(1)]
        public int starting_day; // 0-6
    }
}

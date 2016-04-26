using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using Microsoft.VisualBasic.FileIO;

namespace SmartPlusParser
{
    [FixedLengthRecord]
    class SmartPlusRowB1
    {
        [FieldFixedLength(2)]
        public string row_type;

        [FieldFixedLength(3)]
        public string buy_item_number; // zero filled   DEL=deleted

        [FieldFixedLength(14)]
        public string program_name; // Market Name for SG xfer

        [FieldFixedLength(2)]
        public string daypart_code;

        /*
        // A custom converter
        internal class DateParser : ConverterBase
        {
            public override object StringToField(string from)
            {
                decimal res = Convert.ToDecimal(from);
                return res / 100;
            }

            public override string FieldToString(object from)
            {
                decimal d = (decimal)from;
                return Math.Round(d * 100).ToString();
            }
        }*/

        [FieldFixedLength(8)]
        public string start_date;

        [FieldFixedLength(8)]
        public string end_date;

        [FieldFixedLength(5)]
        public string start_time; // hhmm A or P

        [FieldFixedLength(5)]
        public string end_time; // hhmm A or P

        [FieldFixedLength(7)]
        public string days; // MTWTFSS

        [FieldFixedLength(3)]
        public string length; // zero filled

        [FieldFixedLength(3)]
        public string tag;

        [FieldFixedLength(3)]
        public string units; // 1 for SG xfer

        [FieldFixedLength(10)]
        public decimal rate_per_spot;

        [FieldFixedLength(10)]
        public float internal_dollars;

        [FieldFixedLength(156)]
        public string num_units_per_period; // 52 @ ### each

        [FieldFixedLength(2)]
        public int revision_num;

        [FieldFixedLength(2)]
        public int num_spots_per_insertion;

        [FieldFixedLength(1)]
        public int brk; // 0=none, 1=full, 2=before, 3=after

        [FieldFixedLength(1)]
        public string line_typle; // Makegood, Bonus, space

        [FieldFixedLength(3)]
        public string makegood_ref;

        [FieldFixedLength(8)]
        public string cable_network;
    }
}

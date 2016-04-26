using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPlusParser
{
        class SmartPlusItem
    {
        public int revision { get; set; } // to track item changes against order verion
        public int item_num { get; set; }
        public int units { get; set; }
        public decimal rate { get; set; }
        public List<int> units_per_period { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        private Dictionary<string, decimal> monthly_amounts;

        public void setupUnitDetails(string units, decimal rate, string units_per_period)
        {
            if (units == null) throw new ArgumentNullException("units cannot be null");
            if (rate <= 0) throw new ArgumentOutOfRangeException("rate cannot be less than zero");
            if (units_per_period == null) throw new ArgumentNullException("units per period cannot be null");

            this.units = Convert.ToInt32(units);
            this.rate = rate;
            setUnitsPerPeriod(units_per_period);

            setupMonthlyAmounts();
        }

        private void setUnitsPerPeriod(string input)
        {
            using (TextFieldParser parser = new TextFieldParser(new StringReader(input)))
            {
                parser.TextFieldType = FieldType.FixedWidth;
                parser.SetFieldWidths(3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
                                        3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
                                        3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
                                        3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
                                        3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
                                        3, 3); // 52 values, 1 per week
                units_per_period = Array.ConvertAll(parser.ReadFields(), int.Parse).ToList();
            }
        }

        private void setupMonthlyAmounts()
        {
            if (monthly_amounts == null) monthly_amounts = new Dictionary<string, decimal>();
            string current_month = start_date.ToString("yyyyMM");
            for (int i = 0; i < units_per_period.Count; i++)
            {
                if (units_per_period[i] * rate == 0) continue; // skip zero values
                if (!monthly_amounts.ContainsKey(current_month)) monthly_amounts[current_month] = 0; // initialize each month
                monthly_amounts[current_month] += units_per_period[i] * rate;
                current_month = start_date.AddDays(7 * i+1).ToString("yyyyMM");
            }
        }
    }
}

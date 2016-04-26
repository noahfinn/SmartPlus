using FileHelpers;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPlusParser
{
    class SmartPlusData
    {
        public Type RowSelector(MultiRecordEngine engine, string recordLine)
        {
            if (recordLine.Length == 0)
                return null;
            if (recordLine[0] == 'H' && recordLine[1] == '1')
                return typeof(SmartPlusRowH1);
            else if (recordLine[0] == 'H' && recordLine[1] == '2')
                return typeof(SmartPlusRowH2);
            else if (recordLine[0] == 'H' && recordLine[1] == '3')
                return typeof(SmartPlusRowH3);
            //else if (recordLine[0] == 'I' && recordLine[1] == '1')
            //    return typeof(SmartPlusItem);
            else if (recordLine[0] == 'B' && recordLine[1] == '1')
                return typeof(SmartPlusRowB1);
            else if (recordLine[0] == 'B' && recordLine[1] == '2')
                return typeof(SmartPlusRowB2);
            else if (recordLine[0] == 'S' && recordLine[1] == '1')
                return typeof(SmartPlusRowS1);
            else if (recordLine[0] == 'S' && recordLine[1] == '2')
                return typeof(SmartPlusRowS2);
            else if (recordLine[0] == 'S' && recordLine[1] == '3')
                return typeof(SmartPlusRowS3);
            else
                return null;
        }

        public static List<SmartPlusOrder> dataToOrder(object[] result)
        {
            List<SmartPlusOrder> orders = new List<SmartPlusOrder>();
            SmartPlusOrder order = new SmartPlusOrder();
            SmartPlusItem item = new SmartPlusItem();
            foreach (var rec in result)
            {
                if (rec.GetType() == typeof(SmartPlusRowH1))
                {
                    SmartPlusRowH1 row = (SmartPlusRowH1) rec;
                    order = new SmartPlusOrder();
                    orders.Add(order);

                    order.order_revision = Convert.ToInt32(row.revision_num);
                }
                else if (rec.GetType() == typeof(SmartPlusRowH2))
                {
                    SmartPlusRowH2 row = (SmartPlusRowH2)rec;
                }
                else if (rec.GetType() == typeof(SmartPlusRowH3))
                {
                    SmartPlusRowH3 row = (SmartPlusRowH3)rec;
                    order.station = row.station_id;
                    order.vendor_code = row.vendor_code;
                    order.acctg_number = Convert.ToInt32(row.acctg_num);
                    order.order_number = Convert.ToInt32(row.order_num);
                }
                else if (rec.GetType() == typeof(SmartPlusRowB1))
                {
                    SmartPlusRowB1 row = (SmartPlusRowB1)rec;
                    item = new SmartPlusItem();
                    order.items.Add(item);

                    if(row.buy_item_number == "DEL")
                    {
                        // TODO: handle deleted rows
                    } else
                    {
                        item.item_num = Convert.ToInt32(row.buy_item_number);
                    }
                    item.start_date = Convert.ToDateTime(row.start_date);
                    item.end_date = Convert.ToDateTime(row.end_date);

                    item.revision = row.revision_num;
                    item.setupUnitDetails(row.units, row.rate_per_spot, row.num_units_per_period);
                }
                else if (rec.GetType() == typeof(SmartPlusRowB2))
                {
                    SmartPlusRowB2 row = (SmartPlusRowB2)rec;
                }
                Console.WriteLine(rec.ToString());
            }
            return orders;
        }
    }
}

using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPlusParser
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiRecordEngine engine = new MultiRecordEngine(typeof(SmartPlusRowH1), 
                                                                typeof(SmartPlusRowH2), 
                                                                typeof(SmartPlusRowH3), 
                                                                typeof(SmartPlusRowB1),
                                                                typeof(SmartPlusRowB2),
                                                                typeof(SmartPlusRowS1),
                                                                typeof(SmartPlusRowS2),
                                                                typeof(SmartPlusRowS3));
            SmartPlusData spd = new SmartPlusData();
            engine.RecordSelector = new RecordTypeSelector(spd.RowSelector);

            var result = engine.ReadFile("\\\\Mac\\Home\\Documents\\Visual Studio 2015\\Projects\\SmartPlusParser\\SmartPlusParser\\FINANCE.DAT");
            List<SmartPlusOrder> orders = SmartPlusData.dataToOrder(result);

            Console.WriteLine("done");
        }
    }
}

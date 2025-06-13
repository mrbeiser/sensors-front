using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CSVgeneratereport : AbstractReportGenerator
    {
        public override void collect_data()
        {
            Console.WriteLine("Collecting data for csv");
        }

        public override void format_data()
        {
            Console.WriteLine("Formatting data for csv");
        }

        public override void save_report()
        {
            Console.WriteLine("Saving report for csv");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PDFgeneratereport : AbstractReportGenerator
    {
        public override void collect_data()
        {
            Console.WriteLine("Collecting data for pdf");
        }

        public override void format_data()
        {
            Console.WriteLine("Formatting data for pdf");
        }

        public override void save_report()
        {
            Console.WriteLine("Saving report for pdf");
        }
    }
}

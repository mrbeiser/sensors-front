using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class AbstractReportGenerator
    {
        abstract public void collect_data();
        abstract public void format_data();
        abstract public void save_report();


        public void generate_report()
        {
            collect_data();
            format_data();
            save_report();
        }
    }
}

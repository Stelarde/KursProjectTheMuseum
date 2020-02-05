using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace KursMuseum.Export.Excel
{
    public class Excell
    {
        protected Application app = new Application();
        protected Workbook wb;
        protected Worksheet ws;

        protected string patternPath;

        public Excell()
        {

        }
    }
}

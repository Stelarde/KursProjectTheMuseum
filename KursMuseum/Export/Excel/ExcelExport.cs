using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.DAL;
using KursMuseum.Model;

namespace KursMuseum.Export.Excel
{
    public class ExcelExport : Excell
    {
        public ExcelExport()
        {
            patternPath = Pattern.Pattern.Excel.ReportExcel;
            wb = app.Workbooks.Open(patternPath);
            ws = wb.Worksheets[1];
        }

        public void SetContent(RepositoryReportSellTicket apps)
        {
            ws.Cells.Replace("#месяц", DateTime.Now.ToString("dd/MM/yyyy"));
            ws.Range["A1:I3"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);

            int i = 4;
            foreach (ReportSellTicket item in apps.GetAll())
            {
                ws.Cells[i, 1].Value2 = item.NameExcursion;
                ws.Cells[i, 2].Value2 = item.TimeStart.ToString("dd/MM/yyyy");
                ws.Cells[i, 3].Value2 = item.CountChildTickets;
                ws.Cells[i, 4].Value2 = item.PriceChildTickets;
                ws.Cells[i, 5].Value2 = item.CountNormalTickets;
                ws.Cells[i, 6].Value2 = item.PriceNormalTickets;
                ws.Cells[i, 7].Value2 = item.CountOldTickets;
                ws.Cells[i, 8].Value2 = item.PriceOldTickets;
                ws.Cells[i, 9].Value2 = item.Summ;
                i++;
            }
            app.Visible = true;
        }
    }
}

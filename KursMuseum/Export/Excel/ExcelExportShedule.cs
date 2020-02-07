using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.DAL;
using KursMuseum.Model;

namespace KursMuseum.Export.Excel
{
    public class ExcelExportShedule : Excell
    {
        public ExcelExportShedule()
        {
            patternPath = Pattern.Pattern.Excel.ReportExcelShedule;
            wb = app.Workbooks.Open(patternPath);
            ws = wb.Worksheets[1];
        }

        public void SetContent(RepositoryScheduleExcursionItem apps)
        {
            ws.Range["A1:E2"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            int i = 3;
            foreach (ScheduleExcursionItem item in apps.GetAll())
            {
                ws.Cells[i, 1].Value2 = item.TypeExcursion;
                ws.Cells[i, 2].Value2 = item.TimeStart.ToString("dd/MM/yyyy");
                ws.Cells[i, 3].Value2 = item.TimeFinish.ToString("dd/MM/yyyy");
                ws.Cells[i, 4].Value2 = item.Venue;
                ws.Cells[i, 5].Value2 = item.InitialCost;
                i++;
            }
            app.Visible = true;
        }
    }
}

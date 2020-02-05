using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    class DiagramPrs
    {
        IDiagram diagram;
        public DiagramPrs(IDiagram DM)
        {
            diagram = DM;
            diagram.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Domein
{
    public interface IPlanningsMethode
    {
        Planning MaakPlanning(List<Taak> taken,string naam);
    }
}

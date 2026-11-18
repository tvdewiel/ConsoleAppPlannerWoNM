using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Domein
{
    public class PrioriteitsPlanningsMethode : IPlanningsMethode
    {
        public Planning MaakPlanning(List<Taak> taken, string naam)
        {
            List<Taak> takenSort=taken.OrderBy(x=>x.Prioriteit).ToList();
            return new Planning(naam, takenSort);
        }
    }
}

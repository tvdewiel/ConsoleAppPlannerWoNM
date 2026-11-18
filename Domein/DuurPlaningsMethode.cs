using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Domein
{
    public class DuurPlaningsMethode : IPlanningsMethode
    {
        public Planning MaakPlanning(List<Taak> taken, string naam)
        {
            List<Taak> takenSort=taken.OrderBy(x=>x.Duur).ToList();
            Planning p=new Planning(naam,takenSort);
            return p;
        }
    }
}

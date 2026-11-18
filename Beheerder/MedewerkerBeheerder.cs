using ConsoleAppPlannerWoNM.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Beheerder
{
    public class MedewerkerBeheerder
    {
        public MedewerkerBeheerder()
        {
            Medewerkers.Add(new Medewerker("Jos"));
        }

        public List<Medewerker> Medewerkers { get; set; } = new();
    }
}

using ConsoleAppPlannerWoNM.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Beheerder
{
    public class TaakBeheerder
    {
        private MedewerkerBeheerder medewerkerBeheerder;
        public TaakBeheerder(MedewerkerBeheerder medewerkerBeheerder)
        {
            this.medewerkerBeheerder = medewerkerBeheerder;
            Taken.Add(new Taak("Vloer leggen", 1, DateTime.Now, 240, medewerkerBeheerder.Medewerkers[0]));
            Taken.Add(new Taak("Lamp vervangen", 5, DateTime.Now, 40, medewerkerBeheerder.Medewerkers[0]));
            Taken.Add(new Taak("Afvoer ontstoppen", 2, DateTime.Now, 80, medewerkerBeheerder.Medewerkers[0]));
        }

        public List<Taak> Taken { get; set; } = new();
    }
}

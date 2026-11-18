using ConsoleAppPlannerWoNM.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Beheerder
{
    public class Planner
    {
        private TaakBeheerder TaakBeheerder;
        public IPlanningsMethode planningsMethode;

        public Planner(TaakBeheerder taakBeheerder, IPlanningsMethode planningsMethode)
        {
            TaakBeheerder = taakBeheerder;
            this.planningsMethode = planningsMethode;
        }

        public List<Planning> Planningen { get; set; } = new();
        public Planning MaakPlanning(string naam)
        {
            return planningsMethode.MaakPlanning(TaakBeheerder.Taken,naam);           
        }
    }
}

using ConsoleAppPlannerWoNM.Beheerder;
using ConsoleAppPlannerWoNM.Domein;

namespace ConsoleAppPlannerWoNM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welke methode (duur,prioriteit):");
            string methode=Console.ReadLine();

            IPlanningsMethode planningsMethode = null;
            if (methode =="duur")
            {
                planningsMethode = new DuurPlaningsMethode();
            }
            else if (methode =="prioriteit")
            {
                planningsMethode = new PrioriteitsPlanningsMethode();
            }
            Planner planner = new Planner(new TaakBeheerder(new MedewerkerBeheerder()), planningsMethode);
            Planning planning = planner.MaakPlanning("woensdagplanning");
            Console.WriteLine(planning);
        }
    }
}

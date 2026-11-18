using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Domein
{
    public class Taak
    {
        public Taak(string naam, int prioriteit, DateTime deadline, int duur, Medewerker medewerker)
        {
            Naam = naam;
            Prioriteit = prioriteit;
            Deadline = deadline;
            Duur = duur;
            Medewerker = medewerker;
        }

        public string Naam {  get; set; }
        public int Prioriteit { get; set; }
        public DateTime Deadline { get; set; }
        public int Duur {  get; set; }
        public Medewerker Medewerker { get; set; }
        public override string ToString()
        {
            return $"{Naam},{Prioriteit},{Duur}";
        }
    }
}

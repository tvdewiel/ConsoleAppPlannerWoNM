using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoNM.Domein
{
    public class Planning
    {
        public Planning(string naam, List<Taak> taken)
        {
            Naam = naam;
            Taken = taken;
        }

        public string Naam {  get; set; }
        public List<Taak> Taken { get; set; }
        public override string ToString()
        {
            string taken = string.Join('\n', Taken);
            return $"{Naam},\n,{taken}";
        }
    }
}

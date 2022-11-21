using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_NTM01.Model
{
    public class Misson
    {
        public List<string> MorningMisson { get; set; }
        public List<string> AfternoonMisson { get; set; }
        public List<string> EvenningMisson { get; set; }
        public string Date { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiszallitas_WPF.Models
{
    public class Megrendeles
    {
        public int Id { get; set; }
        public Futar FutarId {  get; set; }
        public Etel EtelId { get; set; }
        public string Cim { get; set; }
        public string FizetesiMod { get; set; }
        public DateOnly Datum { get; set; }
    }
}

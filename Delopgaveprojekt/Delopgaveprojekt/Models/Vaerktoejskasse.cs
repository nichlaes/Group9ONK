using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Models
{
    public partial class Vaerktoejskasse
    {
        public Vaerktoejskasse()
        {
            //Vaerktoej = new HashSet<Vaerktoej>();
        }
        [Key]
        public int VTKId { get; set; }
        public DateTime VTKAnskaffet { get; set; }
        public string VTKFabrikat { get; set; }
        public int? VTKEjesAf { get; set; }
        public string VTKModel { get; set; }
        public string VTKSerienummer { get; set; }
        public string VTKFarve { get; set; }
        public Haandvaerker EjesAfNavigation { get; set; }
        //public HashSet<Vaerktoej> Vaerktoej { get; set; }
    }
}

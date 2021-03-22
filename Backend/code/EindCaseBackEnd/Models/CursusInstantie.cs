using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EindCaseBackEnd.Models
{
    public class CursusInstantie
    {
        public DateTime StartDatum {get; set;}
        public string Code { get; set; }
        public int CursusID { get; set; }

        public Cursus Cursus { get; set; }

    }
}

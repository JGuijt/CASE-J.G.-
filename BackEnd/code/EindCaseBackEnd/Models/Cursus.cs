using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EindCaseBackEnd.Models
{
    public class Cursus
    {
        public int Id { get; set; }

        public string Duur { get; set; }
        public string Titel { get; set; }

        public string Code { get; set; }

        
        public ICollection<CursusInstantie> CursusInstanties { get; set; }


    }
}

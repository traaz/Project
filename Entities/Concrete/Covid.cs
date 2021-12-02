using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Covid:IEntity
    {
        public int CovidId { get; set; }
        public int CalisanId { get; set; }
        public int TemasliCalisanId { get; set; }
        public DateTime CovidYakalanmaTarih { get; set; }
        public DateTime CovidBitisTarih { get; set; }
        public string CovidOncesiBelirti { get; set; }

        public string AsiDurumu { get; set; }
        public string OncedenVurulanAsi { get; set; }
        public string KronikHastalik { get; set; }

    }
}

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
        
        public DateTime CovidYakalanmaTarih { get; set; }
        public DateTime CovidBitisTarih { get; set; }

        public int AsiDurumu { get; set; }
        public int KronikHastalikDurumu { get; set; }

    }
}

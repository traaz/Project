using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
 public   class SonBirAyCovidDto:IDto
    {
        
        public int CalisanId { get; set; }
        public DateTime CovidYakalanmaTarih { get; set; }
        public DateTime CovidBitisTarih { get; set; }
    }
}

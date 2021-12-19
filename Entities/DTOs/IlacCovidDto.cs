using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class IlacCovidDto:IDto
    {
        public string TcNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime CovidYakalanmaTarih { get; set; }
        public DateTime CovidBitisTarih { get; set; }
        public string IlacIsmi { get; set; }
    }
}

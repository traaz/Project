using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class Top3IlacCalisanDto:IDto
    {
        public string TcNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string IlasIsmi { get; set; }
    }
}

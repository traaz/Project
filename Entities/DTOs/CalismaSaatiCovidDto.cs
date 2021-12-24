using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class CalismaSaatiCovidDto:IDto
    {
        public int CalismaSaati { get; set; }
        public int CovidMiktari { get; set; }
    }
}

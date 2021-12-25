using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class BiontechSinovacCovidDto:IDto
    {
        public int CovidId { get; set; }
        public string AsiIsmi { get; set; }
        public int CovidSuresi { get; set; }
    }
}

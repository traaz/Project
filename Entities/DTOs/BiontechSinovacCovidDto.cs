using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class BiontechSinovacCovidDto:IDto
    {
      
        public string AsiIsmi { get; set; }
        public double OrtalamaCovidSuresi { get; set; }
    }
}

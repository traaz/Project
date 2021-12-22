using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class EgitimDurumuCovidDto:IDto
    {
        public int SayiMiktari { get; set; }
        public List<int> CalisanId { get; set; }
    }
}

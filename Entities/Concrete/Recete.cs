using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Recete:IEntity
    {
        public int ReceteId { get; set; }
        public int CalisanId { get; set; }
        public int HastalikId { get; set; }
        public string Ilac_1 { get; set; }
        public string Ilac_2 { get; set; }
        public string Ilac_3 { get; set; }
        public string Dozlar { get; set; }
        public string Sempton_1 { get; set; }
        public string Sempton_2 { get; set; }
        public string Sempton_3 { get; set; }
    }
}

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
        public string Ilac { get; set; }
        
        public string Dozlar { get; set; }
        public string Sempton { get; set; }
     
    }
}

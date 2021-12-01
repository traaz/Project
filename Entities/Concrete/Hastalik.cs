using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Hastalik:IEntity
    {
        public int HastalikId { get; set; }
        public int CalisanId { get; set; }
        public string HastalikIsmi { get; set; }
        public DateTime HastalikTarihi { get; set; }
        
    }
}

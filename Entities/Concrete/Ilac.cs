using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Ilac:IEntity
    {
        public int Id { get; set; }
        public string IlacIsmi { get; set; }
        public int HastalikId { get; set; }
        public int CalisanId { get; set; }
    }
}

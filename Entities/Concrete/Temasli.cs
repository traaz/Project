using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Temasli:IEntity
    {
        public int Id { get; set; }
        public int TemasliCalisanId { get; set; }
        public int CovidId { get; set; }
    }
}

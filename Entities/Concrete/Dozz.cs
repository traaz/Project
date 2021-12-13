using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Dozz:IEntity
    {
        public int Id { get; set; }
        public string Doz { get; set; }
        public int IlacId { get; set; }
    }
}

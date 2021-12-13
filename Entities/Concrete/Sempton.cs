using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Sempton:IEntity
    {
        public int Id { get; set; }
        public string SemptonIsmi { get; set; }
        public int HastalikId { get; set; }
    }
}

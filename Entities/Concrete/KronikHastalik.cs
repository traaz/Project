using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class KronikHastalik:IEntity
    {
        public int Id { get; set; }
        public string KronikHastalikIsmi { get; set; }
        public int CovidId { get; set; }




    }
}

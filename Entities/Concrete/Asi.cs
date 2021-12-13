using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
 public   class Asi:IEntity
    {
        public int Id { get; set; }

        public String AsiIsmi { get; set; }
        public int CovidId { get; set; }


    }
}

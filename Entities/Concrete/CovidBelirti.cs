using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class CovidBelirti:IEntity
    {
        public int Id { get; set; }
        public string Belirti { get; set; }
        public int CovidId { get; set; }
    }
}

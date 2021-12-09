using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Mesai:IEntity
    {
        public int MesaiId { get; set; }
        public int CalisanId { get; set; }
        public string IsBaslangicGun { get; set; }

        public string IsBitisGun { get; set; }

        public TimeSpan IsBaslangicSaat { get; set; }
        public TimeSpan IsBitisSaat { get; set; }

    }
}

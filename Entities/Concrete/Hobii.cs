using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Hobii:IEntity
    {
        public int Id { get; set; }

        public string Hobi { get; set; }

        public int CalisanId { get; set; }


    }
}

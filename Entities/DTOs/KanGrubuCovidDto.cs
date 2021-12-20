using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class KanGrubuCovidDto:IDto
    {
        public string KanGrubu { get; set; }
        public int CovidMiktari { get; set; }
    }
}

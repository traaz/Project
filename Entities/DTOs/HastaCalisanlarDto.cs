using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class HastaCalisanlarDto:IDto
    {
        public string TcNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string HastalikIsmi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisCassandraNapredneBazePodataka.Models
{
    public class Intervention
    {
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public string Description { get; set; }
        public DateTime MedicalControl { get; set; }
    }
}
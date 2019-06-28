using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class ExoticBeberage
    {
        public int ExoticBeberageId { get; set; }
        public String Description { get; set; }

        public String Step1 { get; set; }
        public String Step2 { get; set; }
        public String Step3 { get; set; }
        public String Step4 { get; set; }
        public String Step5 { get; set; }
        
        public String Ingrediente1 { get; set; }
        public String Ingrediente2{ get; set; }
        public String Ingrediente3 { get; set; }
        public String Ingrediente4 { get; set; }
        public String Ingrediente5 { get; set; }

        public double Costo { get; set; }
        public int PiezasPorPaquetes { get; set; }
        public int Paquetes { get; set;  }
        public bool Disponible { get; set;  }
    }
}

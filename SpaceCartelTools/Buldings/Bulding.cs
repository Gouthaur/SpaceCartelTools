using SpaceCartelTools.Buldings.Hellpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCartelTools.Buldings
{
    public class Bulding
    {
        public bool FirstProduct { get; set; }
        public bool SecProduct { get; set; }
        public bool ThirdProduct { get; set; }   
        public List<(int,int)> DevelopingCost { get; set; }
        public  Production FirstProductProduction { get; set; }
        public Production SecProductProduction { get; set; }
        public Production ThirdProductProduction { get; set; }




    }
}

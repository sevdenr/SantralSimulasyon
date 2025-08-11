using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantralSimülasyon
{
    internal class PlcOkunacakVeri
    {
        public bool start { get; set; }       //1
        public bool m1 { get; set; }       //2
        public bool m2 { get; set; }       //3
        public bool kabin1 { get; set; }       //4
        public bool m3 { get; set; }       //5
        public bool kabin2 { get; set; }       //6
        public bool kabin3 { get; set; }       //7
        public bool motorDurum { get; set; }       //8
        public bool stop { get; set; }         //9
        public bool m7 { get; set; }        //10
        public bool  sayac { get; set; }    
        public int Dgr { get; set; }//42002
    }
   
}

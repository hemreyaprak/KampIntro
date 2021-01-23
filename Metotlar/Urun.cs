using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //property - özellik
        public int Id { get; set; } //prop özellik tanımlamak için kullanılır.prop yazıp tab tab yap. 2 kere taba basınca my propertiese geçiyor. 2 kere entera basınca alta geçiyor. 
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace eProdaja.Services.Database
{
    public partial class Favoriti
    {

        public int FavoritiId { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public int ProizvodId { get; set; }


        public virtual Korisnici Korisnik { get; set; } 
        public virtual Proizvodi Proizvod { get; set; }
    }
}

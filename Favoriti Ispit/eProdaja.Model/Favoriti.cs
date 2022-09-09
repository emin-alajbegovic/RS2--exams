using System;
using System.Collections.Generic;

namespace eProdaja.Model
{
    public partial class Favoriti
    {
        public int FavoritiId { get; set; }
        public int ProizvodId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}

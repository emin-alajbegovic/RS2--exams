using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class FavoritiUpsertRequest
    {
        public int ProizvodId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
    }
}

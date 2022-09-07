﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;

namespace eProdaja.Services
{
    public interface IFavoritiService : ICRUDService<Favoriti, FavoritiSearchObject, FavoritiUpsertRequest, FavoritiUpsertRequest>
    {
        IEnumerable<Favoriti> GetAllUsersByProizvod(int proizvodId);
    }
}

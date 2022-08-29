using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class FavoritiService : BaseCRUDService<Model.Favoriti, Database.Favoriti, FavoritiSearchObject, FavoritiUpsertRequest, FavoritiUpsertRequest>, IFavoritiService
    {
        public FavoritiService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Favoriti> AddFilter(IQueryable<Favoriti> query, FavoritiSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.ProizvodId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.ProizvodId == search.ProizvodId);
            }

            return filteredQuery;
        }
    }
}

using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Model.Favoriti> GetAllUsersByProizvod(int proizvodId)
        {
            var users = Context.Favoriti.Include(x => x.Korisnik).Where(y => y.ProizvodId == proizvodId).ToList();

            if (users == null)
            {
                return null;
            }

            return Mapper.Map<IEnumerable<Model.Favoriti>>(users);
        }

    }
}

using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class FavoritiController : BaseCRUDController<Model.Favoriti, FavoritiSearchObject, FavoritiUpsertRequest, FavoritiUpsertRequest>
    {
        public IFavoritiService favoritiService { get; set; }
        public FavoritiController(IFavoritiService service)
            : base(service)
        {
            favoritiService = service;
        }

        [HttpGet("GetUsersByProizvod/{proizvodId}")]

        public IEnumerable<Model.Favoriti> GetUsersByProizvodId(int proizvodId)
        {
            return favoritiService.GetAllUsersByProizvod(proizvodId);
        }
    }
}

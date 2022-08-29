using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;

namespace eProdaja.Controllers
{
    public class FavoritiController : BaseCRUDController<Model.Favoriti, FavoritiSearchObject, FavoritiUpsertRequest, FavoritiUpsertRequest>
    {
        public FavoritiController(IFavoritiService service)
            : base(service)
        {
        }
    }
}

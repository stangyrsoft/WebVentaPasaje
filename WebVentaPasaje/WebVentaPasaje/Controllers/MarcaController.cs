using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebVentaPasaje.Models;

namespace WebVentaPasaje.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaModel> listMarcas = null;
            using (var bdPasaje = new BDPasajeEntities())
            {
                //Expresion lambda
                //listMarcas = bdPasaje.Marcas.Select(x => new MarcaModel
                //{
                //    Id = x.IIDMARCA,
                //    Nombre = x.NOMBRE,
                //    Descripcion = x.DESCRIPCION
                //}).ToList();

                //Expresion regular
                listMarcas = (from marca in bdPasaje.Marcas
                              select new MarcaModel
                              {
                                  Id = marca.IIDMARCA,
                                  Nombre = marca.NOMBRE,
                                  Descripcion = marca.DESCRIPCION
                              }).ToList();
            }
            return View(listMarcas);
        }
    }
}
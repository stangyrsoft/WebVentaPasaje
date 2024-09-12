using System.ComponentModel.DataAnnotations;

namespace WebVentaPasaje.Models
{
    public class MarcaModel
    {
        [Display(Name = "Codigo Marca")]
        public int Id { get; set; }
        [Display(Name = "Nombre Marca")]
        public string Nombre { get; set; }
        [Display(Name = "Descripcion Marca")]
        public string Descripcion { get; set; }
        public int Bhabilitado { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;


namespace Tarea_Formulario_de_Registro_de_productos.Models
{
    public class Contacto
    {
          [Required]
        public string nombre { get; set; }

        [Required]
         public string precio { get; set; }

         [Required]
         public string descripcion { get; set; }
    }
}
namespace Tarea_Formulario_de_Registro_de_productos.Models
{
    public class Contacto
    {
          [Required]
        public string nombre { get; set; }

        [Required]
        [EmailAddress]
         public string correo { get; set; }
    }
}
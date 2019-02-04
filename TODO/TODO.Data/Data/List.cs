using System.ComponentModel.DataAnnotations;

namespace TODO.Data.Data
{
    public enum Estado
    {
        Creada, Terminada
    }

    public class List
    {
        [Key]
        public int ListID { get; set; }

        [StringLength(20, ErrorMessage = "El nombre no puede pasar de los 20 caracteres")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [StringLength(50, ErrorMessage = "Limite de caracteres exedidos")]
        [Required(ErrorMessage = "La descripcion es requerida")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Categoria requerida")]
        public int CategoriasID { get; set; }

        [Required(ErrorMessage = "Estado requerido")]
        public Estado Estado { get; set; }

        public virtual Categorias Categorias { get; set; }
    }
}

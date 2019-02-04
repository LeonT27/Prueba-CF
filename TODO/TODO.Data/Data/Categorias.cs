using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TODO.Data.Data
{
    public class Categorias
    {
        [Key]
        public int CategoriasID { get; set; }

        [StringLength(20, ErrorMessage = "El nombre no puede pasar de los 20 caracteres")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        public virtual ICollection<List> List { get; set; }
    }
}

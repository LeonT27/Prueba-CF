using System.Collections.Generic;
using TODO.Data.Data;

namespace TODO.Web.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Categorias> Categorias { get; set; }
        public IEnumerable<List> Lists { get; set; }
    }
}
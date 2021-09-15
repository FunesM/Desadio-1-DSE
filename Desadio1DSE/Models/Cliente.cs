using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Desadio1DSE.Models
{
    public partial class Cliente
    {
        [Key]
        public int id { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage ="Campo Nombres requerido")]
        public string nombres { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Campo Primer Apellido requerido")]
        public string primerApellido { get; set; }

        [StringLength(100)]
        public string segudnoApellido { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage ="Campo Telefono requerido")]
        public string Telefono { get; set; }

        [StringLength(100)]
        [EmailAddress(ErrorMessage ="El Email ingresado no cumple con el formato requerido")]
        public string Email { get; set; }
    }
}
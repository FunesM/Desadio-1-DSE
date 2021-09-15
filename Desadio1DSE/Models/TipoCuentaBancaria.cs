using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Desadio1DSE.Models
{
    public partial class TipoCuentaBancaria
    {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Ingrese el Tipo de Cuenta Bancaria")]
        public string TipoCuenta { get; set; }

    }
}
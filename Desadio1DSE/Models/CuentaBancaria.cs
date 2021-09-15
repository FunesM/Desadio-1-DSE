using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Desadio1DSE.Models
{
    public partial class CuentaBancaria
    {
        [Key]
        public int id { get; set; }

        public int? Tipo { get; set; }

        public virtual TipoCuentaBancaria TipoCuentaBancaria_Inv { get; set; }

        public int? Cliente_id { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
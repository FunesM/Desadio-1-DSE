using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Desadio1DSE.Models
{
    public class Transacciones
    {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Ingrese el Tipo de Transaccion a realizar")]
        public string tipoTransaccion { get; set; }

        [Required(ErrorMessage ="Ingrese el Monto de la transaccion")]
        public int Monto { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage ="Campo Estado requerido")]
        public string Estado { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="dd/MM/yyyy")]
        public DateTime fechaTransaccion { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime fechaAplicacion { get; set; }

        public int? CuentaBancaria_id { get; set; }

        public virtual CuentaBancaria CuentaBancaria { get; set; }
    }
}
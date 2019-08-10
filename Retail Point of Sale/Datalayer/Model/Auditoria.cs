using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Model
{
    public class Auditoria
    {
        public Auditoria()
        {
            FechaCreacion = DateTime.MinValue;
            FechaModificacion = FechaCreacion;
        }

        public bool Estatus { get; set; }
        [StringLength(256)]
        public string UsuarioCreacion { get; set; }
        [StringLength(256)]
        public string UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; } 
    }
}


 

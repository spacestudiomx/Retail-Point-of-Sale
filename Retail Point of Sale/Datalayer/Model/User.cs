using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Model
{
    public class User:Auditoria
    {
        [Key]
        public int Id { get; set; }
           
        [MaxLength(200)]
        [Display(Name = "Nombre Completo")]
        public string Name { get; set; }

        [MaxLength(200)]
        [Display(Name = "Apellido")]
        public string Lastname { get; set; }

        [MaxLength(200)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [MaxLength(200)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [MaxLength(200)]
        [Display(Name = "Status")]
        public bool Status { get; set; }




    }
}

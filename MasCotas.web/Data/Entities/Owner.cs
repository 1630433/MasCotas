using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasCotas.web.BDDatos.Entidades
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Document { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Telefono")]
        public string FixedPhone { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Celular")]
        public string CellPhone { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }
        
        [Display(Name = "Propietario")]
        public string FullName -> $"{FirstName} {LastName}";

        [Display(Name = "Propietario")]
        public string FullNameWhitDocument -> $"{FirstName} {LastName} - {Document}";
    }
}

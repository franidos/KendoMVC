using APi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API.Models
{
    public class Productos
    {
        [Required]
        [Key]
        [DataMember]
        public int ProductID { get; set; }

        [StringLength(150)]
        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public decimal? Peso { get; set; }

        [DataMember]
        public int? UserID { get; set; }
        [DataMember]
        [ForeignKey("UserID")]
        public Users Usuario { get; set; }
        //public virtual Users Usuario { get; set; }//Lazy loading: permite cargar los datos foraneos automatic

        public string Categoria { get; set; }        

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PC3.Models
{


    [Table("usuario")]
    public class usuario
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }


        [Column("nombreproducto")]
        public string nombreproducto { get; set; }



        [Column("foto")]
        public string foto { get; set; }



        [Column("descripcion")]
        public string descripcion { get; set; }



        [Column("precio")]
        public string precio { get; set; }


        [Column("celular")]
        public string celular { get; set; }
        

        [Column("lugar")]
        public string lugar { get; set; }


        [Column("nombreusuario")]
        public string nombreusuario { get; set; }

       


    }
}
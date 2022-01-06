using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Amor_na_Pele_Squad09_Entrega02.Models
{
    [Table("CadastroMulher")]
    public class CadastroMulher
    {
        [Key]
        public int ID_Mulher { get; set; }

        public string nomeMulher { get; set; }

        public DateTime dataNascimento { get; set; }

        public String numeroTelefoneMulher { get; set; }

        public string emailMulher { get; set; }
        
    }
}

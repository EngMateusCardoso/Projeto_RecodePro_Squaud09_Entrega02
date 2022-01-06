using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amor_na_Pele_Squad09_Entrega02.Models
{
    [Table("CadastroContato")]
    public class CadastroContato
    {
        [Key]
        public int ID_Contato { get; set; }

        public String nomeContato { get; set; }

        public String emailContato { get; set; }

    }
}

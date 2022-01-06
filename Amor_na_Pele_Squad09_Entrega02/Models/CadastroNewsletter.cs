using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amor_na_Pele_Squad09_Entrega02.Models
{
    [Table("CadastroNewsletter")]
    public class CadastroNewsletter
    {
        [Key]
        public int ID_Newsletter { get; set; }

        public String emailNewsletter { get; set; }

        public String nomeNewsletter { get; set; }

        public Boolean aceitaReceber { get; set; }
    }
}


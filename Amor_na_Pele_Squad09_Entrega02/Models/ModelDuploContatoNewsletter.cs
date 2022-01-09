using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amor_na_Pele_Squad09_Entrega02.Models
{
    public class ModelDuploContatoNewsletter
    {
        [Key]
        public int ID_ModelDuploContatoNewsletter { get; set; }

        public CadastroContato cadCont { get; set; }

        public CadastroNewsletter cadNews { get; set; }
    }
}

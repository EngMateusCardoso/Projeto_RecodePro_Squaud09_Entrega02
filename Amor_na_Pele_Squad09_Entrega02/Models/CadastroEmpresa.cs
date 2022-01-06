using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amor_na_Pele_Squad09_Entrega02.Models
{
    [Table("CadastroEmpresa")]
    public class CadastroEmpresa
    {
        [Key]
        public int ID_Empresa { get; set; }

        public String nomeParaContatoEmpresa { get; set; }

        public String Cnpj { get; set; }

        public String RazaoSocial { get; set; }

        public String NumeroTelefoneEmpresa { get; set; }

        public String emailEmpresa { get; set; }

        public String estado { get; set; }

        public String cidade { get; set; }

        public String endereco { get; set; }

        public String descricaoNegocio { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Classe
{
    class classePrestador : classePessoaJuridica
    {
        private int visitaId { get; set; }
        private int pessoaJuridicaId { get; set; }
        private string servicodescricao { get; set; }
    }
}

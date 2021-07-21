using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Classe
{
    class classeVisitantes : classePessoaFisica
    {
        private int visitaId { get; set; }
        private DateTime dataVisita { get; set; }
        private int pessoaFidicaId { get; set; }
        private int habitacaoId { get; set; }
        private int tipoVisitanteId { get; set; }

    }
}

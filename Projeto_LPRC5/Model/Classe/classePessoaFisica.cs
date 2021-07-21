using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Classe
{
    class classePessoaFisica : classePessoa
    {
        private string cpf;
        private string rg;

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getRg()
        {
            return rg;
        }

        public void setRg(string rg)
        {
            this.rg = rg;
        }
    }
}

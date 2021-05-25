//****************************************************************************************
//**Criado por:Guilherme de Andrade Rissato
//**Data de Criação:24/05/2021
//**Instruções: get's e set's do objeto funcionario
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeFuncionario
    {
        private int funcionarioId;
        private string funcionarioNome;
        private string funcionarioSenha;
        private int funcionarioNivelId;

        public classeFuncionario()
        {

        }
            public classeFuncionario(int funcionarioId, string funcionarioNome, string funcionarioSenha, int funcionarioNivelId)
        {
            this.funcionarioId = funcionarioId;
            this.funcionarioNome = funcionarioNome;
            this.funcionarioSenha = funcionarioSenha;
            this.funcionarioNivelId = funcionarioNivelId;
        }

        public void setFuncionarioId(int id) {
            funcionarioId = id;
        }

        public int getFuncionarioId() {
            return funcionarioId;
        }

        public void setFuncionarioNome(string nome)
        {
            funcionarioNome = nome;
        }

        public string getFuncionarioNome()
        {
            return funcionarioNome;
        }

        public void setFuncionarioSenha(string senha)
        {
            funcionarioSenha = senha;
        }

        public string getFuncionarioSenha()
        {
            return funcionarioSenha;
        }
        public void setFuncionarioNivelId(int nivelId)
        {
            funcionarioNivelId = nivelId;
        }

        public int getFuncionarioNivelId()
        {
            return funcionarioNivelId;
        }
    }
}

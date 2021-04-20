//****************************************************************************************
//**Criado por: Geanluca
//**Data de Criação: 20/04/2021
//**Instruções:
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

namespace Projeto_LPRC5 {
    class classeCidade {
        //Atributos da Classe
        private int cidadeId;
        private string cidadeNome;

        //Método Construtor
        public classeCidade() {

        }

        //Métodos Acessores
        public void setCidadeId(int id) {
            cidadeId = id;
        }
        public int getCidadeId() {
            return cidadeId;
        }
        public void setCidadeNome(string nome) {
            cidadeNome = nome;
        }
        public string getCidadeNome() {
            return cidadeNome;
        }
    }
}

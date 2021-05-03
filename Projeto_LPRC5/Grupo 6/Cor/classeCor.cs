//****************************************************************************************
//**Criado por: Guilherme, Alexandro, Caique
//**Data de Criação: 20/04/2021
//**Instruções: Classe para auxiliar o form de Cor.
//
//****** Atualizações: Get,set 
//*** Data:20/04/2021
//*** Responsável:Caique Bruno
//
//****** Atualizações: Criação do construtor
//*** Data:01/05/2021
//*** Responsável:Amanda Ferrari, André Costa, Giovanna Valim
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeCor
    {
        private int corId;
        private string corNome;

        public classeCor()
        {

        }

        public classeCor(int id, string nome)
        {
            corId = id;
            corNome = nome;
        }

        public void setCorId(int idCor)
        {
            corId = idCor;
        }

        public int getCorId()
        {
            return corId;
        }

        public void setCorNome(string NomeCor)
        {
            corNome = NomeCor;
        }

        public string getCorNome()
        {
            return corNome;
        }
    }
}

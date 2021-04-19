//****************************************************************************************
//**Criado por:
//**Data de Criação:
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

namespace Projeto_LPRC5
{
    class classeClassificaPessoa
    {
        //Atributos da Classe
        private int defaultId;

        //Método Construtor
        public classeClassificaPessoa()
        {

        }

        //Métodos Acessores
        public void setId(int id)
        {
            defaultId = id;
        }
        public int getId()
        {
            return defaultId;
        }
     } 
}

//****************************************************************************************
//**Criado por: André Sirikaku Miyashiro
//**Data de Criação: 19/04/2021
//**Instruções: criação dos atributos dia, mês e descrição utilizando prop.
// O prop ja cria os metodos get e set para os atributos criados
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
    class classeFeriado
    {
        //Atributos da Classe
        private int feriadoId;
        public int Dia { get; set; }
        public int Mes { get; set; }
        public string Descricao { get; set; }

        //Método Construtor
        public classeFeriado()
        {

        }

        //Métodos Acessores
        public void setId(int id)
        {
            feriadoId = id;
        }
        public int getId()
        {
            return feriadoId;
        }
     } 
}
